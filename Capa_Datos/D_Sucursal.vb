Imports System.Data
Imports System.Data.SqlClient
Public Class D_Sucursal

    Dim cn As New SqlConnection("Data Source=191.1.70.92;Initial Catalog=BDMARKET;User ID=RetailUser;Password=retail")

    Public Function D_Registrar(ByVal objenti As E_Sucursal) As String

        Dim cmd As New SqlCommand
        cmd.CommandText = "Grabar_sucursal"
        cmd.Connection = CONECTA()
        'Dim cmd As New SqlCommand("Grabar_sucursal", cn)

        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase Sucursal
        cmd.Parameters.Add("@c_nomb_sucu", SqlDbType.VarChar).Value = objenti.dessucu
        cmd.Parameters.Add("@c_dire_sucu", SqlDbType.VarChar).Value = objenti.dirsucu
        cmd.Parameters.Add("@c_tel1_sucu", SqlDbType.VarChar).Value = objenti.telsucu
        cmd.Parameters.Add("@c_mail_sucu", SqlDbType.VarChar).Value = objenti.mailsucu
        cmd.Parameters.Add("@c_codi_sucu", SqlDbType.Int, 9).Value = ""
        cmd.Parameters("@c_codi_sucu").Direction = ParameterDirection.Output

        cmd.ExecuteNonQuery()

        Dim factura As String = cmd.Parameters("@c_codi_sucu").Value.ToString()

        Return factura
    End Function

    Public Function D_listar_sucu(ByVal objenti As E_Sucursal) As DataTable
        Dim cmd As New SqlCommand
        cmd.CommandText = "sp_listar_sucursal"
        cmd.Connection = CONECTA()

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@Criterio", SqlDbType.VarChar).Value = objenti.criterio

        Dim Tabar As New DataTable
        Dim Da As New SqlDataAdapter
        Da.SelectCommand = cmd
        Da.Fill(Tabar)
        Return Tabar
    End Function

    Public Function D_Actualizar(ByVal objenti As E_Sucursal) As String

        Dim cmd As New SqlCommand
        cmd.CommandText = "sp_actualizar_sucu"
        cmd.Connection = CONECTA()

        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase Sucursal
        cmd.Parameters.Add("@c_codi_sucu", SqlDbType.Char).Value = objenti.codsucu
        cmd.Parameters.Add("@c_nomb_sucu", SqlDbType.VarChar).Value = objenti.dessucu
        cmd.Parameters.Add("@c_dire_sucu", SqlDbType.VarChar).Value = objenti.dirsucu
        cmd.Parameters.Add("@c_tel1_sucu", SqlDbType.VarChar).Value = objenti.telsucu
        cmd.Parameters.Add("@c_mail_sucu", SqlDbType.VarChar).Value = objenti.mailsucu

        cmd.ExecuteNonQuery()

        Dim factura As String = cmd.Parameters("@c_codi_sucu").Value.ToString()

        Return factura
    End Function

    Public Function D_eliminar_sucu(ByVal objenti As E_Sucursal) As String

        Dim cmd As New SqlCommand
        cmd.CommandText = "sp_eliminar_sucu"
        cmd.Connection = CONECTA()

        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase Sucursal
        cmd.Parameters.Add("@c_codi_sucu", SqlDbType.Char).Value = objenti.codsucu
        cmd.ExecuteNonQuery()
        Dim factura As String = cmd.Parameters("@c_codi_sucu").Value.ToString()

        Return factura
    End Function

End Class
