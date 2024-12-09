Imports System.Data
Imports System.Data.SqlClient
Public Class D_Producto

    Dim cn As New SqlConnection("Data Source=191.1.70.92;Initial Catalog=BDMARKET;User ID=RetailUser;Password=retail")

    Public Function D_Registrar(ByVal objenti As E_Producto) As String

        Dim cmd As New SqlCommand
        cmd.CommandText = "Grabar_producto"
        cmd.Connection = CONECTA()
        'Dim cmd As New SqlCommand("Grabar_producto", cn)

        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase Producto
        cmd.Parameters.Add("@c_nomb_prod", SqlDbType.VarChar).Value = objenti.desprod
        cmd.Parameters.Add("@c_barr_prod", SqlDbType.VarChar).Value = objenti.barprod
        cmd.Parameters.Add("@d_pcos_prod", SqlDbType.VarChar).Value = objenti.pcosprod
        cmd.Parameters.Add("@d_pven_prod", SqlDbType.VarChar).Value = objenti.pvenprod
        cmd.Parameters.Add("@c_codi_cate", SqlDbType.VarChar).Value = objenti.codcatprod
        cmd.Parameters.Add("@c_codi_marc", SqlDbType.VarChar).Value = objenti.codmarprod
        cmd.Parameters.Add("@c_codi_umed", SqlDbType.VarChar).Value = objenti.unimedprod
        'cmd.Parameters.Add("@c_stoc_prod", SqlDbType.VarChar).Value = objenti.stkprod
        cmd.Parameters.Add("@c_codi_prod", SqlDbType.Int, 9).Value = ""
        cmd.Parameters("@c_codi_prod").Direction = ParameterDirection.Output

        cmd.ExecuteNonQuery()

        Dim factura As String = cmd.Parameters("@c_codi_prod").Value.ToString()

        Return factura
    End Function

    Public Function D_listar_prod(ByVal objenti As E_Producto) As DataTable
        Dim cmd As New SqlCommand
        cmd.CommandText = "sp_listar_producto"
        cmd.Connection = CONECTA()

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@Criterio", SqlDbType.VarChar).Value = objenti.criterio

        Dim Tabar As New DataTable
        Dim Da As New SqlDataAdapter
        Da.SelectCommand = cmd
        Da.Fill(Tabar)
        Return Tabar
    End Function

    Public Function D_Actualizar(ByVal objenti As E_Producto) As String

        Dim cmd As New SqlCommand
        cmd.CommandText = "sp_actualizar_prod"
        cmd.Connection = CONECTA()

        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase producto
        cmd.Parameters.Add("@c_codi_prod", SqlDbType.Char).Value = objenti.codprod
        cmd.Parameters.Add("@c_nomb_prod", SqlDbType.VarChar).Value = objenti.desprod
        cmd.Parameters.Add("@c_barr_prod", SqlDbType.VarChar).Value = objenti.barprod
        cmd.Parameters.Add("@d_pcos_prod", SqlDbType.VarChar).Value = objenti.pcosprod
        cmd.Parameters.Add("@d_pven_prod", SqlDbType.VarChar).Value = objenti.pvenprod
        cmd.Parameters.Add("@c_codi_cate", SqlDbType.VarChar).Value = objenti.codcatprod
        cmd.Parameters.Add("@c_codi_marc", SqlDbType.VarChar).Value = objenti.codmarprod
        cmd.Parameters.Add("@c_codi_umed", SqlDbType.VarChar).Value = objenti.unimedprod
        'cmd.Parameters.Add("@c_stoc_prod", SqlDbType.VarChar).Value = objenti.stkprod

        cmd.ExecuteNonQuery()

        Dim factura As String = cmd.Parameters("@c_codi_prod").Value.ToString()

        Return factura
    End Function

    Public Function D_eliminar_prod(ByVal objenti As E_Producto) As String

        Dim cmd As New SqlCommand
        cmd.CommandText = "sp_eliminar_prod"
        cmd.Connection = CONECTA()

        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase producto
        cmd.Parameters.Add("@c_codi_prod", SqlDbType.Char).Value = objenti.codprod
        cmd.ExecuteNonQuery()
        Dim factura As String = cmd.Parameters("@c_codi_prod").Value.ToString()

        Return factura
    End Function

End Class
