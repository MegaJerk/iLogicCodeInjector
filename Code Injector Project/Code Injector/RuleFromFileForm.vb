
Imports Inventor
Imports Autodesk.iLogic.Automation
Imports Autodesk.iLogic.Interfaces
Public Class RuleSelectorForm
    Dim iLogicObject As Object
    Dim activedoc As Inventor.Document = Nothing

    Private Sub BrowseSingleFileButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseSingleFileButton.Click
        'Check to make sure that the iLogic addin for Inventor is currently running 
        iLogicObject = GetiLogicAddin(Code_Injector.openInventorApp)

        With (OpenRuleFromFileDialog)
            .Title = "Specify Inventor file containing a rule"
            .Filter = "Inventor Part files (*.ipt)|*.ipt|Inventor Assembly files (*.iam)|*.iam|Inventor Drawing files (*.idw)|*.idw|Other drawing files (*.dwg)|*.dwg|All files|*.*"
            .FilterIndex = 0
            .Multiselect = False
            .FileName = ""
        End With

        Try
            OpenRuleFromFileDialog.ShowDialog()
            SingleFileTextBox.Text = OpenRuleFromFileDialog.FileName
            SingleFileTextBox.Select(SingleFileTextBox.Text.Length, 0)

            activedoc = Code_Injector.openInventorApp.Documents.Open(SingleFileTextBox.Text)
            ListBox1.Items.Clear()

            Me.RulefromFileButton.Enabled = False
            DisplayExistingRules(activedoc, iLogicObject)

        Catch
        End Try
    End Sub

    Private Sub DisplayExistingRules(ByVal activeDoc As Inventor.Document, ByVal iLogicAuto As Object)
        Dim rules As IEnumerable
        Try
            Dim rule As Object
            rules = iLogicAuto.Rules(activeDoc)
            If (rules Is Nothing) Then Return
            For Each rule In rules
                ListBox1.Items.Add(rule.name)
            Next rule
        Catch
        End Try
    End Sub

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

    Private Sub RulefromFileButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RulefromFileButton.Click
        Dim rules As IEnumerable
        Dim rule As Object
        rules = iLogicObject.Rules(Code_Injector.openInventorApp.ActiveDocument)
        If (rules Is Nothing) Then Return
        For Each rule In rules
            If ListBox1.SelectedItem.ToString() = rule.name Then
                Code_Injector.Rule_Contents_TextBox.Text() = rule.Text
                Return
            End If
        Next rule
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.RulefromFileButton.Enabled = False
        Me.MaximumSize = Me.Size
        Me.MinimumSize = Me.Size
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Me.RulefromFileButton.Enabled = True
    End Sub

    Private Sub CancelRuleButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelRuleButton.Click
        Me.Hide()

    End Sub

    Private Sub RuleSelectorForm_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        If Not activedoc Is Nothing Then activedoc.Close()
    End Sub
End Class