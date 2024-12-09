﻿Imports System.Data
Imports System.Data.SqlClient
Public Class D_Categoria
    Dim cn As New SqlConnection("Data Source=191.1.70.92;Initial Catalog=BDMARKET;User ID=RetailUser;Password=retail")

    Public Function D_Registrar(ByVal objenti As E_Categoria) As String

        Dim cmd As New SqlCommand
        cmd.CommandText = "Grabar_categoria"
        cmd.Connection = CONECTA()
        'Dim cmd As New SqlCommand("Grabar_categoria", cn)

        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase Categoria
        cmd.Parameters.Add("@c_nomb_cate", SqlDbType.VarChar).Value = objenti.descat
        cmd.Parameters.Add("@c_codi_cate", SqlDbType.Int, 9).Value = ""
        cmd.Parameters("@c_codi_cate").Direction = ParameterDirection.Output

        cmd.ExecuteNonQuery()

        Dim factura As String = cmd.Parameters("@c_codi_cate").Value.ToString()

        Return factura
    End Function

    Public Function D_listar_cat(ByVal objenti As E_Categoria) As DataTable
        Dim cmd As New SqlCommand
        cmd.CommandText = "sp_listar_categoria"
        cmd.Connection = CONECTA()

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@Criterio", SqlDbType.VarChar).Value = objenti.criterio

        Dim Tabar As New DataTable
        Dim Da As New SqlDataAdapter
        Da.SelectCommand = cmd
        Da.Fill(Tabar)
        Return Tabar
    End Function

    Public Function D_Actualizar(ByVal objenti As E_Categoria) As String

        Dim cmd As New SqlCommand
        cmd.CommandText = "sp_actualizar_cat"
        cmd.Connection = CONECTA()

        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase Categoria
        cmd.Parameters.Add("@c_codi_cate", SqlDbType.Char).Value = objenti.codcat
        cmd.Parameters.Add("@c_nomb_cate", SqlDbType.VarChar).Value = objenti.descat

        cmd.ExecuteNonQuery()

        Dim factura As String = cmd.Parameters("@c_codi_cate").Value.ToString()

        Return factura
    End Function

    Public Function D_eliminar_cat(ByVal objenti As E_Categoria) As String

        Dim cmd As New SqlCommand
        cmd.CommandText = "sp_eliminar_cat"
        cmd.Connection = CONECTA()

        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase Categoria
        cmd.Parameters.Add("@c_codi_cate", SqlDbType.Char).Value = objenti.codcat
        cmd.ExecuteNonQuery()
        Dim factura As String = cmd.Parameters("@c_codi_cate").Value.ToString()

        Return factura
    End Function

End Class