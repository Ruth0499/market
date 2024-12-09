Public Class Frm_MenuPrincipal
    Private Sub Frm_MenuPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        Usuario.Text = "Usuario:" & " " & Send.USUARIO
        Hora_de_Inicio.Text = "Hora de Inicio:" & " " & Date.Now
    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        Application.Exit()
    End Sub

    Private Sub ManProveedor_Click(sender As Object, e As EventArgs) Handles ManProveedor.Click
        Dim FRM As New Frm_Proveedores
        FRM.Show()
    End Sub

    Private Sub ManProductos_Click(sender As Object, e As EventArgs) Handles ManProductos.Click
        Dim FRM As New Frm_productos
        FRM.Show()
    End Sub

    Private Sub ManCategorias_Click(sender As Object, e As EventArgs) Handles ManCategorias.Click
        Dim FRM As New Frm_categorias
        FRM.Show()
    End Sub

    Private Sub ManMarcas_Click(sender As Object, e As EventArgs) Handles ManMarcas.Click
        Dim FRM As New Frm_Marcas
        FRM.Show()
    End Sub

    Private Sub ManUnidadDeMedida_Click(sender As Object, e As EventArgs) Handles ManUnidadDeMedida.Click
        Dim FRM As New Frm_UnidadMedida
        FRM.Show()
    End Sub

    Private Sub ManClientes_Click(sender As Object, e As EventArgs) Handles ManClientes.Click
        Dim FRM As New Frm_Clientes
        FRM.Show()
    End Sub

    Private Sub ManSucursales_Click(sender As Object, e As EventArgs) Handles ManSucursales.Click
        Dim FRM As New Frm_Sucursal
        FRM.Show()
    End Sub

    Private Sub ManEmpleados_Click(sender As Object, e As EventArgs) Handles ManEmpleados.Click
        Dim FRM As New Frm_Empleados
        FRM.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        Dim FRM As New Frm_Usuario
        FRM.Show()
    End Sub

    Private Sub ConProveedores_Click(sender As Object, e As EventArgs) Handles ConProveedores.Click
        Dim FRM As New Frm_ConsProveedor
        FRM.Show()
    End Sub

    Private Sub ConClientes_Click(sender As Object, e As EventArgs) Handles ConClientes.Click
        Dim FRM As New Frm_ConsCliente
        FRM.Show()
    End Sub

    Private Sub TipoDocumentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDocumentoToolStripMenuItem.Click
        Dim FRM As New Frm_TipoDocumento
        FRM.Show()
    End Sub

    Private Sub TranAlmacen_Click(sender As Object, e As EventArgs) Handles TranAlmacen.Click
        'Dim FRM As New Frm_Inventario
        Dim FRM As New Frm_IngSalMercaderia
        FRM.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Dim FRM As New Frm_ConsProducto
        FRM.Show()
    End Sub

    Private Sub AperturaDeCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AperturaDeCajaToolStripMenuItem.Click
        Dim FRM As New Frm_AperCaja
        FRM.Show()
    End Sub

    Private Sub RegistroDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeVentasToolStripMenuItem.Click
        'Dim FRM As New Frm_Ventas
        Dim FRM As New Frm_Inventario
        FRM.Show()
    End Sub

    Private Sub CuadreDeCajaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuadreDeCajaToolStripMenuItem.Click
        Dim FRM As New Frm_CuadreCaja
        FRM.Show()
    End Sub
End Class