Imports System.Data
Imports System.Data.SqlClient
Public Class Usuario
    Dim cn As New SqlConnection("Data Source=191.1.70.92;Initial Catalog=BDMARKET;User ID=RetailUser;Password=retail")

    Public Function Grabar_Usuario(ByVal cod As String, ByVal usu As String, ByVal pass As String, ByVal cargo As String, ByVal estado As String) As String
        Dim cmd As New SqlCommand("Grabar_Usuario", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@cod ", SqlDbType.Char).Value = cod
        cmd.Parameters.Add("@usu", SqlDbType.VarChar).Value = usu
        cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass
        cmd.Parameters.Add("@cargo", SqlDbType.VarChar).Value = cargo
        cmd.Parameters.Add("@estado", SqlDbType.Char).Value = estado
        'conecta.Open()
        Dim p As Integer = 0
        p = cmd.ExecuteNonQuery
        Return p
    End Function

    Public Function AutogeneracodUsuario() As String
        Dim tb As New DataTable
        Dim cmd As New SqlDataAdapter("GenerarCodigoUsuario", cn)
        cmd.SelectCommand.CommandType = CommandType.StoredProcedure
        'Dim paramresultado As SqlParameter = New SqlParameter("@codigo", SqlDbType.Char, 5)
        'paramresultado.Direction = ParameterDirection.Output
        'cmd.Parameters.Add(paramresultado)
        'conecta.Open()
        cmd.Fill(tb)
        cn.Close()
        Dim a As String = tb.Rows(0)(0).ToString
        Return a
    End Function

    Public Function lista_usuario() As DataTable
        Dim da As New SqlDataAdapter("ListaUsuario", cn)
        Dim dt As New DataTable()
        da.Fill(dt)
        Return dt
    End Function

    Public Function elim_usuario(ByVal codusu As String) As Integer
        Dim cmd As New SqlCommand("Eliminar_Usuario", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@codusu", SqlDbType.Char).Value = codusu
        'conecta.Open()
        Dim p As Integer = 0
        p = cmd.ExecuteNonQuery
        Return p
    End Function

    Public Function Modificar_usuario(ByVal cod As String, ByVal usu As String, ByVal pass As String, ByVal cargo As String, ByVal estado As String) As String
        Dim cmd As New SqlCommand("Actualizar_Usuario", cn)
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@cod ", SqlDbType.Char).Value = cod
        cmd.Parameters.Add("@usu", SqlDbType.VarChar).Value = usu
        cmd.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass
        cmd.Parameters.Add("@cargo", SqlDbType.VarChar).Value = cargo
        cmd.Parameters.Add("@estado", SqlDbType.Char).Value = estado
        'conecta.Open()
        Dim p As Integer = 0
        p = cmd.ExecuteNonQuery
        Return p
    End Function
End Class
