<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.GetCheckedProductsButton = New System.Windows.Forms.Button()
        Me.ProductsListBox = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MonthsCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.MonthsListBox = New System.Windows.Forms.ListBox()
        Me.CheckedMonthsButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.StandardMethodCheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(10, 20)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(223, 259)
        Me.CheckedListBox1.TabIndex = 0
        '
        'GetCheckedProductsButton
        '
        Me.GetCheckedProductsButton.Location = New System.Drawing.Point(14, 291)
        Me.GetCheckedProductsButton.Name = "GetCheckedProductsButton"
        Me.GetCheckedProductsButton.Size = New System.Drawing.Size(219, 23)
        Me.GetCheckedProductsButton.TabIndex = 1
        Me.GetCheckedProductsButton.Text = "Get Checked products"
        Me.GetCheckedProductsButton.UseVisualStyleBackColor = True
        '
        'ProductsListBox
        '
        Me.ProductsListBox.FormattingEnabled = True
        Me.ProductsListBox.Location = New System.Drawing.Point(242, 20)
        Me.ProductsListBox.Name = "ProductsListBox"
        Me.ProductsListBox.Size = New System.Drawing.Size(200, 251)
        Me.ProductsListBox.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.StandardMethodCheckBox)
        Me.GroupBox1.Controls.Add(Me.ProductsListBox)
        Me.GroupBox1.Controls.Add(Me.GetCheckedProductsButton)
        Me.GroupBox1.Controls.Add(Me.CheckedListBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(473, 330)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Using List(Of Product)"
        '
        'MonthsCheckedListBox
        '
        Me.MonthsCheckedListBox.FormattingEnabled = True
        Me.MonthsCheckedListBox.Location = New System.Drawing.Point(6, 13)
        Me.MonthsCheckedListBox.Name = "MonthsCheckedListBox"
        Me.MonthsCheckedListBox.Size = New System.Drawing.Size(155, 259)
        Me.MonthsCheckedListBox.TabIndex = 4
        '
        'MonthsListBox
        '
        Me.MonthsListBox.FormattingEnabled = True
        Me.MonthsListBox.Location = New System.Drawing.Point(167, 12)
        Me.MonthsListBox.Name = "MonthsListBox"
        Me.MonthsListBox.Size = New System.Drawing.Size(200, 251)
        Me.MonthsListBox.TabIndex = 3
        '
        'CheckedMonthsButton
        '
        Me.CheckedMonthsButton.Location = New System.Drawing.Point(17, 291)
        Me.CheckedMonthsButton.Name = "CheckedMonthsButton"
        Me.CheckedMonthsButton.Size = New System.Drawing.Size(219, 23)
        Me.CheckedMonthsButton.TabIndex = 3
        Me.CheckedMonthsButton.Text = "Get Checked months"
        Me.CheckedMonthsButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckedMonthsButton)
        Me.GroupBox2.Controls.Add(Me.MonthsListBox)
        Me.GroupBox2.Controls.Add(Me.MonthsCheckedListBox)
        Me.GroupBox2.Location = New System.Drawing.Point(504, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(391, 330)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List(Of String)"
        '
        'StandardMethodCheckBox
        '
        Me.StandardMethodCheckBox.AutoSize = True
        Me.StandardMethodCheckBox.Location = New System.Drawing.Point(242, 295)
        Me.StandardMethodCheckBox.Name = "StandardMethodCheckBox"
        Me.StandardMethodCheckBox.Size = New System.Drawing.Size(127, 17)
        Me.StandardMethodCheckBox.TabIndex = 5
        Me.StandardMethodCheckBox.Text = "Use standard method"
        Me.StandardMethodCheckBox.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 362)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Get Checked Items"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents GetCheckedProductsButton As Button
    Friend WithEvents ProductsListBox As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MonthsCheckedListBox As CheckedListBox
    Friend WithEvents MonthsListBox As ListBox
    Friend WithEvents CheckedMonthsButton As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents StandardMethodCheckBox As CheckBox
End Class
