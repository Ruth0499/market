Imports System.Data
Imports System.Data.SqlClient
Public Class D_DetalleAlmacen

    Public Function GUARDAR_ADETALLES(ByVal cod As String, ByVal um As String, ByVal cant As Decimal, ByVal desc As String, ByVal preuni As Decimal, ByVal imp As Decimal) As String
        Dim cmd As New SqlCommand("Detalles_Almacen", CONECTA)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@cod", SqlDbType.Char).Value = cod
        cmd.Parameters.Add("@um", SqlDbType.Char).Value = um
        cmd.Parameters.Add("@cant", SqlDbType.Decimal).Value = cant
        cmd.Parameters.Add("@desc", SqlDbType.VarChar).Value = desc
        cmd.Parameters.Add("@preuni", SqlDbType.Decimal).Value = preuni
        cmd.Parameters.Add("@imp", SqlDbType.Decimal).Value = imp
        Dim p As Integer = 0
        p = cmd.ExecuteNonQuery
        Return p
    End Function

End Class
