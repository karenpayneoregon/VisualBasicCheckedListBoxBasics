Imports GetCheckedItems.DataClasses
Imports GetCheckedItems.Extensions

Public Class Form1
    Private operations As SqlServerOperations = New SqlServerOperations()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim products = operations.ProductsByCategoryIdentifier(1)
        CheckedListBox1.DataSource = products


        MonthsCheckedListBox.Items.AddRange(
            (
               From month In Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames
               Where Not String.IsNullOrEmpty(month)).ToArray
            )

        ' check current month
        MonthsCheckedListBox.SelectedIndex = Now.Month - 1
        MonthsCheckedListBox.SetItemCheckState(MonthsCheckedListBox.SelectedIndex, CheckState.Checked)

        MonthsListBox.DataSource = MonthsCheckedListBox.CheckedList()

    End Sub
    Private Sub GetCheckedProductsButton_Click(sender As Object, e As EventArgs) Handles GetCheckedProductsButton.Click
        ProductsListBox.DataSource = CheckedListBox1.CheckedProductList()
    End Sub

    Private Sub CheckedMonthsButton_Click(sender As Object, e As EventArgs) Handles CheckedMonthsButton.Click
        MonthsListBox.DataSource = MonthsCheckedListBox.CheckedList()
    End Sub
End Class
