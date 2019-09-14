Imports FindAndCheckItem.DataClasses

Namespace Extensions
    Module ExtensionMethods
        ''' <summary>
        ''' Find a specific product by name and check or uncheck the item if found
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="pValueToLocate">Product name</param>
        ''' <param name="pChecked">True to check, False to uncheck</param>
        <Runtime.CompilerServices.Extension()>
        Public Sub FindItemAndSetChecked(sender As CheckedListBox, pValueToLocate As String, Optional pChecked As Boolean = True)

            Dim result =
                    (
                        From this In sender.Items.Cast(Of Product)().Select(Function(item, index) New With {.Item = item, .Index = index})
                        Where this.Item.ProductName = pValueToLocate
                    ).FirstOrDefault

            If result IsNot Nothing Then
                sender.SetItemChecked(result.Index, pChecked)
            End If

        End Sub
        ''' <summary>
        ''' Find a specific value by field name and value in a DataTable
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="pValueToLocate">Value to find</param>
        ''' <param name="pFieldName">Field to locate in</param>
        ''' <param name="pChecked">True to check, False to uncheck</param>
        <Runtime.CompilerServices.Extension()>
        Public Sub FindItemAndSetChecked(sender As CheckedListBox, pValueToLocate As String, pFieldName As String, Optional pChecked As Boolean = True)

            Dim result =
                    (
                        From this In sender.Items.Cast(Of DataRowView)().Select(Function(item, index) New With {.Item = item, .Index = index})
                        Where this.Item.Row.Field(Of String)(pFieldName).ToLower = pValueToLocate.ToLower
                    ).FirstOrDefault

            If result IsNot Nothing Then
                sender.SetItemChecked(result.Index, pChecked)
            End If

        End Sub
    End Module
End Namespace