Imports System.Data
Imports System.Data.SqlClient
Public Class D_Marca
    Dim cn As New SqlConnection("Data Source=191.1.70.92;Initial Catalog=BDMARKET;User ID=RetailUser;Password=retail")

    Public Function D_Registrar(ByVal objenti As E_Marca) As String

        Dim cmd As New SqlCommand
        cmd.CommandText = "Grabar_marca"
        cmd.Connection = CONECTA()
        'Dim cmd As New SqlCommand("Grabar_categoria", cn)

        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase Marca
        cmd.Parameters.Add("@c_nomb_marc", SqlDbType.VarChar).Value = objenti.desmarc
        cmd.Parameters.Add("@c_codi_marc", SqlDbType.Int, 9).Value = ""
        cmd.Parameters("@c_codi_marc").Direction = ParameterDirection.Output

        cmd.ExecuteNonQuery()

        Dim factura As String = cmd.Parameters("@c_codi_marc").Value.ToString()

        Return factura
    End Function

    Public Function D_listar_marc(ByVal objenti As E_Marca) As DataTable
        Dim cmd As New SqlCommand
        cmd.CommandText = "sp_listar_marca"
        cmd.Connection = CONECTA()

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@Criterio", SqlDbType.VarChar).Value = objenti.criterio

        Dim Tabar As New DataTable
        Dim Da As New SqlDataAdapter
        Da.SelectCommand = cmd
        Da.Fill(Tabar)
        Return Tabar
    End Function

    Public Function D_Actualizar(ByVal objenti As E_Marca) As String

        Dim cmd As New SqlCommand
        cmd.CommandText = "sp_actualizar_marc"
        cmd.Connection = CONECTA()

        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase Marca
        cmd.Parameters.Add("@c_codi_marc", SqlDbType.Char).Value = objenti.codmarc
        cmd.Parameters.Add("@c_nomb_marc", SqlDbType.VarChar).Value = objenti.desmarc

        cmd.ExecuteNonQuery()

        Dim factura As String = cmd.Parameters("@c_codi_marc").Value.ToString()

        Return factura
    End Function

    Public Function D_eliminar_marc(ByVal objenti As E_Marca) As String

        Dim cmd As New SqlCommand
        cmd.CommandText = "sp_eliminar_marc"
        cmd.Connection = CONECTA()

        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase Marca
        cmd.Parameters.Add("@c_codi_marc", SqlDbType.Char).Value = objenti.codmarc
        cmd.ExecuteNonQuery()
        Dim factura As String = cmd.Parameters("@c_codi_marc").Value.ToString()

        Return factura
    End Function

End Class
