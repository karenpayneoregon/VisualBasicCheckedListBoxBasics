Imports System.Drawing
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles

Namespace Controls
    ''' <summary>
    ''' Originally in C# from https://stackoverflow.com/questions/4368618/how-to-disable-a-checkbox-in-a-checkedlistbox
    ''' </summary>
    Public Class CheckedListBoxDisabledItems
        Inherits CheckedListBox

        Private _checkedAndDisabledItems As New List(Of String)()
        Private _checkedAndDisabledIndexes As New List(Of Integer)()

        Public Sub CheckAndDisable(item As String)
            _checkedAndDisabledItems.Add(item)
            Refresh()
        End Sub

        Public Sub CheckAndDisable(index As Integer)
            _checkedAndDisabledIndexes.Add(index)
            Refresh()
        End Sub
        ''' <summary>
        ''' Never called, no matter way too much code for disabling items
        ''' </summary>
        ''' <param name="e"></param>
        Protected Overrides Sub OnDrawItem(e As DrawItemEventArgs)

            If Items.Count = 0 Then
                Return
            End If

            Dim itemValue As String = Items(e.Index).ToString()

            If _checkedAndDisabledItems.Contains(itemValue) OrElse _checkedAndDisabledIndexes.Contains(e.Index) Then
                Const state = CheckBoxState.UncheckedDisabled
                Dim glyphSize As Size = CheckBoxRenderer.GetGlyphSize(e.Graphics, state)
                CheckBoxRenderer.DrawCheckBox(e.Graphics, New Point(e.Bounds.X + 1, e.Bounds.Y + 1), New Rectangle(New Point(e.Bounds.X + glyphSize.Width + 3, e.Bounds.Y), New Size(e.Bounds.Width - glyphSize.Width, e.Bounds.Height)), itemValue, Me.Font, TextFormatFlags.Left, False, state)
            Else
                MyBase.OnDrawItem(e)
            End If
        End Sub

        Public Sub ClearDisabledItems()
            _checkedAndDisabledIndexes.Clear()
            _checkedAndDisabledItems.Clear()
            Refresh()
        End Sub
    End Class
End Namespace
