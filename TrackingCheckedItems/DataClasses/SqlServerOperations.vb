Imports System.Data.SqlClient
Imports BaseConnectionLibrary
Namespace DataClasses
    Public Class SqlServerOperations
        Inherits ConnectionClasses.SqlServerConnection

        Public Sub New()
            DefaultCatalog = "NorthWindAzure1"
            DatabaseServer = "KARENS-PC"
        End Sub
        Public Function ProductsByCategoryIdentifier() As List(Of Product)

            Dim productList As New List(Of Product)

            Dim selectStatement =
                    <SQL>
                        SELECT   P.ProductID ,
                                 P.ProductName ,
                                 P.SupplierID ,
                                 P.QuantityPerUnit ,
                                 P.UnitPrice ,
                                 P.UnitsInStock ,
                                 P.UnitsOnOrder ,
                                 P.ReorderLevel ,
                                 P.Discontinued ,
                                 P.DiscontinuedDate ,
                                 P.CategoryID ,
                                 C.CategoryName
                        FROM     dbo.Products AS P
                                 INNER JOIN dbo.Categories AS C ON P.CategoryID = C.CategoryID
                        WHERE    ( P.CategoryID IN ( 4, 7 ))
                        ORDER BY P.ProductName;

                    </SQL>.Value


            Using cn As New SqlConnection With {.ConnectionString = ConnectionString}
                Using cmd As New SqlCommand With {.Connection = cn, .CommandText = selectStatement}

                    Try
                        cn.Open()

                        Dim reader = cmd.ExecuteReader()

                        While reader.Read()

                            productList.Add(New Product() With
                                               {
                                                   .ProductID = reader.GetInt32(0),
                                                   .ProductName = reader.GetString(1),
                                                   .Discontinued = reader.GetBoolean(8),
                                                   .UnitPrice = reader.GetDecimal(4),
                                                   .Category = reader.GetString(11),
                                                   .CategoryID = reader.GetInt32(10)
                                               })

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