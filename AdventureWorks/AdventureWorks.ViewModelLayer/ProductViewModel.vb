Imports AdventureWorks.EntityLayer
Imports Common.Library

Public Class ProductViewModel
    Inherits ViewModelBase

    Sub New()
        LoadProduct(680)
    End Sub

    Public Property Entity As Product

    Function LoadProduct(ByVal productId As Integer) As Product
        Return LoadProduct(productId, Nothing)
    End Function

    Function LoadProduct(ByVal productId As Integer,
                         ByVal startingFilePath As String) As Product
        Entity = New Product() With {.ProductID = 680, .Name = "HL Road Frame, 58", .ProductNumber = "FR-R92B-58", .Color = "Black", .Size = "58", .Weight = 1016.04D, .StandardCost = 1059.31D}

        Return Entity
    End Function
End Class
