<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Code_Injector
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Code_Injector))
        Me.AddRules_Button = New System.Windows.Forms.Button()
        Me.Rule_Contents_TextBox = New System.Windows.Forms.TextBox()
        Me.Rule_Input_GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SelectfromInventorFileButton = New System.Windows.Forms.Button()
        Me.RuleNameTextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClearRuleText_Button = New System.Windows.Forms.Button()
        Me.ImportRuleFromFile_Button = New System.Windows.Forms.Button()
        Me.RuleFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Directory_Browse_Dialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.SelectFolder_Button = New System.Windows.Forms.Button()
        Me.CheckIPT = New System.Windows.Forms.CheckBox()
        Me.CheckIAM = New System.Windows.Forms.CheckBox()
        Me.CheckIDW = New System.Windows.Forms.CheckBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EventTriggers_CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckDWG = New System.Windows.Forms.CheckBox()
        Me.ClearFolderList_Button = New System.Windows.Forms.Button()
        Me.ClearSelectedFromList_Button = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ExitProgram_Button = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DeleteAfterRun_RadioButton = New System.Windows.Forms.RadioButton()
        Me.KeepAfterRun_RadioButton = New System.Windows.Forms.RadioButton()
        Me.RunRulesOnCreation_CheckBox = New System.Windows.Forms.CheckBox()
        Me.OverwriteDuplicateRules_CheckBox = New System.Windows.Forms.CheckBox()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.InventorLoadingText = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DeleteRulesButton = New System.Windows.Forms.Button()
        Me.Rule_Input_GroupBox1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AddRules_Button
        '
        Me.AddRules_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AddRules_Button.Location = New System.Drawing.Point(823, 505)
        Me.AddRules_Button.Margin = New System.Windows.Forms.Padding(2)
        Me.AddRules_Button.Name = "AddRules_Button"
        Me.HelpProvider1.SetShowHelp(Me.AddRules_Button, True)
        Me.AddRules_Button.Size = New System.Drawing.Size(164, 25)
        Me.AddRules_Button.TabIndex = 14
        Me.AddRules_Button.Text = "Add Rules"
        Me.AddRules_Button.UseVisualStyleBackColor = True
        '
        'Rule_Contents_TextBox
        '
        Me.Rule_Contents_TextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Rule_Contents_TextBox.Location = New System.Drawing.Point(6, 79)
        Me.Rule_Contents_TextBox.Multiline = True
        Me.Rule_Contents_TextBox.Name = "Rule_Contents_TextBox"
        Me.Rule_Contents_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.HelpProvider1.SetShowHelp(Me.Rule_Contents_TextBox, True)
        Me.Rule_Contents_TextBox.Size = New System.Drawing.Size(765, 173)
        Me.Rule_Contents_TextBox.TabIndex = 2
        '
        'Rule_Input_GroupBox1
        '
        Me.Rule_Input_GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Rule_Input_GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Rule_Input_GroupBox1.Controls.Add(Me.SelectfromInventorFileButton)
        Me.Rule_Input_GroupBox1.Controls.Add(Me.RuleNameTextBox1)
        Me.Rule_Input_GroupBox1.Controls.Add(Me.Label2)
        Me.Rule_Input_GroupBox1.Controls.Add(Me.Label1)
        Me.Rule_Input_GroupBox1.Controls.Add(Me.ClearRuleText_Button)
        Me.Rule_Input_GroupBox1.Controls.Add(Me.ImportRuleFromFile_Button)
        Me.Rule_Input_GroupBox1.Controls.Add(Me.Rule_Contents_TextBox)
        Me.Rule_Input_GroupBox1.Location = New System.Drawing.Point(12, 308)
        Me.Rule_Input_GroupBox1.Name = "Rule_Input_GroupBox1"
        Me.Rule_Input_GroupBox1.Size = New System.Drawing.Size(777, 261)
        Me.Rule_Input_GroupBox1.TabIndex = 2
        Me.Rule_Input_GroupBox1.TabStop = False
        Me.Rule_Input_GroupBox1.Text = "Rule Builder :"
        '
        'SelectfromInventorFileButton
        '
        Me.SelectfromInventorFileButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SelectfromInventorFileButton.Location = New System.Drawing.Point(383, 50)
        Me.SelectfromInventorFileButton.Name = "SelectfromInventorFileButton"
        Me.SelectfromInventorFileButton.Size = New System.Drawing.Size(164, 23)
        Me.SelectfromInventorFileButton.TabIndex = 5
        Me.SelectfromInventorFileButton.Text = "Import from Inventor file"
        Me.SelectfromInventorFileButton.UseVisualStyleBackColor = True
        '
        'RuleNameTextBox1
        '
        Me.HelpProvider1.SetHelpString(Me.RuleNameTextBox1, "Input for the name of the rule that you are creating.")
        Me.RuleNameTextBox1.Location = New System.Drawing.Point(100, 24)
        Me.RuleNameTextBox1.Name = "RuleNameTextBox1"
        Me.HelpProvider1.SetShowHelp(Me.RuleNameTextBox1, True)
        Me.RuleNameTextBox1.Size = New System.Drawing.Size(170, 20)
        Me.RuleNameTextBox1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "New Rule Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rule Code Text :"
        '
        'ClearRuleText_Button
        '
        Me.ClearRuleText_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HelpProvider1.SetHelpString(Me.ClearRuleText_Button, "Will clear any text inside of the Rule Code Text box.")
        Me.ClearRuleText_Button.Location = New System.Drawing.Point(607, 19)
        Me.ClearRuleText_Button.Name = "ClearRuleText_Button"
        Me.HelpProvider1.SetShowHelp(Me.ClearRuleText_Button, True)
        Me.ClearRuleText_Button.Size = New System.Drawing.Size(164, 25)
        Me.ClearRuleText_Button.TabIndex = 3
        Me.ClearRuleText_Button.Text = "Clear Rule Code Text"
        Me.ClearRuleText_Button.UseVisualStyleBackColor = True
        '
        'ImportRuleFromFile_Button
        '
        Me.ImportRuleFromFile_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HelpProvider1.SetHelpString(Me.ImportRuleFromFile_Button, "Allows you to import the contents of a text file (.txt), a Visual Basics file (.v" & _
        "b), or an iLogic file (.iLogicVB), directly into the Rule Code Text box.")
        Me.ImportRuleFromFile_Button.Location = New System.Drawing.Point(383, 18)
        Me.ImportRuleFromFile_Button.Name = "ImportRuleFromFile_Button"
        Me.HelpProvider1.SetShowHelp(Me.ImportRuleFromFile_Button, True)
        Me.ImportRuleFromFile_Button.Size = New System.Drawing.Size(164, 25)
        Me.ImportRuleFromFile_Button.TabIndex = 4
        Me.ImportRuleFromFile_Button.Text = "Import From text file"
        Me.ImportRuleFromFile_Button.UseVisualStyleBackColor = True
        '
        'RuleFileDialog
        '
        Me.RuleFileDialog.Filter = "(Formats)|*.txt; *.vb; *.iLogicVB"
        Me.RuleFileDialog.Title = "Rule File Chooser"
        '
        'Directory_Browse_Dialog
        '
        Me.Directory_Browse_Dialog.RootFolder = System.Environment.SpecialFolder.MyComputer
        Me.Directory_Browse_Dialog.SelectedPath = "C:\"
        '
        'SelectFolder_Button
        '
        Me.SelectFolder_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HelpProvider1.SetHelpString(Me.SelectFolder_Button, "Used to select a folder from a user specified directory. Use the check boxes abov" & _
        "e to control which individual file types will be selected. ")
        Me.SelectFolder_Button.Location = New System.Drawing.Point(607, 137)
        Me.SelectFolder_Button.Name = "SelectFolder_Button"
        Me.HelpProvider1.SetShowHelp(Me.SelectFolder_Button, True)
        Me.SelectFolder_Button.Size = New System.Drawing.Size(164, 25)
        Me.SelectFolder_Button.TabIndex = 5
        Me.SelectFolder_Button.Text = "Select Folder"
        Me.SelectFolder_Button.UseVisualStyleBackColor = True
        '
        'CheckIPT
        '
        Me.CheckIPT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckIPT.Checked = True
        Me.CheckIPT.CheckState = System.Windows.Forms.CheckState.Checked
        Me.HelpProvider1.SetHelpString(Me.CheckIPT, "By selecting this item before searching a folder / directory, all files with the " & _
        "extension '.ipt' will be added to the File Selection List.")
        Me.CheckIPT.Location = New System.Drawing.Point(713, 29)
        Me.CheckIPT.Name = "CheckIPT"
        Me.HelpProvider1.SetShowHelp(Me.CheckIPT, True)
        Me.CheckIPT.Size = New System.Drawing.Size(43, 17)
        Me.CheckIPT.TabIndex = 2
        Me.CheckIPT.Text = "IPT"
        Me.CheckIPT.UseVisualStyleBackColor = True
        '
        'CheckIAM
        '
        Me.CheckIAM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HelpProvider1.SetHelpString(Me.CheckIAM, "By selecting this item before searching a folder / directory, all files with the " & _
        "extension '.iam' will be added to the File Selection List.")
        Me.CheckIAM.Location = New System.Drawing.Point(713, 52)
        Me.CheckIAM.Name = "CheckIAM"
        Me.HelpProvider1.SetShowHelp(Me.CheckIAM, True)
        Me.CheckIAM.Size = New System.Drawing.Size(45, 17)
        Me.CheckIAM.TabIndex = 3
        Me.CheckIAM.Text = "IAM"
        Me.CheckIAM.UseVisualStyleBackColor = True
        '
        'CheckIDW
        '
        Me.CheckIDW.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HelpProvider1.SetHelpString(Me.CheckIDW, "By selecting this item before searching a folder / directory, all files with the " & _
        "extension '.idw' will be added to the File Selection List.")
        Me.CheckIDW.Location = New System.Drawing.Point(713, 75)
        Me.CheckIDW.Name = "CheckIDW"
        Me.HelpProvider1.SetShowHelp(Me.CheckIDW, True)
        Me.CheckIDW.Size = New System.Drawing.Size(48, 17)
        Me.CheckIDW.TabIndex = 4
        Me.CheckIDW.Text = "IDW"
        Me.CheckIDW.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListBox1.FormattingEnabled = True
        Me.HelpProvider1.SetHelpKeyword(Me.ListBox1, "File List Selection")
        Me.HelpProvider1.SetHelpString(Me.ListBox1, "Shows a list of all files that will be processed after the ""Add Rules"" button has" & _
        " been pressed.")
        Me.ListBox1.Location = New System.Drawing.Point(6, 42)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.HelpProvider1.SetShowHelp(Me.ListBox1, True)
        Me.ListBox1.Size = New System.Drawing.Size(574, 238)
        Me.ListBox1.TabIndex = 8
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.EventTriggers_CheckedListBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(795, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(238, 290)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Event Triggers"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(13, 264)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(182, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "(***) Indicates For Drawing File ONLY"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(13, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "(**) Indicates For Parts File ONLY"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(13, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "(*) Indicates For Assembly File ONLY"
        '
        'EventTriggers_CheckedListBox1
        '
        Me.EventTriggers_CheckedListBox1.CheckOnClick = True
        Me.EventTriggers_CheckedListBox1.FormattingEnabled = True
        Me.EventTriggers_CheckedListBox1.Items.AddRange(New Object() {"After Open Document", "Close Document", "Before Save Document", "After Save Document", "Any Model Parameter Change", "Part Geometry Change**", "Material Change**", "Drawing View Change***", "iProperty Change", "Feature Suppression Change**", "Component Suppression Change*", "iPart / iAssembly Change Component*", "New Document"})
        Me.EventTriggers_CheckedListBox1.Location = New System.Drawing.Point(6, 19)
        Me.EventTriggers_CheckedListBox1.Name = "EventTriggers_CheckedListBox1"
        Me.HelpProvider1.SetShowHelp(Me.EventTriggers_CheckedListBox1, True)
        Me.EventTriggers_CheckedListBox1.Size = New System.Drawing.Size(225, 199)
        Me.EventTriggers_CheckedListBox1.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox2.Controls.Add(Me.CheckDWG)
        Me.GroupBox2.Controls.Add(Me.ClearFolderList_Button)
        Me.GroupBox2.Controls.Add(Me.ClearSelectedFromList_Button)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.ListBox1)
        Me.GroupBox2.Controls.Add(Me.CheckIPT)
        Me.GroupBox2.Controls.Add(Me.CheckIDW)
        Me.GroupBox2.Controls.Add(Me.SelectFolder_Button)
        Me.GroupBox2.Controls.Add(Me.CheckIAM)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(777, 290)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Inventor File Selection"
        '
        'CheckDWG
        '
        Me.CheckDWG.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HelpProvider1.SetHelpString(Me.CheckDWG, "By selecting this item before searching a folder / directory, all files with the " & _
        "extension '.idw' will be added to the File Selection List.")
        Me.CheckDWG.Location = New System.Drawing.Point(713, 98)
        Me.CheckDWG.Name = "CheckDWG"
        Me.HelpProvider1.SetShowHelp(Me.CheckDWG, True)
        Me.CheckDWG.Size = New System.Drawing.Size(58, 17)
        Me.CheckDWG.TabIndex = 9
        Me.CheckDWG.Text = "DWG"
        Me.CheckDWG.UseVisualStyleBackColor = True
        '
        'ClearFolderList_Button
        '
        Me.ClearFolderList_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HelpProvider1.SetHelpString(Me.ClearFolderList_Button, "Will clear the entire file list of all content.")
        Me.ClearFolderList_Button.Location = New System.Drawing.Point(607, 255)
        Me.ClearFolderList_Button.Name = "ClearFolderList_Button"
        Me.HelpProvider1.SetShowHelp(Me.ClearFolderList_Button, True)
        Me.ClearFolderList_Button.Size = New System.Drawing.Size(164, 25)
        Me.ClearFolderList_Button.TabIndex = 7
        Me.ClearFolderList_Button.Text = "Clear Folder List"
        Me.ClearFolderList_Button.UseVisualStyleBackColor = True
        '
        'ClearSelectedFromList_Button
        '
        Me.ClearSelectedFromList_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HelpProvider1.SetHelpString(Me.ClearSelectedFromList_Button, "Clear any files out of the list that have been selected by the user.")
        Me.ClearSelectedFromList_Button.Location = New System.Drawing.Point(607, 224)
        Me.ClearSelectedFromList_Button.Name = "ClearSelectedFromList_Button"
        Me.HelpProvider1.SetShowHelp(Me.ClearSelectedFromList_Button, True)
        Me.ClearSelectedFromList_Button.Size = New System.Drawing.Size(164, 25)
        Me.ClearSelectedFromList_Button.TabIndex = 6
        Me.ClearSelectedFromList_Button.Text = "Clear Selected From List"
        Me.ClearSelectedFromList_Button.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(609, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Choose FileType(s) :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Current File Selection :"
        '
        'ExitProgram_Button
        '
        Me.ExitProgram_Button.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HelpProvider1.SetHelpString(Me.ExitProgram_Button, "Used to close down this program.")
        Me.ExitProgram_Button.Location = New System.Drawing.Point(823, 535)
        Me.ExitProgram_Button.Name = "ExitProgram_Button"
        Me.HelpProvider1.SetShowHelp(Me.ExitProgram_Button, True)
        Me.ExitProgram_Button.Size = New System.Drawing.Size(164, 25)
        Me.ExitProgram_Button.TabIndex = 15
        Me.ExitProgram_Button.Text = "Exit Program"
        Me.ExitProgram_Button.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox3.Controls.Add(Me.DeleteAfterRun_RadioButton)
        Me.GroupBox3.Controls.Add(Me.KeepAfterRun_RadioButton)
        Me.GroupBox3.Controls.Add(Me.RunRulesOnCreation_CheckBox)
        Me.GroupBox3.Controls.Add(Me.OverwriteDuplicateRules_CheckBox)
        Me.GroupBox3.Location = New System.Drawing.Point(795, 308)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(237, 151)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Advanced Options"
        '
        'DeleteAfterRun_RadioButton
        '
        Me.DeleteAfterRun_RadioButton.AutoSize = True
        Me.DeleteAfterRun_RadioButton.Enabled = False
        Me.DeleteAfterRun_RadioButton.Location = New System.Drawing.Point(28, 88)
        Me.DeleteAfterRun_RadioButton.Name = "DeleteAfterRun_RadioButton"
        Me.DeleteAfterRun_RadioButton.Size = New System.Drawing.Size(118, 17)
        Me.DeleteAfterRun_RadioButton.TabIndex = 16
        Me.DeleteAfterRun_RadioButton.TabStop = True
        Me.DeleteAfterRun_RadioButton.Text = "Delete rule after run"
        Me.DeleteAfterRun_RadioButton.UseVisualStyleBackColor = True
        '
        'KeepAfterRun_RadioButton
        '
        Me.KeepAfterRun_RadioButton.AutoSize = True
        Me.KeepAfterRun_RadioButton.Enabled = False
        Me.KeepAfterRun_RadioButton.Location = New System.Drawing.Point(28, 64)
        Me.KeepAfterRun_RadioButton.Name = "KeepAfterRun_RadioButton"
        Me.KeepAfterRun_RadioButton.Size = New System.Drawing.Size(112, 17)
        Me.KeepAfterRun_RadioButton.TabIndex = 15
        Me.KeepAfterRun_RadioButton.TabStop = True
        Me.KeepAfterRun_RadioButton.Text = "Keep rule after run"
        Me.KeepAfterRun_RadioButton.UseVisualStyleBackColor = True
        '
        'RunRulesOnCreation_CheckBox
        '
        Me.RunRulesOnCreation_CheckBox.AutoSize = True
        Me.RunRulesOnCreation_CheckBox.Location = New System.Drawing.Point(6, 41)
        Me.RunRulesOnCreation_CheckBox.Name = "RunRulesOnCreation_CheckBox"
        Me.HelpProvider1.SetShowHelp(Me.RunRulesOnCreation_CheckBox, True)
        Me.RunRulesOnCreation_CheckBox.Size = New System.Drawing.Size(71, 17)
        Me.RunRulesOnCreation_CheckBox.TabIndex = 13
        Me.RunRulesOnCreation_CheckBox.Text = "Run Rule"
        Me.RunRulesOnCreation_CheckBox.UseVisualStyleBackColor = True
        '
        'OverwriteDuplicateRules_CheckBox
        '
        Me.OverwriteDuplicateRules_CheckBox.AutoSize = True
        Me.OverwriteDuplicateRules_CheckBox.Location = New System.Drawing.Point(6, 18)
        Me.OverwriteDuplicateRules_CheckBox.Name = "OverwriteDuplicateRules_CheckBox"
        Me.HelpProvider1.SetShowHelp(Me.OverwriteDuplicateRules_CheckBox, True)
        Me.OverwriteDuplicateRules_CheckBox.Size = New System.Drawing.Size(149, 17)
        Me.OverwriteDuplicateRules_CheckBox.TabIndex = 12
        Me.OverwriteDuplicateRules_CheckBox.Text = "Overwrite Duplicate Rules"
        Me.OverwriteDuplicateRules_CheckBox.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1, Me.InventorLoadingText, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 575)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1045, 22)
        Me.StatusStrip1.TabIndex = 16
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        Me.ToolStripProgressBar1.Step = 1
        '
        'InventorLoadingText
        '
        Me.InventorLoadingText.BackColor = System.Drawing.SystemColors.Control
        Me.InventorLoadingText.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.InventorLoadingText.ForeColor = System.Drawing.SystemColors.Control
        Me.InventorLoadingText.Name = "InventorLoadingText"
        Me.InventorLoadingText.Size = New System.Drawing.Size(106, 17)
        Me.InventorLoadingText.Text = "Loading Inventor..."
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.AutoSize = False
        Me.ToolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripStatusLabel1.Margin = New System.Windows.Forms.Padding(600, 3, 0, 2)
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(155, 17)
        Me.ToolStripStatusLabel1.Text = "Current Version::"
        Me.ToolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DeleteRulesButton
        '
        Me.DeleteRulesButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeleteRulesButton.Location = New System.Drawing.Point(823, 477)
        Me.DeleteRulesButton.Name = "DeleteRulesButton"
        Me.DeleteRulesButton.Size = New System.Drawing.Size(164, 23)
        Me.DeleteRulesButton.TabIndex = 17
        Me.DeleteRulesButton.Text = "Delete all rules"
        Me.DeleteRulesButton.UseVisualStyleBackColor = True
        '
        'Code_Injector
        '
        Me.AcceptButton = Me.AddRules_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 597)
        Me.Controls.Add(Me.DeleteRulesButton)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.ExitProgram_Button)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.AddRules_Button)
        Me.Controls.Add(Me.Rule_Input_GroupBox1)
        Me.HelpButton = True
        Me.HelpProvider1.SetHelpKeyword(Me, "")
        Me.HelpProvider1.SetHelpString(Me, "")
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1061, 635)
        Me.Name = "Code_Injector"
        Me.HelpProvider1.SetShowHelp(Me, True)
        Me.Text = "Code Injector for 2011-2013"
        Me.Rule_Input_GroupBox1.ResumeLayout(False)
        Me.Rule_Input_GroupBox1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AddRules_Button As System.Windows.Forms.Button
    Friend WithEvents Rule_Contents_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Rule_Input_GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ImportRuleFromFile_Button As System.Windows.Forms.Button
    Friend WithEvents RuleFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ClearRuleText_Button As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RuleNameTextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Directory_Browse_Dialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents SelectFolder_Button As System.Windows.Forms.Button
    Friend WithEvents CheckIPT As System.Windows.Forms.CheckBox
    Friend WithEvents CheckIAM As System.Windows.Forms.CheckBox
    Friend WithEvents CheckIDW As System.Windows.Forms.CheckBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents EventTriggers_CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ClearFolderList_Button As System.Windows.Forms.Button
    Friend WithEvents ClearSelectedFromList_Button As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ExitProgram_Button As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents RunRulesOnCreation_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents OverwriteDuplicateRules_CheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents HelpProvider1 As System.Windows.Forms.HelpProvider
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents InventorLoadingText As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DeleteAfterRun_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents KeepAfterRun_RadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents CheckDWG As System.Windows.Forms.CheckBox
    Friend WithEvents SelectfromInventorFileButton As System.Windows.Forms.Button
    Friend WithEvents DeleteRulesButton As System.Windows.Forms.Button

End Class
