Namespace Extensions
    Public Module Extensions
        <Runtime.CompilerServices.Extension()>
        Public Function CheckedItemsNamesList(sender As CheckedListBox) As List(Of String)

            Dim results As New List(Of String)

            For index As Integer = 0 To (sender.Items.Count - 1)
                If sender.GetItemChecked(index) Then
                    results.Add(sender.Items(index).ToString)
                End If
            Next

            Return results
        End Function
        <Runtime.CompilerServices.Extension()>
        Public Function CheckedItemsIndexesList(sender As CheckedListBox) As List(Of Integer)

            Dim results As New List(Of Integer)

            For index As Integer = 0 To (sender.Items.Count - 1)
                If sender.GetItemChecked(index) Then
                    results.Add(index)
                End If
            Next

            Return results

        End Function
    End Module
End Namespace