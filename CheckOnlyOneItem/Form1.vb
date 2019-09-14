Imports CheckOnlyOneItem.DataClasses
Public Class Form1
    Private operations As SqlServerOperations = New SqlServerOperations()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim products = operations.ProductsByCategoryIdentifier(1)
        CheckedListBox1.DataSource = products
    End Sub

    Private Sub CheckedListBox1_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles CheckedListBox1.ItemCheck
        If e.NewValue = CheckState.Checked Then
            For index As Integer = 0 To CheckedListBox1.Items.Count - 1
                If index <> e.Index Then
                    CheckedListBox1.SetItemChecked(index, False)
                End If
            Next
        End If
    End Sub
End Class
