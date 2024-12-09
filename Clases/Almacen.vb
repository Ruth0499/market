Imports System.Collections.Generic
Public Class Almacen
    Public Property Codigo() As String
    Public Property Nombre() As String
    Public Property Ruc() As String
    Public Property Direccion() As String
    Public Property Subtotal() As Decimal
    Public Property Total() As Decimal
    Public Property FechaFacturacion() As DateTime
    Public Property igv() As Decimal

    'Creamos una lista con una nueva Instancia de la clase Articulo
    'esta lista contendra el detalle de la factura
    Public Detail As New List(Of Articulo)()
End Class
