Namespace Controls
    Public Class CheckedListBoxSelectAll
        Inherits CheckedListBox

        Public Sub New()
            Items.Add("Select")

            AddHandler ItemCheck, AddressOf CheckedListBoxSelectAll_ItemCheck

        End Sub
        Private Sub CheckedListBoxSelectAll_ItemCheck(sender As Object, e As ItemCheckEventArgs)

            If e.Index = 0 Then

                RemoveHandler ItemCheck, AddressOf CheckedListBoxSelectAll_ItemCheck
                Dim state = Convert.ToBoolean(e.NewValue)

                For index = 1 To Items.Count - 1
                    SetItemChecked(index, state)
                Next

                AddHandler ItemCheck, AddressOf CheckedListBoxSelectAll_ItemCheck

            End If

        End Sub
        Public ReadOnly Property AllChecked() As Boolean
            Get
                Dim counter As Integer = 0

                For index As Integer = 0 To (Items.Count - 1)
                    If GetItemChecked(index) Then
                        counter += 1
                    End If
                Next

                Return counter > 0

            End Get
        End Property
        Public Sub Clear()
            Items.Clear()
            Items.Add("Select")
        End Sub
    End Class
End Namespace