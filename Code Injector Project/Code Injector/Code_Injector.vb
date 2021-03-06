﻿Imports System
Imports System.Type
Imports System.Activator
Imports System.Runtime.InteropServices
Imports Inventor
Imports System.IO
Imports System.IO.IsolatedStorage
Imports Autodesk.iLogic.Automation
Imports Autodesk.iLogic.Interfaces

Public Class Code_Injector
    Public openInventorApp As Inventor.Application
    'Create a new object called iLogicObject

    Dim wasStarted As Boolean = False

    Dim invProcess As New InventorProcess()

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        invProcess.StartInventor()
        openInventorApp = invProcess.Application
        openInventorApp.Visible = False

    End Sub

    'All of the Subs that handle the preparation work are found first, while the workhorses are found further below (Specifically after the Sub Button_1Click).

    'Fires when the Import Rule button is pressed 

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImportRuleFromFile_Button.Click

        'Open a file browser window, and if the user clicks OK, then do the following...

        If RuleFileDialog.ShowDialog() = DialogResult.OK Then

            'Create a new StreamReder to read the contents of the text file selected... 

            Using ruleFileReader As New System.IO.StreamReader(RuleFileDialog.FileName)

                'Make a container to store that text
                Dim newRuleText As String

                'Throw that text into the container
                newRuleText = ruleFileReader.ReadToEnd

                'Check if the Rule Editing box already has some text in it
                If Rule_Contents_TextBox.TextLength > 0 Then

                    'If it does, we'll go to the next line before adding our imported text
                    Rule_Contents_TextBox.AppendText(vbNewLine & newRuleText)
                Else

                    'If it doesn't, we'll add our text with no new line
                    Rule_Contents_TextBox.Text = newRuleText
                End If

                'Tells you that everything went A-OK! Of course you could have told that by looking
                'at the contents of the Rule Editor box. 

                MessageBox.Show("Text Copied", "Rule Copy Success")

                'Now we'll close down that StreamReader by ending the Using statement. 
            End Using
        End If
    End Sub

    'Fires when the Clear Rule Code Text button is pressed

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearRuleText_Button.Click
        'Clears all text inside of the Rule Code Text box.
        Rule_Contents_TextBox.Clear()
    End Sub

    'Fires when the Select Folder button is pressed

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectFolder_Button.Click

        'Opens the Folder Browser, and if the user clicks on the OK button, do the following...
        If Directory_Browse_Dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then


            Dim IPTExt, IAMExt, IDWExt, DWGExt As String

            'Looks at the state of IPT check box, to see whether or not it's checked.
            If CheckIPT.CheckState = CheckState.Checked Then
                IPTExt = ".ipt"
            Else
                IPTExt = ""
            End If

            'Looks at the state of IAM check box, to see whether or not it's checked.
            If CheckIAM.CheckState = CheckState.Checked Then
                IAMExt = ".iam"
            Else
                IAMExt = ""

            End If

            'Looks at the state of IDW check box, to see whether or not it's checked.
            If CheckIDW.CheckState = CheckState.Checked Then
                IDWExt = ".idw"
            Else
                IDWExt = ""
            End If

            'Looks at the state of DWG check box, to see whether or not it's checked.
            If CheckDWG.CheckState = CheckState.Checked Then
                DWGExt = ".dwg"
            Else
                DWGExt = ""
            End If

            'Checks to see if there are any items already in the list of queue files. 
            'If there are, then we will clear them from that list. 

            If ListBox1.Items() IsNot Nothing Then
                ListBox1.Items.Clear()
            End If

            'Sets the string DirectoryPath to the path of the selected folder

            Dim DirectoryPath As String
            DirectoryPath = Directory_Browse_Dialog.SelectedPath


            Dim _files As Stack = getFiletypes(DirectoryPath, {"*.ipt", "*.iam", "*.idw", "*.dwg"})

            Dim fileDetail As IO.FileInfo
            Dim strafile As String = ""

            'For every file that we find inside the directory and its subfolders ...
            For Each strafile In _files
                'We do the same thing for each file extension.
                'If the value of the ???Ext = the extension in question
                'we'll add it to the list of files in queue. 


                fileDetail = My.Computer.FileSystem.GetFileInfo(strafile)
                'Skip the files in the OldVersions folders
                If Strings.Right(fileDetail.DirectoryName, 11) <> "OldVersions" Then

                    fileDetail = My.Computer.FileSystem.GetFileInfo(strafile)
                    If IPTExt = ".ipt" Then
                        If fileDetail.Extension = ".ipt" Then
                            ListBox1.Items.Add(fileDetail.FullName)
                        End If
                    End If

                    If IAMExt = ".iam" Then
                        If fileDetail.Extension = ".iam" Then
                            ListBox1.Items.Add(fileDetail.FullName)
                        End If
                    End If

                    If IDWExt = ".idw" Then
                        If fileDetail.Extension = ".idw" Then
                            ListBox1.Items.Add(fileDetail.FullName)
                        End If
                    End If

                    If DWGExt = ".dwg" Then
                        If fileDetail.Extension = ".dwg" Then
                            If openInventorApp.FileManager.IsInventorDWG(strafile) = True Then
                                ListBox1.Items.Add(fileDetail.FullName)
                            End If
                        End If
                    End If
                End If
            Next strafile
        End If

    End Sub

    'Fires when the Clear Folder List button is pressed

    Private Sub ClearFolderList_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearFolderList_Button.Click
        'Clears the list of files in queue
        ListBox1.Items.Clear()
    End Sub

    'Fires when the Clear Selected From List button is pressed

    Private Sub ClearSelectedFromList_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearSelectedFromList_Button.Click

        'Sets up a loop that looks at each *SELECTED* item in the list of files in queue.
        For i As Integer = (ListBox1.SelectedItems.Count - 1) To 0 Step -1
            'Removes each of those items from the list.
            ListBox1.Items.Remove(ListBox1.SelectedItems(i))
        Next

    End Sub

    'Fires when the Exit button is pressed

    Private Sub ExitProgram_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitProgram_Button.Click
        'Tells the form to run its Close subroutine.
        Me.Close()

        If Not openInventorApp Is Nothing Then
            openInventorApp.Visible = True
        End If
    End Sub

    'Fires when the program is closing down. This is the Close subroutine

    Private Sub Form1_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles Me.FormClosed

        invProcess.StopInventor()
    End Sub

    'THIS IS WHERE THE MAGIC(S) START TO HAPPEN'

    'Fires when the Add Rule button is pressed

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddRules_Button.Click

        'First, let's check to see if we have any files in queue to process. 
        'If we don't, then... 

        If ListBox1.Items.Count = 0 Then
            MessageBox.Show("There is no folder or file(s) to process.", "No Folder / File Selected!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'If we get here, that means that we do have files to process. 
        'Let's see if the rule we will create has been given a name by the user
        'If the Rule Name text has been left blank then... 

        If RuleNameTextBox1.Text = "" Then
            MessageBox.Show("Please enter a valid (non-blank) name for your rule before continuing.", "No Rule Name Selected", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub

            'Otherwise we will make sure that characters being used are either numbers, letters, or an underscore. 
        Else
            'using a temp variable called character, we look at each Char inside of the string produced from our Rule Name text box.
            For Each character As Char In Me.RuleNameTextBox1.Text

                'Now we'll look at the ASCII numeric value of each string, and see if it fits into 
                'our super special pre-determined characters. 
                'here is a link to an ASCII character chart : http://www.rolbe.com/2009/03/03/vb-keyascii-chart/

                Select Case Asc(character)
                    Case 48 To 57, 65 To 90, 95, 97 To 122
                        'if the case passes, then we end up here... doing nothing!
                    Case Else
                        'if it gets here (because it couldn't pass the above), then we give the user an error message, and exit the sub.
                        MessageBox.Show("The Rule Name that you are attempting to use, may be invalid. Please make sure that you're not using any special characters (other than an underscore)", _
                                        "Rule Name Conflict", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                End Select
            Next
        End If

        'If we're here, it means that we have files to process, and our new rule will have a proper name. 
        'Let's make sure that our New Rule actually has something in it!

        'If the rule contents are empty then... 
        If Rule_Contents_TextBox.Text = "" Then
            MessageBox.Show("Rule text has been left blank! Please include some code / text to populate the new rule(s).", "No Rule Text", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If



        'By turning on the silent operation, we skip all of the dialogs that would normally pop up to inform
        'us that our files are being modified. 
        'Because we are checking (below in the code) if the files are Read Only, we know that we'll only be 
        'messing with files that are able to be messed with.
        openInventorApp.SilentOperation = True


        'On the other hand, if Inventor is running, we shall continue! 

        Dim iLogicObject As Object

        'Check to make sure that the iLogic addin for Inventor is currently running and well. 
        iLogicObject = GetiLogicAddin(openInventorApp)

        'If it couldn't be found then... 
        If (iLogicObject Is Nothing) Then
            MessageBox.Show("Could not find ilogic automation plugin! Unable to complete actions!", "Plugin Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'If the plugin was found, then we'll continue -

        'We'll start by making initializing a new Integer called listCount
        Dim listCount As Integer

        'We'll also tell our progress bar to only be as long, as there are items to count.
        ToolStripProgressBar1.Maximum = ListBox1.Items.Count

        'In addition we can also set up just how much each step in our progress bar will take us.
        ToolStripProgressBar1.Step = 1

        'We'll make a loop that counts down from the number items in our file queue list
        'one by one. 
        For listCount = ListBox1.Items.Count To 1 Step -1

            'Create and empty Document called singleDoc
            Dim singleDoc As Document

            'Sets singleDoc to the item that is currently being looked at, from our file queue.
            'This also opens the document in Inventor for editing. 
            singleDoc = openInventorApp.Documents.Open(ListBox1.Items(listCount - 1), True)

            'Let's make sure we're allowed to modify this document. 
            'If the file is 'Read Only' then it will be skipped!
            If singleDoc.IsModifiable = True Then

                'If we can modify it, then we'll continue. 

                'At this point we'll go to the CreateRule subroutine, passing our Document, and our iLogicObject to it.
                Call CreateRule(singleDoc, iLogicObject)

                Dim saveEnabled As Boolean = iLogicObject.RulesOnEventsEnabled
                iLogicObject.RulesOnEventsEnabled = False
                Try
                    'Save the document and all dependant documents.
                    Call singleDoc.Save2(True)

                    'Just incase the file you're attempting to save to, can't be saved to...

                Catch ex As Exception

                    MessageBox.Show("The directory / file you are attempting to save to is Read-Only." & vbCrLf & _
                                    "Please make sure that you have permission to write to this directory / file before attempting to continue.", _
                                    "Read-Write Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub

                Finally
                    iLogicObject.RulesOnEventsEnabled = saveEnabled
                End Try

                'Closes the document without any hassle. 
                Call openInventorApp.ActiveDocument.Close(True)
            Else
                'This area is blank. 
                'If you want something to happen when you find that a document can not be modified, then you would put it here.
                'Otherwise, you can leave this area blank. 
            End If

            'Last but not least, let's show that we've completed work on the file, by increasing our progress bar by one step
            ToolStripProgressBar1.PerformStep()
            'On to the next file.
        Next

        openInventorApp.SilentOperation = False
        openInventorApp.Visible = False
        'Once everything is done, and all the files have been modified, we'll inform the user.
        MessageBox.Show("Operation Complete!", "Status : Finished")

        'We'll also reset the progress bar back to 0
        ToolStripProgressBar1.Value = 0

    End Sub

    'This Funciton is called from the Sub Button1_Click. It simply returns a value if it finds that the 
    'iLogic plugin is present in Inventor as we need that plugin for all of this to work! 
    'it also sets the value iLogicObject which is found in the above code, to the ApplicationAddIn, Automation.
    'Of course, I feel a bit like this is a throw back to the older days of Inventor when 
    'iLogic was a seperate package, and didn't come installed right along with it, however,
    'it never hurt anyone to be safe. 

    Function GetiLogicAddin(ByVal oApplication As Inventor.Application) As Object
        Dim addIns As ApplicationAddIns
        addIns = oApplication.ApplicationAddIns

        Dim addIn As ApplicationAddIn
        On Error GoTo NotFound
        addIn = oApplication.ApplicationAddIns.ItemById("{3bdd8d79-2179-4b11-8a5a-257b1c0263ac}")

        If (addIn Is Nothing) Then
            Return Nothing
            Exit Function
        End If

        addIn.Activate()
        GetiLogicAddin = addIn.Automation
        Exit Function
NotFound:
    End Function

    Private Sub CreateRule(ByVal activeDoc As Document, ByVal iLogicAuto As Object)

        'Creates a new String called ruleName, and sets it to Rule Name that user added
        Dim ruleName As String
        ruleName = RuleNameTextBox1.Text

        'Creates a new String called ruleText, and sets it to the text contained in the Rule Code Text box.
        Dim ruleText As String
        ruleText = Rule_Contents_TextBox.Text

        'Creates a new Object called rule.
        Dim rule As Object

        'using our new object, we'll attempt to get the rule from the active document that is named the same 
        'as the rule name that the user put in.
        rule = iLogicAuto.GetRule(activeDoc, ruleName)

        'creates a new Object called exRule, that we will leave blank for now. 
        Dim exRule As Object

        'if our rule Object doesn't equal anything (which means that it couldn't find a rule with the same
        'name, then we'll do the following.
        If (rule Is Nothing) Then

            'If the user has checked the Run Rules On Creation box, then... 
            If RunRulesOnCreation_CheckBox.CheckState = CheckState.Checked Then
                'We'll create a new rule in the current document, with our rule name, and our rule text
                'By default when a rule is created, it is ran
                Call iLogicAuto.Addrule(activeDoc, ruleName, ruleText)
                If DeleteAfterRun_RadioButton.Checked = True Then iLogicAuto.DeleteRule(activeDoc, ruleName) ' Delete rule after run if radiobutton is checked
                'otherwise...
            Else

                'We will create a rule in the current document, that has a name, but doesn't have any text. 
                'This way the rule will fire with nothing to do, meaning that it does nothing! 
                Call iLogicAuto.AddRule(activeDoc, ruleName, "")


                'Now we can use that empty object, and grab rule that we just created. 
                exRule = iLogicAuto.GetRule(activeDoc, ruleName)

                'Now we can assign the users rule text to that rule, without it actually running. 
                exRule.Text = ruleText
            End If
        Else
            'If we're here, it means that we did find another rule inthe document that had the same name
            'as the rule we wanted to add. 


            'check against rule text to see if it equals current text
            'if it does, do nothing, if it doesn't, prompt user for an overwrite

            'Set our empty object to the rule that exists. 
            exRule = iLogicAuto.GetRule(activeDoc, ruleName)

            'If the user chcked the Overwrite Duplicate Rules box, then... 
            If OverwriteDuplicateRules_CheckBox.CheckState = CheckState.Checked Then
                If RunRulesOnCreation_CheckBox.CheckState = CheckState.Checked Then
                    exRule.Text = ruleText
                    iLogicAuto.RunRule(activeDoc, ruleName)
                    If DeleteAfterRun_RadioButton.Checked = True Then iLogicAuto.DeleteRule(activeDoc, ruleName)
                Else
                    'We'll simply replace the text inside of the existing rule with the text the user entered into the Rule Code Text box.
                    exRule.Text = ruleText
                End If

                'otherwise...
            Else

                'If the rule in the document has the exact same text as the user entered text, then there is nothing to change. 
                If exRule.Text = ruleText Then

                    If RunRulesOnCreation_CheckBox.CheckState = CheckState.Checked Then
                        iLogicAuto.RunRule(activeDoc, ruleName)
                        If DeleteAfterRun_RadioButton.Checked = True Then iLogicAuto.DeleteRule(activeDoc, ruleName)
                    End If

                    'We'll initialize the Sub InitTriggers, and pass along a Document, and String
                    InitTriggers(activeDoc, ruleName)

                    'When that's done, we'll exit this Sub
                    Exit Sub


                Else

                    'If the text doesn't match, then we'll let the user decide if they want to replace it. 

                    'If they select YES for the message box that shows up, then we will replace the existing rule's text with the user's text.
                    If MessageBox.Show("The old rule does not match the new you are trying to overwrite it with. Would you like to continue?", _
                                       "Duplicate Rule Text Mismatch", MessageBoxButtons.YesNo, MessageBoxIcon.Hand) = Windows.Forms.DialogResult.Yes Then
                        exRule.Text = ruleText

                        If RunRulesOnCreation_CheckBox.CheckState = CheckState.Checked Then
                            iLogicAuto.RunRule(activeDoc, ruleName)
                            If DeleteAfterRun_RadioButton.Checked = True Then iLogicAuto.DeleteRule(activeDoc, ruleName)
                        End If

                    Else

                        'If the user doesn't want to replace the rule, then we'll exit the sub, and no changes will be made.
                        'This will also NOT apply any EventTriggers to the file. 
                        MessageBox.Show("File will be skipped.", "Duplicate Rule Skip", MessageBoxButtons.OK)
                        Exit Sub
                    End If
                End If
            End If
        End If

        'We'll initialize the Sub InitTriggers, and pass along a Document, and String
        InitTriggers(activeDoc, ruleName)

    End Sub

    Private Sub InitTriggers(ByVal currentDoc As Document, ByVal currentRuleName As String)

        'Let's make a new Integer, and String. 
        Dim checkedCounter As Integer
        Dim checkedName As String

        'If the user has not selected any Event Triggers, then we have no need to continue. We'll simply exit this sub.
        If EventTriggers_CheckedListBox1.CheckedItems.Count = 0 Then
            Exit Sub
        Else

            'If the user has checked a/an Event Trigger(s), Then we'll need to go through each item that the user
            'has checked. 

            'For every Event Trigger that was checked... 
            For checkedCounter = 0 To EventTriggers_CheckedListBox1.CheckedItems.Count - 1

                'We will set our checkedName variable to the current Event Trigger title.
                checkedName = EventTriggers_CheckedListBox1.CheckedItems(checkedCounter).ToString()

                'We then gather all of this information and send it off to our VerifyTrigger Sub
                VerifyTrigger(currentDoc, currentRuleName, checkedName)
            Next
        End If
    End Sub

    Private Sub VerifyTrigger(ByVal cDoc As Document, ByVal rName As String, ByVal trigName As String)

        'Let's set up some new data containers. 2 Strings and an Integer.


        Dim BaseID As Integer
        Dim BaseName As String
        Dim BaseUse As String

        'Now... Let's talk. 
        'At this point I have to sort of point out why I'm doing the things I'm doing, sadly, it takes more 
        'than a simple 1 line comment. 
        'Event Triggers work in a sort of strange way. As I accidentally found out, -
        'each Event Trigger is just a Property in the PropertySet called "iLogicEventsRules"
        'Though unlike a regular property, you MUST assign a PropertyID to them when you create them, 
        'AND the property ID, MUST fall withen a certain range, otherwise, the trigger will simply not work.
        '
        'Below is a list of CheckList Box Names / Property Names / Property IDs. 
        '
        'The Checklist Box Name is just the name that the user sees next to the checkboxes while they are 
        'selecting the various Event Triggers. I've tried to keep the names as close to what you would see
        'in Inventor, had you set it up manually.
        '
        'The Property Name is the Name that is passed to the newly created Property. It's not as simple as
        'passing just that name to the new property. You also have to tack on a numeric value to it! 
        ' Example : AfterDocOpen1
        'The numeric value simply tells Inventor the order in which to fire off the values associated with
        'Event Triggers of the same type. To give you an example, let's assume that you want Rule1 and Rule2
        'to both fire after the document is opened. If you were look at the properties of both of them,
        'you would find that Rule1 would have a property name of AfterDocOpen0, and Rule2 would have a 
        'property name of AfterDocOpen1.
        '
        '
        'The PropertyID is the default base Property ID that must be passed along to the property.
        'Using the example above (Rule1 and Rule2), the entire property items would read out as : 
        '
        '("Rule1", "AfterDocOpen0", 400)
        ' &
        '("Rule2", "AfterDocOpen1", 401)
        '
        'Now that I think about it, I don't believe that I have tested out whether or not the 
        'numerical ending for the PropertyName should be the same amount added to the base PropertyID,
        'but in the code below, I keep both values the same as it seems a rather fragile thing. 
        '
        'I should also note that if you fail to include a PropertyID, and simply let Inventor set one
        'for you, it will choose a number that is out of range, and though it will still 'look' as if
        'it has created a working Trigger, it will actually do nothing. 
        '
        'Below is a list of the Event Triggers for .ipt files (Solid and Sheet Metal) - 
        '.iam files (Assembly), and .idw/.dwg files (Drawing Files). I do not know if this if the complete list
        'of all available triggers inside of Inventor, as there maybe some filetypes / variations that I have
        'overlooked (do not use regularly / at all). If you find that this list is incomplete, feel free to
        'contact me using the information posted at the very topmost comments in this code. 
        '
        '
        '   CheckList Box Name:                     : Property Name :                 : Property ID
        '   ----------------------------------------------------------------------------------------
        '   After Open Document                     : AfterDocOpen                    : 400
        '   Close(Document)                         : DocClose                        : 500
        '   Before Save Document                    : BeforeDocSave                   : 700
        '   After Save Document                     : AfterDocSave                    : 800
        '   Any Model Parameter Change              : AfterAnyParamChange             : 1000
        '   Part Geometry Change**                  : PartBodyChanged                 : 1200
        '   Material Change**                       : AfterMaterialChange             : 1400
        '   Drawing View Change***                  : AfterDrawingViewsUpdate         : 1800
        '   iProperty(Change)                       : AfterAnyiPropertyChange         : 1600
        '   Feature Suppression Change**            : AfterFeatureSuppressionChange   : 2000
        '   Component Suppression Change*           : AfterComponentSuppressionChange : 2200
        '   iPart / iAssembly Change Component*     : AfterComponentReplace           : 2400
        '   New Document                            : AfterDocNew                     : 2600
        '
        '   ----------------------------------------------------------------------------------------



        'Let's look at the Event Trigger that user has selected (that has been passed to use here)

        'If it matches the Case, then we will change the values of BaseName to the correct PropertyName
        'We will change BaseID to the correct Base PropertyID
        'And we will set where this trigger can be used, with the BaseUse value.

        'A BaseUse of "All" means that it's a Trigger that can be used across the file types (.ipt/.iam/.idw/.dwg)
        'A BaseUse of "Part" means that the trigger can only be used on a .ipt file.
        'A BaseUse of "Assembly" means that the trigger can only be used on a .iam file.
        'A BaseUse of "Drawing" means that the trigger can only be used on a .idw/.dwg file.

        Select Case trigName
            Case "After Open Document"
                BaseName = "AfterDocOpen"
                BaseID = 400
                BaseUse = "All"
            Case "Close Document"
                BaseName = "DocClose"
                BaseID = 500
                BaseUse = "All"
            Case "Before Save Document"
                BaseName = "BeforeDocSave"
                BaseID = 700
                BaseUse = "All"
            Case "After Save Document"
                BaseName = "AfterDocSave"
                BaseID = 800
                BaseUse = "All"
            Case "Any Model Parameter Change"
                BaseName = "AfterAnyParamChange"
                BaseID = 1000
                BaseUse = "All"
            Case "Part Geometry Change**"
                BaseName = "PartBodyChanged"
                BaseID = 1200
                BaseUse = "Part"
            Case "Material Change**"
                BaseName = "AfterMaterialChange"
                BaseID = 1400
                BaseUse = "Part"
            Case "Drawing View Change***"
                BaseName = "AfterDrawingViewsUpdate"
                BaseID = 1800
                BaseUse = "Drawing"
            Case "iProperty Change"
                BaseName = "AfterAnyiPropertyChange"
                BaseID = 1600
                BaseUse = "All"
            Case "Feature Suppression Change**"
                BaseName = "AfterFeatureSuppressionChange"
                BaseID = 2000
                BaseUse = "Part"
            Case "Component Suppression Change*"
                BaseName = "AfterComponentSuppressionChange*"
                BaseID = 2200
                BaseUse = "Assembly"
            Case "iPart / iAssembly Change Component*"
                BaseName = "AfterComponentReplace"
                BaseID = 2400
                BaseUse = "Assembly"
            Case "New Document"
                BaseName = "AfterDocNew"
                BaseID = 2600
                BaseUse = "All"
            Case Else

                'If the value passed, doesn't match any of the Cases, then we'll throw up a crazy message box!
                'It also means that I probably have a spelling error :( 

                BaseUse = "None"
                MessageBox.Show("Trigger Event Error in Selection", "Trigger Event Selection Error")
                Exit Sub
        End Select


        'First we check what the BaseUse is set to, then we check that against the current document's type.
        'If they match up, we pass the current Document, the rule name, the trigger name, the base trigger name, and
        'the base trigger ID to the sub SetEventProperty

        If BaseUse = "All" Then
            If cDoc.DocumentType = DocumentTypeEnum.kAssemblyDocumentObject _
                Or cDoc.DocumentType = DocumentTypeEnum.kDrawingDocumentObject _
                Or cDoc.DocumentType = DocumentTypeEnum.kPartDocumentObject Then
                SetEventProperty(cDoc, rName, trigName, BaseName, BaseID)
            Else
                Exit Sub
            End If
        ElseIf BaseUse = "Drawing" Then
            If cDoc.DocumentType = DocumentTypeEnum.kDrawingDocumentObject Then
                SetEventProperty(cDoc, rName, trigName, BaseName, BaseID)
            Else
                Exit Sub
            End If
        ElseIf BaseUse = "Assembly" Then
            If cDoc.DocumentType = DocumentTypeEnum.kAssemblyDocumentObject Then
                SetEventProperty(cDoc, rName, trigName, BaseName, BaseID)
            Else
                Exit Sub
            End If
        ElseIf BaseUse = "Part" Then
            If cDoc.DocumentType = DocumentTypeEnum.kPartDocumentObject Then
                SetEventProperty(cDoc, rName, trigName, BaseName, BaseID)
            Else
                Exit Sub
            End If
        ElseIf BaseUse = "None" Then
            Exit Sub
        End If
    End Sub

    Private Sub SetEventProperty(ByVal cDocument As Document, ByVal RuleName As String, ByVal CheckBoxTrigName As String, ByVal TriggerPropName As String, ByVal BaseID As Integer)

        'Because we need to compare so many values, we'll need to set up a few containers

        Dim propItemCounter As Integer
        Dim TriggerID As Integer
        Dim CurrentID As Integer
        Dim EndHolder As Integer
        Dim CurrentEnd As Integer
        Dim customIPropSet As PropertySet

        'EndHolder will act as the numerical value that will be attached to the end of the property name. 
        EndHolder = 0

        'TriggerID will hold on to the Trigger's base PropertyID value.
        TriggerID = BaseID

        Try
            customIPropSet = cDocument.PropertySets.Item("{2C540830-0723-455E-A8E2-891722EB4C3E}")
            If customIPropSet.InternalName <> "{2C540830-0723-455E-A8E2-891722EB4C3E}" Then
                Call customIPropSet.Delete()
                Call cDocument.PropertySets.Add("iLogicEventsRules", "{2C540830-0723-455E-A8E2-891722EB4C3E}")
                customIPropSet = cDocument.PropertySets.Item("{2C540830-0723-455E-A8E2-891722EB4C3E}")
            End If

        Catch ex As Exception
            Try
                Call cDocument.PropertySets.Add("iLogicEventsRules", "{2C540830-0723-455E-A8E2-891722EB4C3E}")
                customIPropSet = cDocument.PropertySets.Item("{2C540830-0723-455E-A8E2-891722EB4C3E}")
            Catch ex2 As Exception
                MessageBox.Show("Unable to create the Event Triggers property for this file!", "Event Triggers Not Set")
                Exit Sub
            End Try
        End Try

        'Sets customIPropSet to equal the Item that contains the Event Triggers of the open document.
        'customIPropSet = cDocument.PropertySets.Item("iLogicEventsRules")

        'If there is an item (Event Trigger) found, then... 
        If customIPropSet.Count > 0 Then

            'We'll make a loop! This will go through each Property (Event Trigger), 1 Property at a time
            For propItemCounter = 1 To customIPropSet.Count Step 1

                'This is for testing purposes. Because the individual Properties that are inside of a PropertySet
                'are not exposed in VB.Net outright, you can uncomment the two lines of code below to allow you to
                'see each Property as it goes through the count, one by one. 
                '----------------------------
                Dim megatest As [Property]
                megatest = customIPropSet.Item(propItemCounter)

                Dim nameTest As String
                nameTest = Strings.Left(customIPropSet.Item(propItemCounter).Name, Len(TriggerPropName))

                Dim idTest As Integer
                idTest = (Convert.ToInt32(Math.Abs(customIPropSet.Item(propItemCounter).PropId / 100))) * 100
                
                If idTest = BaseID Then

                    'If the property name is equal, then we need to see if the Value of the property (AKA: The Rule Name) is
                    'equal to the new rule that we made previously. If it is, Then we're all done! The trigger already exists!
                    If customIPropSet.Item(propItemCounter).Value = RuleName Then
                        Exit Sub
                    Else

                        'UPDATE Feb/3/2012 
                        'Because of the unexpected things that I talk about above, I am making another statement here that will check 
                        'to see if the PropertyName equals our TriggerPropName. 
                        If nameTest = TriggerPropName Then

                            'If that isn't the case, it's alright. But, we'll need to get that numerical value from the end of the current Property
                            'because we will need it later to determine which numerical value is needed for the end of our PropertyName. 
                            'The below line is simply looking at the last character of the current Property's Name, which should be a number, and making sure that it IS a number
                            If IsNumeric(Strings.Right(customIPropSet.Item(propItemCounter).Name, Len(customIPropSet.Item(propItemCounter).Name) - Len(TriggerPropName))) = True Then

                                'If it is a number, then we need to convert that value (because it's still a String), into an Integer, and set CurrentEnd to equal it.
                                CurrentEnd = Convert.ToInt16(Strings.Right(customIPropSet.Item(propItemCounter).Name, Len(customIPropSet.Item(propItemCounter).Name) - Len(TriggerPropName)))

                                'We'll also go on and grab the Property ID of the open Property
                                CurrentID = customIPropSet.Item(propItemCounter).PropId

                                'If the CurrentEnd is larger than our EndHolder (which was defined at the beginning of this sub), Then we need our EndHolder to 
                                'equal 1 more than what is currently in use. Remember that we can't end up with two 'AfterDocSave0' entries. 
                                If CurrentEnd > EndHolder Then
                                    EndHolder = CurrentEnd + 1
                                ElseIf CurrentEnd = EndHolder Then

                                    'However, if CurrentEnd is = to EndHolder, then we'll just add 1 to it. 
                                    EndHolder = EndHolder + 1
                                End If

                                'We do the same thing for the Property ID. 
                                If CurrentID > TriggerID Then
                                    TriggerID = CurrentID + 1
                                ElseIf CurrentID = TriggerID Then
                                    TriggerID = TriggerID + 1
                                End If
                            Else

                                'If for some reason that last character in the Property Name isn't a numeric value, then we have more work to do... 
                                MessageBox.Show("The end string for Var: CurrentEnd, was not a Numeric Value. If you're reading this, something needs debugging!", "Error in SetEventProperty Sub")
                                Exit Sub
                            End If
                        Else

                            CurrentEnd = (customIPropSet.Item(propItemCounter).PropId - BaseID)
                            CurrentID = customIPropSet.Item(propItemCounter).PropId

                            If CurrentEnd > EndHolder Then
                                EndHolder = CurrentEnd + 1
                            ElseIf CurrentEnd = EndHolder Then
                                EndHolder = EndHolder + 1
                            End If

                            If CurrentID > TriggerID Then
                                TriggerID = CurrentID + 1
                            ElseIf CurrentID = TriggerID Then
                                TriggerID = TriggerID + 1
                            End If

                        End If
                    End If
                End If
                'Now we do this all over again for every other item/property (if there are any) in the list
                'each time checking to see if the Trigger already exists, or incrementing the values of the numeric ending for the PropertyName
                'and PropertyID. 
            Next
        End If

        'Now that we're done gathering all of the data on the existing Properties / Items, let's add our own to the list.
        'We call up our CustomIPropSet.Add. 
        'RuleName will be the name of the rule we made earlier. 
        'TriggerPropName & EndHolder equals the BaseID + the numeric value needed to show when it will fire.
        'TriggerID is the new PropertyID that is next in line for use by Inventor. 
        Call customIPropSet.Add(RuleName, TriggerPropName & EndHolder, TriggerID)

        'Let's end this sub! 
        'Now we go all the way back to the sub Button1_Click
        'Whew!
    End Sub

    Private Sub Code_Injector_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        Dim winSize As New System.Drawing.Size(Me.Size.Width, Me.Size.Height)
        Dim stripPadding As New System.Windows.Forms.Padding(winSize.Width - 440, 3, 0, 2)
        ToolStripStatusLabel1.Margin = stripPadding
    End Sub

    Private Sub Code_Injector_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Dim vInfo As String
        vInfo = System.Reflection.Assembly.GetExecutingAssembly.GetName.Version.ToString

        ToolStripStatusLabel1.Text = "Current Version : " & vInfo

    End Sub



    Private Sub RunRulesOnCreation_CheckBox_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunRulesOnCreation_CheckBox.CheckedChanged

        If RunRulesOnCreation_CheckBox.Checked = True Then
            DeleteAfterRun_RadioButton.Enabled = True
            KeepAfterRun_RadioButton.Enabled = True
            KeepAfterRun_RadioButton.Checked = True
            DeleteAfterRun_RadioButton.Checked = False
        Else
            DeleteAfterRun_RadioButton.Enabled = False
            KeepAfterRun_RadioButton.Enabled = False
        End If

    End Sub

    Private Function getFiletypes(ByVal path As String, ByVal args() As String) As Stack
        Dim _files As New Stack
        'Dim folder As New DirectoryInfo(path)
        For Each arg In args
            For Each _file In System.IO.Directory.GetFiles(path, arg, IO.SearchOption.AllDirectories)
                _files.Push(_file)
            Next
        Next
        Return _files
    End Function


    Private Sub SelectfromInventorFileButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SelectfromInventorFileButton.Click

        Try
            RuleSelectorForm.Show()

            Dim iLogicObject As Object
            'Check to make sure that the iLogic addin for Inventor is currently running 
            iLogicObject = GetiLogicAddin(openInventorApp)

            'If it couldn't be found then... 
            If (iLogicObject Is Nothing) Then
                MessageBox.Show("Could not find ilogic automation plugin! Unable to complete actions!", "Plugin Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            '            MessageBox.Show("Inventor has been started in the background")
        Catch ex As Exception
        End Try
    End Sub


    Private Sub DeleteRulesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteRulesButton.Click

        openInventorApp.SilentOperation = True
        Dim iLogicObject As Object

        'Check to make sure that the iLogic addin for Inventor is currently running and well. 
        iLogicObject = GetiLogicAddin(openInventorApp)

        'If it couldn't be found then... 
        If (iLogicObject Is Nothing) Then
            MessageBox.Show("Could not find ilogic automation plugin! Unable to complete actions!", "Plugin Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        'If the plugin was found, then we'll continue -

        'We'll start by making initializing a new Integer called listCount
        Dim listCount As Integer

        'We'll also tell our progress bar to only be as long, as there are items to count.
        ToolStripProgressBar1.Maximum = ListBox1.Items.Count

        'In addition we can also set up just how much each step in our progress bar will take us.
        ToolStripProgressBar1.Step = 1

        'We'll make a loop that counts down from the number items in our file queue list
        'one by one. 
        For listCount = ListBox1.Items.Count To 1 Step -1

            'Create and empty Document called singleDoc
            Dim singleDoc As Document

            'Sets singleDoc to the item that is currently being looked at, from our file queue.
            'This also opens the document in Inventor for editing. 
            singleDoc = openInventorApp.Documents.Open(ListBox1.Items(listCount - 1), True)

            'Let's make sure we're allowed to modify this document. 
            'If the file is 'Read Only' then it will be skipped!
            If singleDoc.IsModifiable = True Then

                'If we can modify it, then we'll continue. 
                iLogicObject.DeleteAllRulesInDocument(singleDoc)

                'Dim saveEnabled As Boolean = iLogicObject.RulesOnEventsEnabled
                'iLogicObject.RulesOnEventsEnabled = False
                Try
                    'Save the document and all dependant documents.
                    Call singleDoc.Save2(True)

                    'Just incase the file you're attempting to save to, can't be saved to...

                Catch ex As Exception

                    MessageBox.Show("The directory / file you are attempting to save to is Read-Only." & vbCrLf & _
                                    "Please make sure that you have permission to write to this directory / file before attempting to continue.", _
                                    "Read-Write Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub

                Finally

                End Try

                'Closes the document without any hassle. 
                Call openInventorApp.ActiveDocument.Close(True)
            Else
                'This area is blank. 
                'If you want something to happen when you find that a document can not be modified, then you would put it here.
                'Otherwise, you can leave this area blank. 
            End If

            'Last but not least, let's show that we've completed work on the file, by increasing our progress bar by one step
            ToolStripProgressBar1.PerformStep()
            'On to the next file.
        Next

        openInventorApp.SilentOperation = False
        openInventorApp.Visible = False
        'Once everything is done, and all the files have been modified, we'll inform the user.
        MessageBox.Show("Operation Complete!", "Status : Finished")

        'We'll also reset the progress bar back to 0
        ToolStripProgressBar1.Value = 0

    End Sub
End Class
