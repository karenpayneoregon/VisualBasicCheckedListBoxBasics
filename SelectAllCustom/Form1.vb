Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MonthsCheckedListBox.Clear()
        MonthsCheckedListBox.Items.AddRange(
            (
                From month In Globalization.CultureInfo.CurrentCulture.DateTimeFormat.MonthNames
                Where Not String.IsNullOrEmpty(month)).ToArray
            )

        MonthsCheckedListBox.SelectedIndex = Now.Month

    End Sub

    Private Sub AllCheckedButton_Click(sender As Object, e As EventArgs) Handles AllCheckedButton.Click
        MessageBox.Show(MonthsCheckedListBox.AllChecked.ToString())
    End Sub
End Class