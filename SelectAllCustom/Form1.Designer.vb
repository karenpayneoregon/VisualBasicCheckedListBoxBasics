Imports SelectAllCustom.Controls

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.AllCheckedButton = New System.Windows.Forms.Button()
        Me.MonthsCheckedListBox = New SelectAllCustom.Controls.CheckedListBoxSelectAll()
        Me.SuspendLayout()
        '
        'AllCheckedButton
        '
        Me.AllCheckedButton.Location = New System.Drawing.Point(12, 244)
        Me.AllCheckedButton.Name = "AllCheckedButton"
        Me.AllCheckedButton.Size = New System.Drawing.Size(196, 23)
        Me.AllCheckedButton.TabIndex = 1
        Me.AllCheckedButton.Text = "All checked"
        Me.AllCheckedButton.UseVisualStyleBackColor = True
        '
        'MonthsCheckedListBox
        '
        Me.MonthsCheckedListBox.FormattingEnabled = True
        Me.MonthsCheckedListBox.Items.AddRange(New Object() {"Select"})
        Me.MonthsCheckedListBox.Location = New System.Drawing.Point(12, 24)
        Me.MonthsCheckedListBox.Name = "MonthsCheckedListBox"
        Me.MonthsCheckedListBox.Size = New System.Drawing.Size(196, 214)
        Me.MonthsCheckedListBox.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 306)
        Me.Controls.Add(Me.AllCheckedButton)
        Me.Controls.Add(Me.MonthsCheckedListBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select/Unselect all"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MonthsCheckedListBox As CheckedListBoxSelectAll
    Friend WithEvents AllCheckedButton As Button
End Class
