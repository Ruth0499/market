Imports System.Data
Imports System.Data.SqlClient
Public Class Frm_IngSalMercaderia

    Dim cn As New SqlConnection("Data Source=191.1.70.92;Initial Catalog=BDMARKET;User ID=RetailUser;Password=retail")

    Public Sub CargarProveedor()
        Dim tabla As New DataTable
        Dim sql As String = "SELECT c_codi_prov,c_nomb_prov FROM sco_proveedor"
        Dim da As New SqlDataAdapter(sql, cn)
        da.Fill(tabla)

        Cbo_Proveedor.DataSource = tabla
        Cbo_Proveedor.DisplayMember = "c_nomb_prov"
        Cbo_Proveedor.ValueMember = "c_codi_prov"

    End Sub

    Public Sub CargarUmedida()
        Dim tabla As New DataTable
        Dim sql As String = "SELECT c_codi_umed, c_nomb_umed FROM sco_unidadmedida"
        Dim da As New SqlDataAdapter(sql, cn)
        da.Fill(tabla)

        Cbo_unimed.DataSource = tabla
        Cbo_unimed.DisplayMember = "c_nomb_umed"
        Cbo_unimed.ValueMember = "c_codi_umed"

    End Sub

    Public Sub CargarCategoria()
        Cbo_categoria.Items.Add("SELECCIONE")
        Cbo_categoria.Items.Add("INGRESO")
        Cbo_categoria.Items.Add("SALIDA")
        Cbo_categoria.Text = Cbo_categoria.Items(0).ToString
    End Sub

    Public Sub CargarMotivo()
        Cbo_Motivo.Items.Add("SELECCIONE")
        Cbo_Motivo.Items.Add("COMPRAS")
        Cbo_Motivo.Items.Add("DEVOLUCION")
        Cbo_Motivo.Items.Add("REPOSICION")
        Cbo_Motivo.Items.Add("VENTAS")
        Cbo_Motivo.Text = Cbo_Motivo.Items(0).ToString
    End Sub

    Public Sub CargarDocumento()
        Cbo_Documento.Items.Add("SELECCIONE")
        Cbo_Documento.Items.Add("ORDEN DE COMPRA")
        Cbo_Documento.Items.Add("BOLETA")
        Cbo_Documento.Items.Add("FACTURA")
        Cbo_Documento.Items.Add("ORDEN DE PEDIDO")
        Cbo_Documento.Text = Cbo_Documento.Items(0).ToString
    End Sub

    Private Sub Frm_IngSalMercaderia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCategoria()
        CargarMotivo()
        CargarDocumento()
        CargarProveedor()
        CargarUmedida()
    End Sub

    Private Sub BTNNUEVO_Click(sender As Object, e As EventArgs) Handles BTNNUEVO.Click

    End Sub
End Class