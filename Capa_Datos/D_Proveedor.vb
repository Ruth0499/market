﻿Imports System.Data
Imports System.Data.SqlClient
Public Class D_Proveedor

    Dim cn As New SqlConnection("Data Source=191.1.70.92;Initial Catalog=BDMARKET;User ID=RetailUser;Password=retail")

    Public Function D_Registrar(ByVal objenti As E_Proveedor) As String

        Dim cmd As New SqlCommand
        cmd.CommandText = "Grabar_proveedor"
        cmd.Connection = CONECTA()
        'Dim cmd As New SqlCommand("Grabar_proveedor", cn)

        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase Proveedor
        cmd.Parameters.Add("@c_nomb_prov", SqlDbType.VarChar).Value = objenti.desprov
        cmd.Parameters.Add("@c_dire_prov", SqlDbType.VarChar).Value = objenti.dirprov
        cmd.Parameters.Add("@c_codi_tdoc", SqlDbType.VarChar).Value = objenti.tipdocprov
        cmd.Parameters.Add("@c_ndoc_prov", SqlDbType.VarChar).Value = objenti.docuprov
        cmd.Parameters.Add("@c_tel1_prov", SqlDbType.VarChar).Value = objenti.telprov
        cmd.Parameters.Add("@c_mail_prov", SqlDbType.VarChar).Value = objenti.mailprov
        cmd.Parameters.Add("@c_codi_prov", SqlDbType.Int, 9).Value = ""
        cmd.Parameters("@c_codi_prov").Direction = ParameterDirection.Output

        cmd.ExecuteNonQuery()

        Dim factura As String = cmd.Parameters("@c_codi_prov").Value.ToString()

        Return factura
    End Function

    Public Function D_listar_prov(ByVal objenti As E_Proveedor) As DataTable
        Dim cmd As New SqlCommand
        cmd.CommandText = "sp_listar_proveedor"
        cmd.Connection = CONECTA()

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@Criterio", SqlDbType.VarChar).Value = objenti.criterio

        Dim Tabar As New DataTable
        Dim Da As New SqlDataAdapter
        Da.SelectCommand = cmd
        Da.Fill(Tabar)
        Return Tabar
    End Function

    Public Function D_Actualizar(ByVal objenti As E_Proveedor) As String

        Dim cmd As New SqlCommand
        cmd.CommandText = "sp_actualizar_prov"
        cmd.Connection = CONECTA()

        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase Proveedor
        cmd.Parameters.Add("@c_codi_prov", SqlDbType.Char).Value = objenti.codprov
        cmd.Parameters.Add("@c_nomb_prov", SqlDbType.VarChar).Value = objenti.desprov
        cmd.Parameters.Add("@c_dire_prov", SqlDbType.VarChar).Value = objenti.dirprov
        cmd.Parameters.Add("@c_codi_tdoc", SqlDbType.VarChar).Value = objenti.tipdocprov
        cmd.Parameters.Add("@c_ndoc_prov", SqlDbType.VarChar).Value = objenti.docuprov
        cmd.Parameters.Add("@c_tel1_prov", SqlDbType.VarChar).Value = objenti.telprov
        cmd.Parameters.Add("@c_mail_prov", SqlDbType.VarChar).Value = objenti.mailprov

        cmd.ExecuteNonQuery()

        Dim factura As String = cmd.Parameters("@c_codi_prov").Value.ToString()

        Return factura
    End Function

    Public Function D_eliminar_prov(ByVal objenti As E_Proveedor) As String

        Dim cmd As New SqlCommand
        cmd.CommandText = "sp_eliminar_prov"
        cmd.Connection = CONECTA()

        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase Proveedor
        cmd.Parameters.Add("@c_codi_prov", SqlDbType.Char).Value = objenti.codprov
        cmd.ExecuteNonQuery()
        Dim factura As String = cmd.Parameters("@c_codi_prov").Value.ToString()

        Return factura
    End Function


End Class
