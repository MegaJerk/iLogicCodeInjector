<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RuleSelectorForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RulefromFileButton = New System.Windows.Forms.Button()
        Me.CancelRuleButton = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.OpenRuleFromFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.BrowseSingleFileButton = New System.Windows.Forms.Button()
        Me.SingleFileTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select a rule"
        '
        'RulefromFileButton
        '
        Me.RulefromFileButton.Location = New System.Drawing.Point(32, 284)
        Me.RulefromFileButton.Name = "RulefromFileButton"
        Me.RulefromFileButton.Size = New System.Drawing.Size(75, 23)
        Me.RulefromFileButton.TabIndex = 1
        Me.RulefromFileButton.Text = "Apply"
        Me.RulefromFileButton.UseVisualStyleBackColor = True
        '
        'CancelRuleButton
        '
        Me.CancelRuleButton.Location = New System.Drawing.Point(170, 284)
        Me.CancelRuleButton.Name = "CancelRuleButton"
        Me.CancelRuleButton.Size = New System.Drawing.Size(75, 23)
        Me.CancelRuleButton.TabIndex = 2
        Me.CancelRuleButton.Text = "Continue"
        Me.CancelRuleButton.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(32, 107)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(213, 160)
        Me.ListBox1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Select a single Inventor file"
        '
        'OpenRuleFromFileDialog
        '
        Me.OpenRuleFromFileDialog.FileName = "OpenFileDialog"
        '
        'BrowseSingleFileButton
        '
        Me.BrowseSingleFileButton.Location = New System.Drawing.Point(212, 40)
        Me.BrowseSingleFileButton.Name = "BrowseSingleFileButton"
        Me.BrowseSingleFileButton.Size = New System.Drawing.Size(60, 20)
        Me.BrowseSingleFileButton.TabIndex = 5
        Me.BrowseSingleFileButton.Text = "Browse..."
        Me.BrowseSingleFileButton.UseVisualStyleBackColor = True
        '
        'SingleFileTextBox
        '
        Me.SingleFileTextBox.Location = New System.Drawing.Point(35, 40)
        Me.SingleFileTextBox.Name = "SingleFileTextBox"
        Me.SingleFileTextBox.Size = New System.Drawing.Size(171, 20)
        Me.SingleFileTextBox.TabIndex = 6
        '
        'RuleSelectorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 333)
        Me.Controls.Add(Me.SingleFileTextBox)
        Me.Controls.Add(Me.BrowseSingleFileButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.CancelRuleButton)
        Me.Controls.Add(Me.RulefromFileButton)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RuleSelectorForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Use existing rule from file"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RulefromFileButton As System.Windows.Forms.Button
    Friend WithEvents CancelRuleButton As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OpenRuleFromFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BrowseSingleFileButton As System.Windows.Forms.Button
    Friend WithEvents SingleFileTextBox As System.Windows.Forms.TextBox
End Class
