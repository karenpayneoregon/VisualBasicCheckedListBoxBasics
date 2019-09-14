Imports FindAndCheckItem.DataClasses
Imports FindAndCheckItem.Extensions

Public Class Form1
    Private operations As SqlServerOperations = New SqlServerOperations()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim products = operations.ProductsByCategoryIdentifier(1)
        CheckedListBox1.DataSource = products

        CheckedListBox1.FindItemAndSetChecked("Steeleye Stout")
        CheckedListBox1.FindItemAndSetChecked("Outback Lager")

    End Sub
End Class
