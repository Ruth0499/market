Imports System.Data
Imports System.Data.SqlClient
Public Class D_Cliente

    Dim cn As New SqlConnection("Data Source=191.1.70.92;Initial Catalog=BDMARKET;User ID=RetailUser;Password=retail")

    Public Function D_Registrar(ByVal objenti As E_Cliente) As String

        Dim cmd As New SqlCommand
        cmd.CommandText = "Grabar_cliente"
        cmd.Connection = CONECTA()
        'Dim cmd As New SqlCommand("Grabar_cliente", cn)

        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase Cliente
        cmd.Parameters.Add("@c_nomb_clie", SqlDbType.VarChar).Value = objenti.desclie
        cmd.Parameters.Add("@c_dire_clie", SqlDbType.VarChar).Value = objenti.dirclie
        cmd.Parameters.Add("@c_codi_tdoc", SqlDbType.VarChar).Value = objenti.tipdocclie
        cmd.Parameters.Add("@c_ndoc_clie", SqlDbType.VarChar).Value = objenti.docuclie
        cmd.Parameters.Add("@c_tel1_clie", SqlDbType.VarChar).Value = objenti.telclie
        cmd.Parameters.Add("@c_mail_clie", SqlDbType.VarChar).Value = objenti.mailclie
        cmd.Parameters.Add("@c_codi_clie", SqlDbType.Int, 9).Value = ""
        cmd.Parameters("@c_codi_clie").Direction = ParameterDirection.Output

        cmd.ExecuteNonQuery()

        Dim factura As String = cmd.Parameters("@c_codi_clie").Value.ToString()

        Return factura
    End Function

    Public Function D_listar_clie(ByVal objenti As E_Cliente) As DataTable
        Dim cmd As New SqlCommand
        cmd.CommandText = "sp_listar_cliente"
        cmd.Connection = CONECTA()

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@Criterio", SqlDbType.VarChar).Value = objenti.criterio

        Dim Tabar As New DataTable
        Dim Da As New SqlDataAdapter
        Da.SelectCommand = cmd
        Da.Fill(Tabar)
        Return Tabar
    End Function

    Public Function D_Actualizar(ByVal objenti As E_Cliente) As String

        Dim cmd As New SqlCommand
        cmd.CommandText = "sp_actualizar_clie"
        cmd.Connection = CONECTA()

        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase Cliente
        cmd.Parameters.Add("@c_codi_clie", SqlDbType.Char).Value = objenti.codclie
        cmd.Parameters.Add("@c_nomb_clie", SqlDbType.VarChar).Value = objenti.desclie
        cmd.Parameters.Add("@c_dire_clie", SqlDbType.VarChar).Value = objenti.dirclie
        cmd.Parameters.Add("@c_codi_tdoc", SqlDbType.VarChar).Value = objenti.tipdocclie
        cmd.Parameters.Add("@c_ndoc_clie", SqlDbType.VarChar).Value = objenti.docuclie
        cmd.Parameters.Add("@c_tel1_clie", SqlDbType.VarChar).Value = objenti.telclie
        cmd.Parameters.Add("@c_mail_clie", SqlDbType.VarChar).Value = objenti.mailclie

        cmd.ExecuteNonQuery()

        Dim factura As String = cmd.Parameters("@c_codi_clie").Value.ToString()

        Return factura
    End Function

    Public Function D_eliminar_clie(ByVal objenti As E_Cliente) As String

        Dim cmd As New SqlCommand
        cmd.CommandText = "sp_eliminar_clie"
        cmd.Connection = CONECTA()

        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase Cliente
        cmd.Parameters.Add("@c_codi_clie", SqlDbType.Char).Value = objenti.codclie
        cmd.ExecuteNonQuery()
        Dim factura As String = cmd.Parameters("@c_codi_clie").Value.ToString()

        Return factura
    End Function

End Class
