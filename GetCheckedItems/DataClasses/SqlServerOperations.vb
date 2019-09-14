Imports System.Data.SqlClient
Imports BaseConnectionLibrary
Namespace DataClasses
    Public Class SqlServerOperations
        Inherits ConnectionClasses.SqlServerConnection

        Public Sub New()
            DefaultCatalog = "NorthWindAzure1"
            DatabaseServer = "KARENS-PC"
        End Sub
        Public Function ProductsByCategoryIdentifier(pCategoryIdentifier As Integer) As List(Of Product)
            Dim productList As New List(Of Product)

            Dim selectStatement =
                    <SQL>
                    SELECT ProductID
                          ,ProductName
                          ,SupplierID
                          ,QuantityPerUnit
                          ,UnitPrice
                          ,UnitsInStock
                          ,UnitsOnOrder
                          ,ReorderLevel
                          ,Discontinued
                          ,DiscontinuedDate
                      FROM NorthWindAzure1.dbo.Products
                      WHERE CategoryID = <%= pCategoryIdentifier %>
                    </SQL>.Value


            Using cn As New SqlConnection With {.ConnectionString = ConnectionString}
                Using cmd As New SqlCommand With {.Connection = cn, .CommandText = selectStatement}

                    Try
                        cn.Open()

                        Dim reader = cmd.ExecuteReader()

                        While reader.Read()
                            productList.Add(New Product() With {.ProductID = reader.GetInt32(0), .ProductName = reader.GetString(1), .Discontinued = reader.GetBoolean(8)})
                        End While

                    Catch ex As Exception
                        mHasException = True
                        mLastException = ex
                    End Try
                End Using

            End Using

            Return productList

        End Function
    End Class
End Namespace