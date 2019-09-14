Imports TrackingCheckedItems.Interfaces

Namespace DataClasses
    Public Class Product
        Implements IBaseItem
        Public Property ProductID As Integer
        Public Property ProductName As String
        Public Property Category As String
        Public Property SupplierID As Integer?
        Public Property CategoryID As Integer?
        Public Property QuantityPerUnit As String
        Public Property UnitPrice As Decimal?
        Public Property UnitsInStock As Short?
        Public Property UnitsOnOrder As Short?
        Public Property ReorderLevel As Short?
        Public Property Discontinued As Boolean
        Public Property DiscontinuedDate As DateTime?
        Public Property Selected As Boolean Implements IBaseItem.Selected
        ''' <summary>
        ''' For demo purposes only
        ''' </summary>
        ''' <returns></returns>
        Public ReadOnly Property DisplayData() As String
            Get
                Return $"Category: {Category} Id: {ProductID} Name: {ProductName} Price: {UnitPrice.Value.ToString("C2")}"
            End Get
        End Property
        Public Overrides Function ToString() As String
            Return ProductName
        End Function

    End Class
End Namespace