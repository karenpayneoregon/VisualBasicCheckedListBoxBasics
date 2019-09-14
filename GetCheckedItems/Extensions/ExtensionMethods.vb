
Imports GetCheckedItems.DataClasses

Namespace Extensions
    ''' <summary>
    ''' Make note use of meaningful variable names
    ''' </summary>
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
        ''' <summary>
        ''' Get checked items as string
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <returns></returns>
        <Runtime.CompilerServices.Extension()>
        Public Function CheckedStringList(sender As CheckedListBox) As List(Of String)

            Return (
                From item In sender.Items.Cast(Of String)().
                    Where(Function(item, index) sender.GetItemChecked(index))
                Select item = item).ToList

        End Function
        ''' <summary>
        ''' For checked items of type string return the text and index
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <returns></returns>
        ''' <remarks>
        ''' Note use of meaningful variable names
        ''' </remarks>
        <Runtime.CompilerServices.Extension()>
        Public Function IndexList(sender As CheckedListBox) As List(Of CheckedItemList)

            Return (From itemList In sender.Items.OfType(Of String) _
                .Select(Function(item, index) New CheckedItemList With {.Text = item, .Index = index}) _
                .Where(Function(itemList) sender.GetItemChecked(itemList.Index))).ToList

        End Function
        ''' <summary>
        ''' Indicates if there are any checked items
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <returns></returns>
        <Runtime.CompilerServices.Extension()>
        Public Function HasChecked(sender As CheckedListBox) As Boolean
            Return sender.CheckedIndices.Count > 0
        End Function

    End Module
End Namespace