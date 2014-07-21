<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateForm
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
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.RemindAgainBox = New System.Windows.Forms.ComboBox()
        Me.RemindButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(424, 55)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(88, 23)
        Me.CloseButton.TabIndex = 1
        Me.CloseButton.Text = "Don't Update"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(55, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(440, 35)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = "There is a new version of LNP available!"
        '
        'RemindAgainBox
        '
        Me.RemindAgainBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RemindAgainBox.FormattingEnabled = True
        Me.RemindAgainBox.Items.AddRange(New Object() {"Next Run", "1 Day", "3 Days", "7 Days", "2 Weeks", "1 Month"})
        Me.RemindAgainBox.Location = New System.Drawing.Point(273, 55)
        Me.RemindAgainBox.Name = "RemindAgainBox"
        Me.RemindAgainBox.Size = New System.Drawing.Size(96, 21)
        Me.RemindAgainBox.TabIndex = 3
        '
        'RemindButton
        '
        Me.RemindButton.Location = New System.Drawing.Point(180, 53)
        Me.RemindButton.Name = "RemindButton"
        Me.RemindButton.Size = New System.Drawing.Size(87, 23)
        Me.RemindButton.TabIndex = 4
        Me.RemindButton.Text = "Remind Me:"
        Me.RemindButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(32, 53)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(97, 23)
        Me.UpdateButton.TabIndex = 5
        Me.UpdateButton.Text = "Update Now!"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'UpdateForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 89)
        Me.ControlBox = False
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.RemindButton)
        Me.Controls.Add(Me.RemindAgainBox)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.CloseButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "UpdateForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Update Now?"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CloseButton As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents RemindAgainBox As System.Windows.Forms.ComboBox
    Friend WithEvents RemindButton As System.Windows.Forms.Button
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
End Class
