<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_MenuPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Salir = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlmacenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManProveedor = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManProductos = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManCategorias = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManMarcas = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManUnidadDeMedida = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.SistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManSucursales = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManEmpleados = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDocumentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransaccionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TranAlmacen = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConProveedores = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepProveedores = New System.Windows.Forms.ToolStripMenuItem()
        Me.RepClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Usuario = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Hora_de_Inicio = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Tiempo_Transcurrido = New System.Windows.Forms.ToolStripStatusLabel()
        Me.VentasToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AperturaDeCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuadreDeCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.MantenimientosToolStripMenuItem, Me.TransaccionesToolStripMenuItem, Me.VentasToolStripMenuItem1, Me.ConsultasToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1364, 33)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Salir})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(84, 29)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'Salir
        '
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(129, 30)
        Me.Salir.Text = "Salir"
        '
        'MantenimientosToolStripMenuItem
        '
        Me.MantenimientosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AlmacenToolStripMenuItem, Me.VentasToolStripMenuItem, Me.SistemaToolStripMenuItem})
        Me.MantenimientosToolStripMenuItem.Name = "MantenimientosToolStripMenuItem"
        Me.MantenimientosToolStripMenuItem.Size = New System.Drawing.Size(152, 29)
        Me.MantenimientosToolStripMenuItem.Text = "Mantenimientos"
        '
        'AlmacenToolStripMenuItem
        '
        Me.AlmacenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManProveedor, Me.ManProductos, Me.ManCategorias, Me.ManMarcas, Me.ManUnidadDeMedida})
        Me.AlmacenToolStripMenuItem.Name = "AlmacenToolStripMenuItem"
        Me.AlmacenToolStripMenuItem.Size = New System.Drawing.Size(164, 30)
        Me.AlmacenToolStripMenuItem.Text = "Almacen"
        '
        'ManProveedor
        '
        Me.ManProveedor.Name = "ManProveedor"
        Me.ManProveedor.Size = New System.Drawing.Size(243, 30)
        Me.ManProveedor.Text = "Proveedor"
        '
        'ManProductos
        '
        Me.ManProductos.Name = "ManProductos"
        Me.ManProductos.Size = New System.Drawing.Size(243, 30)
        Me.ManProductos.Text = "Productos"
        '
        'ManCategorias
        '
        Me.ManCategorias.Name = "ManCategorias"
        Me.ManCategorias.Size = New System.Drawing.Size(243, 30)
        Me.ManCategorias.Text = "Categorias"
        '
        'ManMarcas
        '
        Me.ManMarcas.Name = "ManMarcas"
        Me.ManMarcas.Size = New System.Drawing.Size(243, 30)
        Me.ManMarcas.Text = "Marcas"
        '
        'ManUnidadDeMedida
        '
        Me.ManUnidadDeMedida.Name = "ManUnidadDeMedida"
        Me.ManUnidadDeMedida.Size = New System.Drawing.Size(243, 30)
        Me.ManUnidadDeMedida.Text = "Unidad de Medida"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManClientes})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(164, 30)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'ManClientes
        '
        Me.ManClientes.Name = "ManClientes"
        Me.ManClientes.Size = New System.Drawing.Size(157, 30)
        Me.ManClientes.Text = "Clientes"
        '
        'SistemaToolStripMenuItem
        '
        Me.SistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManSucursales, Me.ManEmpleados, Me.TipoDocumentoToolStripMenuItem, Me.UsuariosToolStripMenuItem})
        Me.SistemaToolStripMenuItem.Name = "SistemaToolStripMenuItem"
        Me.SistemaToolStripMenuItem.Size = New System.Drawing.Size(164, 30)
        Me.SistemaToolStripMenuItem.Text = "Sistema"
        '
        'ManSucursales
        '
        Me.ManSucursales.Name = "ManSucursales"
        Me.ManSucursales.Size = New System.Drawing.Size(230, 30)
        Me.ManSucursales.Text = "Sucursales"
        '
        'ManEmpleados
        '
        Me.ManEmpleados.Name = "ManEmpleados"
        Me.ManEmpleados.Size = New System.Drawing.Size(230, 30)
        Me.ManEmpleados.Text = "Empleados"
        '
        'TipoDocumentoToolStripMenuItem
        '
        Me.TipoDocumentoToolStripMenuItem.Name = "TipoDocumentoToolStripMenuItem"
        Me.TipoDocumentoToolStripMenuItem.Size = New System.Drawing.Size(230, 30)
        Me.TipoDocumentoToolStripMenuItem.Text = "Tipo Documento"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(230, 30)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'TransaccionesToolStripMenuItem
        '
        Me.TransaccionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TranAlmacen})
        Me.TransaccionesToolStripMenuItem.Name = "TransaccionesToolStripMenuItem"
        Me.TransaccionesToolStripMenuItem.Size = New System.Drawing.Size(92, 29)
        Me.TransaccionesToolStripMenuItem.Text = "Almacen"
        '
        'TranAlmacen
        '
        Me.TranAlmacen.Name = "TranAlmacen"
        Me.TranAlmacen.Size = New System.Drawing.Size(312, 30)
        Me.TranAlmacen.Text = "Ingreso / Salida Mercaderia"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConProveedores, Me.ConClientes, Me.ProductosToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(101, 29)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'ConProveedores
        '
        Me.ConProveedores.Name = "ConProveedores"
        Me.ConProveedores.Size = New System.Drawing.Size(210, 30)
        Me.ConProveedores.Text = "Proveedores"
        '
        'ConClientes
        '
        Me.ConClientes.Name = "ConClientes"
        Me.ConClientes.Size = New System.Drawing.Size(210, 30)
        Me.ConClientes.Text = "Clientes"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(210, 30)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RepProveedores, Me.RepClientes})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(94, 29)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'RepProveedores
        '
        Me.RepProveedores.Name = "RepProveedores"
        Me.RepProveedores.Size = New System.Drawing.Size(195, 30)
        Me.RepProveedores.Text = "Proveedores"
        '
        'RepClientes
        '
        Me.RepClientes.Name = "RepClientes"
        Me.RepClientes.Size = New System.Drawing.Size(195, 30)
        Me.RepClientes.Text = "Clientes"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Usuario, Me.Hora_de_Inicio, Me.Tiempo_Transcurrido})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 642)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 14, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(1364, 30)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Usuario
        '
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Size = New System.Drawing.Size(76, 25)
        Me.Usuario.Text = "Usuario:"
        '
        'Hora_de_Inicio
        '
        Me.Hora_de_Inicio.Name = "Hora_de_Inicio"
        Me.Hora_de_Inicio.Size = New System.Drawing.Size(61, 25)
        Me.Hora_de_Inicio.Text = "Fecha:"
        '
        'Tiempo_Transcurrido
        '
        Me.Tiempo_Transcurrido.Name = "Tiempo_Transcurrido"
        Me.Tiempo_Transcurrido.Size = New System.Drawing.Size(173, 25)
        Me.Tiempo_Transcurrido.Text = "Tiempo Transcurrido"
        '
        'VentasToolStripMenuItem1
        '
        Me.VentasToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AperturaDeCajaToolStripMenuItem, Me.RegistroDeVentasToolStripMenuItem, Me.CuadreDeCajaToolStripMenuItem})
        Me.VentasToolStripMenuItem1.Name = "VentasToolStripMenuItem1"
        Me.VentasToolStripMenuItem1.Size = New System.Drawing.Size(76, 29)
        Me.VentasToolStripMenuItem1.Text = "Ventas"
        '
        'AperturaDeCajaToolStripMenuItem
        '
        Me.AperturaDeCajaToolStripMenuItem.Name = "AperturaDeCajaToolStripMenuItem"
        Me.AperturaDeCajaToolStripMenuItem.Size = New System.Drawing.Size(243, 30)
        Me.AperturaDeCajaToolStripMenuItem.Text = "Apertura de Caja"
        '
        'RegistroDeVentasToolStripMenuItem
        '
        Me.RegistroDeVentasToolStripMenuItem.Name = "RegistroDeVentasToolStripMenuItem"
        Me.RegistroDeVentasToolStripMenuItem.Size = New System.Drawing.Size(243, 30)
        Me.RegistroDeVentasToolStripMenuItem.Text = "Registro de Ventas"
        '
        'CuadreDeCajaToolStripMenuItem
        '
        Me.CuadreDeCajaToolStripMenuItem.Name = "CuadreDeCajaToolStripMenuItem"
        Me.CuadreDeCajaToolStripMenuItem.Size = New System.Drawing.Size(243, 30)
        Me.CuadreDeCajaToolStripMenuItem.Text = "Cuadre de Caja"
        '
        'Frm_MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1364, 672)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Frm_MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Gestion - Market"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Salir As ToolStripMenuItem
    Friend WithEvents MantenimientosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AlmacenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManProveedor As ToolStripMenuItem
    Friend WithEvents ManProductos As ToolStripMenuItem
    Friend WithEvents ManCategorias As ToolStripMenuItem
    Friend WithEvents ManMarcas As ToolStripMenuItem
    Friend WithEvents ManUnidadDeMedida As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManClientes As ToolStripMenuItem
    Friend WithEvents SistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManSucursales As ToolStripMenuItem
    Friend WithEvents ManEmpleados As ToolStripMenuItem
    Friend WithEvents TransaccionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TranAlmacen As ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConProveedores As ToolStripMenuItem
    Friend WithEvents ConClientes As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RepProveedores As ToolStripMenuItem
    Friend WithEvents RepClientes As ToolStripMenuItem
    Friend WithEvents Usuario As ToolStripStatusLabel
    Friend WithEvents Hora_de_Inicio As ToolStripStatusLabel
    Friend WithEvents Tiempo_Transcurrido As ToolStripStatusLabel
    Friend WithEvents TipoDocumentoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AperturaDeCajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroDeVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CuadreDeCajaToolStripMenuItem As ToolStripMenuItem
End Class
