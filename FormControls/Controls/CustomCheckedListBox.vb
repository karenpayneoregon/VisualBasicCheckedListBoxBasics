Imports System.Drawing
Imports System.Windows.Forms

Namespace Controls

    Public Class CustomCheckedListBox
        Inherits CheckedListBox

        Public Sub New()
            DoubleBuffered = True
        End Sub
        Public Completionlist As New List(Of Integer)()
        Protected Overrides Sub OnDrawItem(ByVal e As DrawItemEventArgs)
            Dim checkSize As Size = CheckBoxRenderer.GetGlyphSize(e.Graphics, System.Windows.Forms.VisualStyles.CheckBoxState.MixedNormal)
            Dim dx As Integer = (e.Bounds.Height - checkSize.Width) \ 2
            e.DrawBackground()
            Dim isChecked As Boolean = GetItemChecked(e.Index)
            CheckBoxRenderer.DrawCheckBox(e.Graphics, New Point(dx, e.Bounds.Top + dx), If(isChecked, System.Windows.Forms.VisualStyles.CheckBoxState.CheckedNormal, System.Windows.Forms.VisualStyles.CheckBoxState.UncheckedNormal))
            Dim myFont As Font = e.Font
            Dim myBrush As Brush
            Dim i As Integer = e.Index
            If Completionlist.Contains(i) Then
                myBrush = Brushes.Green
            Else
                myBrush = Brushes.Black
            End If
            e.Graphics.DrawString(Me.Items(i).ToString(), myFont, myBrush, New Rectangle(e.Bounds.Height, e.Bounds.Top, e.Bounds.Width - e.Bounds.Height, e.Bounds.Height), StringFormat.GenericDefault)
        End Sub
    End Class
End Namespace