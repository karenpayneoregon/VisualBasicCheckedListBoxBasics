Imports System.Text
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

        MonthsListBox.DataSource = MonthsCheckedListBox.CheckedStringList()

    End Sub
    Private Sub GetCheckedProductsButton_Click(sender As Object, e As EventArgs) Handles GetCheckedProductsButton.Click
        If StandardMethodCheckBox.Checked Then
            FromMicrosoftDocRevised()
        Else
            ProductsListBox.DataSource = CheckedListBox1.CheckedProductList()
        End If
    End Sub

    Private Sub CheckedMonthsButton_Click(sender As Object, e As EventArgs) Handles CheckedMonthsButton.Click
        MonthsListBox.DataSource = MonthsCheckedListBox.CheckedStringList()
    End Sub
    ''' <summary>
    ''' Taken from https://docs.microsoft.com/en-us/dotnet/framework/winforms/controls/how-to-determine-checked-items-in-the-windows-forms-checkedlistbox-control
    ''' works yet does not promote decent naming conventions nor does it provide a practical
    ''' method to get at objects, only text and index of the checked item.
    ''' </summary>
    Private Sub FromMicrosoftDoc()
        Dim i As Integer
        Dim s As String
        s = "Checked Items:" & ControlChars.CrLf
        For i = 0 To (CheckedListBox1.Items.Count - 1)
            If CheckedListBox1.GetItemChecked(i) = True Then
                s = s & "Item " & (i + 1).ToString & " = " & CheckedListBox1.Items(i).ToString & ControlChars.CrLf
            End If
        Next
        MessageBox.Show(s)
    End Sub
    ''' <summary>
    ''' Modified from original above, more efficient code by first
    ''' determining if there are any checked items. Uses meaningful
    ''' variable names, no string concatenation, StringBuilder is
    ''' a better way to build a string.
    ''' </summary>
    ''' <remarks>
    ''' This works fine when there is no need to consider the item type e.g. product vs string.
    ''' </remarks>
    Private Sub FromMicrosoftDocRevised()

        If CheckedListBox1.CheckedIndices.Count <= 0 Then
            MessageBox.Show("Please check one or more items and try again")
        Else
            Dim sb As New StringBuilder

            sb.AppendLine("Checked Items:")

            For index = 0 To (CheckedListBox1.Items.Count - 1)
                If CheckedListBox1.GetItemChecked(index) = True Then
                    sb.AppendLine("Item " & (index + 1).ToString & " = " & CheckedListBox1.Items(index).ToString)
                End If
            Next
            MessageBox.Show(sb.ToString())
        End If
    End Sub
End Class
