Namespace DataClasses
    Public Class Product
        Public Property ProductID As Integer
        Public Property ProductName As String
        Public Property SupplierID As Integer?
        Public Property CategoryID As Integer?
        Public Property QuantityPerUnit As String
        Public Property UnitPrice As Decimal?
        Public Property UnitsInStock As Short?
        Public Property UnitsOnOrder As Short?
        Public Property ReorderLevel As Short?
        Public Property Discontinued As Boolean
        Public Property DiscontinuedDate As DateTime?

        Public Overrides Function ToString() As String
            Return ProductName
        End Function
    End Class
End Namespace