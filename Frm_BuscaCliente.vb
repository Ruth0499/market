Imports System.Data
Imports System.Data.SqlClient
Public Class Frm_BuscaCliente
    Dim cn As New SqlConnection("Data Source=191.1.70.92;Initial Catalog=BDMARKET;User ID=RetailUser;Password=retail")

    Private Sub Frm_BuscaCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter("select c_codi_clie,c_nomb_clie,c_ndoc_clie,c_dire_clie from sco_clientes", cn)
        DA.Fill(DT)
        DataGridView1.DataSource = DT
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Send.s_razon = DataGridView1.CurrentRow.Cells(1).Value.ToString
        Send.s_ruc = DataGridView1.CurrentRow.Cells(2).Value.ToString
        Send.s_dir = DataGridView1.CurrentRow.Cells(3).Value.ToString
        Hide()
    End Sub
End Class