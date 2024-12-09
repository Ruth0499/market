Imports System.Data
Imports System.Data.SqlClient
Public Class D_Empleado

    Public Function D_Registrar(ByVal objenti As E_Empleado) As String

        Dim cmd As New SqlCommand
        cmd.CommandText = "grabar_Empleado"
        cmd.Connection = CONECTA()

        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase Empleado
        cmd.Parameters.Add("@ape", SqlDbType.VarChar).Value = objenti.apeemp
        cmd.Parameters.Add("@nom", SqlDbType.VarChar).Value = objenti.nomemp
        cmd.Parameters.Add("@fec", SqlDbType.Date).Value = objenti.fecnac
        cmd.Parameters.Add("@sex", SqlDbType.Char).Value = objenti.sexo
        cmd.Parameters.Add("@dir", SqlDbType.VarChar).Value = objenti.diremp
        cmd.Parameters.Add("@tel", SqlDbType.Char).Value = objenti.telemp
        cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = objenti.email
        cmd.Parameters.Add("@cargo", SqlDbType.VarChar).Value = objenti.cargo
        cmd.Parameters.Add("@cod", SqlDbType.VarChar, 9).Value = ""
        cmd.Parameters("@cod").Direction = ParameterDirection.Output



        cmd.ExecuteNonQuery()

        Dim factura As String = cmd.Parameters("@cod").Value.ToString()

        Return factura
    End Function

    Public Function D_listar_emp(ByVal objenti As E_Empleado) As DataTable
        Dim cmd As New SqlCommand
        cmd.CommandText = "sp_listar_empleados"
        cmd.Connection = CONECTA()

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@Criterio", SqlDbType.VarChar).Value = objenti.criterio

        Dim Tabar As New DataTable
        Dim Da As New SqlDataAdapter
        Da.SelectCommand = cmd
        Da.Fill(Tabar)
        Return Tabar
    End Function

    Public Function D_Actualizar(ByVal objenti As E_Empleado) As String

        Dim cmd As New SqlCommand
        cmd.CommandText = "sp_actualizar_emp"
        cmd.Connection = CONECTA()

        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase Empleado
        cmd.Parameters.Add("@cod", SqlDbType.Char).Value = objenti.codemp
        cmd.Parameters.Add("@ape", SqlDbType.VarChar).Value = objenti.apeemp
        cmd.Parameters.Add("@nom", SqlDbType.VarChar).Value = objenti.nomemp
        cmd.Parameters.Add("@fec", SqlDbType.Date).Value = objenti.fecnac
        cmd.Parameters.Add("@sex", SqlDbType.Char).Value = objenti.sexo
        cmd.Parameters.Add("@dir", SqlDbType.VarChar).Value = objenti.diremp
        cmd.Parameters.Add("@tel", SqlDbType.Char).Value = objenti.telemp
        cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = objenti.email
        cmd.Parameters.Add("@cargo", SqlDbType.VarChar).Value = objenti.cargo

        cmd.ExecuteNonQuery()

        Dim factura As String = cmd.Parameters("@cod").Value.ToString()

        Return factura
    End Function
    Public Function D_eliminar_emp(ByVal objenti As E_Empleado) As String

        Dim cmd As New SqlCommand
        cmd.CommandText = "sp_eliminar_emp"
        cmd.Connection = CONECTA()

        cmd.CommandType = CommandType.StoredProcedure

        'Los parametros que va recibir son las propiedades de la clase Empleado
        cmd.Parameters.Add("@cod", SqlDbType.Char).Value = objenti.codemp
        cmd.ExecuteNonQuery()
        Dim factura As String = cmd.Parameters("@cod").Value.ToString()

        Return factura
    End Function

End Class
