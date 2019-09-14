
Imports GetCheckedItems.DataClasses

Namespace Extensions
    Public Module ExtensionMethods
        ''' <summary>
        ''' Get checked items by casting Items collection to the proper type, in this
        ''' case the DataSource was been set to a List of Product so the cast must be Product.
        ''' If the DataSource was a list of string the cast would be String rather than Product.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <returns></returns>
        <Runtime.CompilerServices.Extension()>
        Public Function CheckedProductList(sender As CheckedListBox) As List(Of Product)
            Return (
                From product In sender.Items.Cast(Of Product)().
                    Where(Function(prod, index) sender.GetItemChecked(index))
                Select item = product).ToList
        End Function
        <Runtime.CompilerServices.Extension()>
        Public Function CheckedList(sender As CheckedListBox) As List(Of String)

            Return (
                From item In sender.Items.Cast(Of String)().
                    Where(Function(item, index) sender.GetItemChecked(index))
                Select item = item).ToList

        End Function
    End Module
End Namespace