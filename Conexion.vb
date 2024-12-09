Imports System.Windows.Forms
Imports System.Data
Imports System.Data.SqlClient
'Public Class Conexion

'    Public cn As SqlConnection = New SqlConnection("Data Source=191.1.70.92;Initial Catalog=BDMARKET;User ID=retailUser;Password=retail")

'    Public Sub conectar()
'        Try
'            cn.Open()
'            MessageBox.Show("Conectado")
'        Catch ex As Exception
'            MessageBox.Show("Error al Conectar")
'        Finally
'            cn.Close()
'        End Try
'    End Sub
'End Class


Public Module Conexion
    Public Function CONECTA() As SqlConnection
        Dim cn As New SqlConnection("Data Source=191.1.70.92;Initial Catalog=BDMARKET;User ID=retailUser;Password=retail")
        If cn.State Then
            cn.Close()
        End If
        cn.Open()
        Return cn
    End Function
End Module

'Imports System.Data
'Imports System.Data.SqlClient
'Public Module Conexión
'    Public Function conectados() As SqlConnection
'        Dim cn As New SqlConnection("server=.;database=ECOHUALLPA;integrated security=true;")
'        If cn.State = ConnectionState.Open Then
'            cn.Close()
'        End If
'        cn.Open()
'        Return cn
'    End Function
'End Module