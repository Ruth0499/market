Imports System.Data.SqlClient
Public Class Frm_ConsProveedor
    Dim cn As New SqlConnection("Data Source=191.1.70.92;Initial Catalog=BDMARKET;User ID=RetailUser;Password=retail")

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click

        If txtdato.Text = "" Then
            MsgBox("Ingrese un Dato a Buscar", MsgBoxStyle.Information)
            txtdato.Focus()
            Exit Sub
        End If

        Dim cmd As New SqlCommand("sp_listar_proveedor", cn)

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@Criterio", SqlDbType.Char).Value = RTrim(txtdato.Text)
        Dim da As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable
        da.Fill(tbl)

        grd_listar.DataSource = tbl
        grd_listar.AutoResizeColumns()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub
End Class