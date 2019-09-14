Imports DisabledCheckedListBox.DataClasses
''' <summary>
''' The custom CheckedListBox is a start to disable items on a condition yet with a regular
''' CheckedListBox items may be disabled without a lot of code.
''' </summary>
Public Class Form1

    Private operations As SqlServerOperations = New SqlServerOperations()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim products = operations.ProductsByCategoryIdentifier(6)

        For Each product As Product In products
            CheckedListBoxDisabledItems1.Items.Add(product)
        Next

        products.Where(Function(product) product.Discontinued = True).
            ToList().
            ForEach(
                Sub(product)
                    CheckedListBoxDisabledItems1.CheckAndDisable(product.ProductName)
                End Sub)

        '
        ' Set state to Indeterminate then enforce the state in ItemCheck event
        '
        For Each product As Product In products
            If product.Discontinued Then
                CheckedListBox1.Items.Add(product, CheckState.Indeterminate)
            Else
                CheckedListBox1.Items.Add(product)
            End If
        Next
    End Sub

    Private Sub CheckedListBox1_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles CheckedListBox1.ItemCheck
        If e.CurrentValue = CheckState.Indeterminate Then
            e.NewValue = CheckState.Indeterminate
        End If
    End Sub
End Class
