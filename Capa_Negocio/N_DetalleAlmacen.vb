Imports System.Data
Imports System.Data.SqlClient
Public Class N_DetalleAlmacen

    Dim INS As New D_DetalleAlmacen
    Dim INS1 As New D_DetalleAlmacen

    Public Function GUARDAR_DETALLE_ALMACEN(ByVal cod As String, ByVal um As String, ByVal cant As Decimal, ByVal desc As String, ByVal preuni As Decimal, ByVal imp As Decimal) As String
        Return INS1.GUARDAR_ADETALLES(cod, um, cant, desc, preuni, imp)
    End Function

End Class
