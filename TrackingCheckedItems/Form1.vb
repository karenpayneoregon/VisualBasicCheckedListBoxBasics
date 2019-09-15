Imports TrackingCheckedItems.DataClasses
Imports TrackingCheckedItems.Extensions

Public Class Form1
    Private operations As SqlServerOperations = New SqlServerOperations()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim products = operations.ProductsByCategoryIdentifier()
        CheckedListBox1.DataSource = products
    End Sub
    ''' <summary>
    ''' Change Product.Selected dependent on the check state of the current item.
    ''' 
    ''' Show checked products in the TextBox, in a real application this might be
    ''' done in a button click for making a final selection for the current process.
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CheckedListBox1_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles CheckedListBox1.ItemCheck

        CType(CheckedListBox1.Items(e.Index), Product).Selected = Not CheckedListBox1.GetItemChecked(e.Index)

        TextBox1.Text = String.Join(Environment.NewLine, CType(CheckedListBox1.DataSource, List(Of Product)).
                                       Where(Function(product) product.Selected).
                                       Select(Function(product) product.DisplayData).ToArray())
    End Sub

    Private Sub GetCheckedProductsButton_Click(sender As Object, e As EventArgs) Handles GetCheckedProductsButton.Click
        Dim productItems = CheckedListBox1.CheckedIndices

        For index As Integer = 0 To productItems.Count - 1
            Dim product = CType(CheckedListBox1.Items(index), Product)
            Console.WriteLine(product)
        Next



    End Sub
End Class