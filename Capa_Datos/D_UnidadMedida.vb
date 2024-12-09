Imports System.Data
Imports System.Data.SqlClient
Public Class D_UnidadMedida

    Dim cn As New SqlConnection("Data Source=191.1.70.92;Initial Catalog=BDMARKET;User ID=RetailUser;Password=retail")

    Public Function D_Registrar(ByVal objenti As E_UnidadMedida) As String

        Dim cmd As New SqlCommand
        cmd.CommandText = "Grabar_unidadmedida"
        cmd.Connection = CONECTA()
        'Dim cmd As New SqlCommand("Grabar_unidadmedida", cn)

        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase UnidadMedida
        cmd.Parameters.Add("@c_nomb_umed", SqlDbType.VarChar).Value = objenti.desumed
        cmd.Parameters.Add("@c_codi_umed", SqlDbType.Int, 9).Value = ""
        cmd.Parameters("@c_codi_umed").Direction = ParameterDirection.Output

        cmd.ExecuteNonQuery()

        Dim factura As String = cmd.Parameters("@c_codi_umed").Value.ToString()

        Return factura
    End Function

    Public Function D_listar_umed(ByVal objenti As E_UnidadMedida) As DataTable
        Dim cmd As New SqlCommand
        cmd.CommandText = "sp_listar_unidadmedida"
        cmd.Connection = CONECTA()

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@Criterio", SqlDbType.VarChar).Value = objenti.criterio

        Dim Tabar As New DataTable
        Dim Da As New SqlDataAdapter
        Da.SelectCommand = cmd
        Da.Fill(Tabar)
        Return Tabar
    End Function

    Public Function D_Actualizar(ByVal objenti As E_UnidadMedida) As String

        Dim cmd As New SqlCommand
        cmd.CommandText = "sp_actualizar_umed"
        cmd.Connection = CONECTA()

        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase UnidadMedida
        cmd.Parameters.Add("@c_codi_umed", SqlDbType.Char).Value = objenti.codumed
        cmd.Parameters.Add("@c_nomb_umed", SqlDbType.VarChar).Value = objenti.desumed

        cmd.ExecuteNonQuery()

        Dim factura As String = cmd.Parameters("@c_codi_umed").Value.ToString()

        Return factura
    End Function

    Public Function D_eliminar_umed(ByVal objenti As E_UnidadMedida) As String

        Dim cmd As New SqlCommand
        cmd.CommandText = "sp_eliminar_umed"
        cmd.Connection = CONECTA()

        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase Unidad Medida
        cmd.Parameters.Add("@c_codi_umed", SqlDbType.Char).Value = objenti.codumed
        cmd.ExecuteNonQuery()
        Dim factura As String = cmd.Parameters("@c_codi_umed").Value.ToString()

        Return factura
    End Function

End Class
