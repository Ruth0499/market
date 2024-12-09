Imports System.Data.SqlClient
Public Class Frm_ConsProducto
    Dim cn As New SqlConnection("Data Source=191.1.70.92;Initial Catalog=BDMARKET;User ID=RetailUser;Password=retail")

    Public Sub CargarTipoStk()
        Cbo_TipoStk.Items.Add("TODOS")
        Cbo_TipoStk.Items.Add("MINIMO")
        Cbo_TipoStk.Items.Add("MAXIMO")
        Cbo_TipoStk.Text = Cbo_TipoStk.Items(0).ToString
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click

        If txtdato.Text = "" Then
            MsgBox("Ingrese un Dato a Buscar", MsgBoxStyle.Information)
            txtdato.Focus()
            Exit Sub
        End If

        Dim cmd As New SqlCommand("sp_consultar_producto", cn)

        cmd.CommandType = CommandType.StoredProcedure
        cmd.Parameters.Add("@Criterio", SqlDbType.Char).Value = RTrim(txtdato.Text)
        cmd.Parameters.Add("@tipo", SqlDbType.Char).Value = RTrim(Cbo_TipoStk.Text)
        Dim da As New SqlDataAdapter(cmd)
        Dim tbl As New DataTable
        da.Fill(tbl)

        grd_listar.DataSource = tbl
        grd_listar.AutoResizeColumns()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Close()
    End Sub

    Private Sub Frm_ConsProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarTipoStk()
    End Sub
End Class