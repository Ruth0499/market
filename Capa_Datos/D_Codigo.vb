Imports System.Data
Imports System.Data.SqlClient
'Imports Capa_Entidad

Public Class D_Codigo

    Public Function AutoCodigoAlmacen() As String
        Dim DT As New DataTable
        Dim cmd As New SqlDataAdapter("GeneraCodigoAlmacen", CONECTA)
        cmd.SelectCommand.CommandType = CommandType.StoredProcedure
        cmd.Fill(DT)
        Dim a As String = DT.Rows(0)(0).ToString
        Return a
    End Function
    'Public Function AutoFactura() As String
    '    Dim DT As New DataTable
    '    Dim cmd As New SqlDataAdapter("GenerCodigoFactura", CONECTA)
    '    cmd.SelectCommand.CommandType = CommandType.StoredProcedure
    '    cmd.Fill(DT)
    '    Dim a As String = DT.Rows(0)(0).ToString
    '    Return a
    'End Function

    Public Function Graba_Almacen(ByVal objen As E_Almacen) As String
        Dim cmd As New SqlCommand("grabar_almacen", CONECTA)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@nro_cod", SqlDbType.VarChar).Value = objen.nro_cod
        cmd.Parameters.Add("@serie", SqlDbType.VarChar).Value = objen.serie
        cmd.Parameters.Add("@ruc", SqlDbType.VarChar).Value = objen.ruc
        cmd.Parameters.Add("@razon", SqlDbType.VarChar).Value = objen.cliente
        cmd.Parameters.Add("@dir", SqlDbType.VarChar).Value = objen.dir
        ' cmd.Parameters.Add("@imp", SqlDbType.Decimal).Value = objen.imp
        cmd.Parameters.Add("@subtot", SqlDbType.Decimal).Value = objen.subtot
        cmd.Parameters.Add("@tot", SqlDbType.Decimal).Value = objen.tot
        cmd.Parameters.Add("@estado", SqlDbType.VarChar, 40).Value = objen.est
        cmd.Parameters.Add("@codfacgen", SqlDbType.VarChar, 9).Value = "" 'Valor x defecto 
        cmd.Parameters("@codfacgen").Direction = ParameterDirection.Output
        cmd.Parameters.Add("@tabla_detalle", SqlDbType.Structured).Value = objen.tabladetalle
        'CONECTA.Open()
        Dim p As Integer = 0
        p = cmd.ExecuteNonQuery

        Return cmd.Parameters("@codfacgen").Value.ToString
    End Function

    Public Function Elimina_Almacen(ByVal cod As String) As Integer
        Dim cmd As New SqlCommand("eliminar_almacen", CONECTA)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@cod", SqlDbType.Char).Value = cod
        'conecta.Open()
        Dim p As Integer = 0
        p = cmd.ExecuteNonQuery
        Return p
    End Function

    Public Function Modifica_Almacen(ByVal cod As String, ByVal um As String, ByVal nrofac As String, ByVal ruc As Integer, ByVal razsoc As String, ByVal dir As String, ByVal cant As Integer, ByVal desc As String, ByVal preuni As Decimal, ByVal imp As Decimal, ByVal subtot As Decimal, ByVal tot As Decimal, ByVal fechemi As DateTime) As String
        Dim cmd As New SqlCommand("actualizar_almacen", CONECTA)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@cod", SqlDbType.Char).Value = cod
        cmd.Parameters.Add("@um", SqlDbType.NVarChar).Value = um
        cmd.Parameters.Add("@nrofac", SqlDbType.Int).Value = nrofac
        cmd.Parameters.Add("@ruc", SqlDbType.Int).Value = ruc
        cmd.Parameters.Add("@razsoc", SqlDbType.Char).Value = razsoc
        cmd.Parameters.Add("@dir", SqlDbType.NVarChar).Value = dir
        cmd.Parameters.Add("@cant", SqlDbType.Int).Value = cant
        cmd.Parameters.Add("@desc", SqlDbType.Int).Value = desc
        cmd.Parameters.Add("@preuni", SqlDbType.Char).Value = preuni
        cmd.Parameters.Add("@imp", SqlDbType.NVarChar).Value = imp
        cmd.Parameters.Add("@subtot", SqlDbType.Int).Value = subtot
        cmd.Parameters.Add("@tot", SqlDbType.Int).Value = tot
        cmd.Parameters.Add("@fechemi", SqlDbType.Int).Value = fechemi
        'conecta.Open()
        Dim p As Integer = 0
        p = cmd.ExecuteNonQuery
        Return p
    End Function

    'Public Function Impresion(ByVal cod As String) As DataSet
    '    Dim cmd As New SqlCommand("sp_reporte", CONECTA)
    '    cmd.CommandType = CommandType.StoredProcedure
    '    cmd.Parameters.Add("@cod", SqlDbType.Char).Value = cod
    '    Dim da As New SqlDataAdapter(cmd)
    '    Dim dt As New DataSet
    '    da.Fill(dt)
    '    Return dt
    'End Function

    Public Function Impresion(ByVal cod As String) As DataTable
        Dim cmd As New SqlCommand("sp_reporte", CONECTA)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@cod", SqlDbType.Char).Value = cod
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function

    Public Function Impresion2(ByVal cod As String) As DataTable
        Dim cmd As New SqlCommand("sp_reporte2", CONECTA)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@cod", SqlDbType.Char).Value = cod
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function

    Public Function Impresion3(ByVal cod As String) As DataTable
        Dim cmd As New SqlCommand("sp_reporte3", CONECTA)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@cod", SqlDbType.Char).Value = cod
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        Return dt
    End Function

End Class
