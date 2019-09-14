Imports GetCheckedItems.DataClasses
Imports GetCheckedItems.Extensions

Public Class Form1
    Private operations As SqlServerOperations = New SqlServerOperations()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim products = operations.ProductsByCategoryIdentifier(1)
        CheckedListBox1.DataSource = products
    End Sub

    Private Sub GetCheckedItemsButton_Click(sender As Object, e As EventArgs) Handles GetCheckedItemsButton.Click
        ListBox1.DataSource = CheckedListBox1.CheckedList()
    End Sub
End Class
