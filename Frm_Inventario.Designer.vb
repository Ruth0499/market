<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Inventario
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
        Me.components = New System.ComponentModel.Container()
        Me.TXTCODFAC = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblfecha_impresion = New System.Windows.Forms.Label()
        Me.btn_cliente = New System.Windows.Forms.Button()
        Me.TXTRAZSOC = New System.Windows.Forms.TextBox()
        Me.TXTRUC = New System.Windows.Forms.TextBox()
        Me.TXTDIR = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Cbo_unimed = New System.Windows.Forms.ComboBox()
        Me.TXTPREUNI = New System.Windows.Forms.TextBox()
        Me.TXTDESC = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXTIMP = New System.Windows.Forms.TextBox()
        Me.TXTCANT = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DGDATOS = New System.Windows.Forms.DataGridView()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Uni_Me = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio_unitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.accion = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TXTLETRAS = New System.Windows.Forms.TextBox()
        Me.lblnota = New System.Windows.Forms.Label()
        Me.BTNIMPRIMIR = New System.Windows.Forms.Button()
        Me.BTNGUARDAR = New System.Windows.Forms.Button()
        Me.BTNMODIFICAR = New System.Windows.Forms.Button()
        Me.BTNELIMINAR = New System.Windows.Forms.Button()
        Me.BTNNUEVO = New System.Windows.Forms.Button()
        Me.LBLNUM = New System.Windows.Forms.Label()
        Me.TXTIGV = New System.Windows.Forms.TextBox()
        Me.TXTTOT = New System.Windows.Forms.TextBox()
        Me.TXTSUBTOT = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGDATOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXTCODFAC
        '
        Me.TXTCODFAC.Location = New System.Drawing.Point(20, 5)
        Me.TXTCODFAC.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.TXTCODFAC.Name = "TXTCODFAC"
        Me.TXTCODFAC.Size = New System.Drawing.Size(144, 26)
        Me.TXTCODFAC.TabIndex = 42
        Me.TXTCODFAC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_cliente)
        Me.GroupBox2.Controls.Add(Me.TXTRAZSOC)
        Me.GroupBox2.Controls.Add(Me.TXTRUC)
        Me.GroupBox2.Controls.Add(Me.TXTDIR)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.lblfecha)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 51)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.GroupBox2.Size = New System.Drawing.Size(773, 142)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Cliente:"
        '
        'lblfecha_impresion
        '
        Me.lblfecha_impresion.AutoSize = True
        Me.lblfecha_impresion.Location = New System.Drawing.Point(262, 9)
        Me.lblfecha_impresion.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblfecha_impresion.Name = "lblfecha_impresion"
        Me.lblfecha_impresion.Size = New System.Drawing.Size(153, 20)
        Me.lblfecha_impresion.TabIndex = 15
        Me.lblfecha_impresion.Text = "Ffecha de impresion"
        '
        'btn_cliente
        '
        Me.btn_cliente.Image = Global.WAMarketCasaBlanca.My.Resources.Resources.Aha_Soft_Large_User_Notary
        Me.btn_cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cliente.Location = New System.Drawing.Point(625, 60)
        Me.btn_cliente.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.btn_cliente.Name = "btn_cliente"
        Me.btn_cliente.Size = New System.Drawing.Size(136, 69)
        Me.btn_cliente.TabIndex = 14
        Me.btn_cliente.Text = "         Cliente"
        Me.btn_cliente.UseVisualStyleBackColor = True
        '
        'TXTRAZSOC
        '
        Me.TXTRAZSOC.Location = New System.Drawing.Point(158, 60)
        Me.TXTRAZSOC.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.TXTRAZSOC.Name = "TXTRAZSOC"
        Me.TXTRAZSOC.Size = New System.Drawing.Size(447, 26)
        Me.TXTRAZSOC.TabIndex = 2
        '
        'TXTRUC
        '
        Me.TXTRUC.Location = New System.Drawing.Point(431, 23)
        Me.TXTRUC.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.TXTRUC.Name = "TXTRUC"
        Me.TXTRUC.Size = New System.Drawing.Size(174, 26)
        Me.TXTRUC.TabIndex = 1
        '
        'TXTDIR
        '
        Me.TXTDIR.Location = New System.Drawing.Point(158, 97)
        Me.TXTDIR.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.TXTDIR.Name = "TXTDIR"
        Me.TXTDIR.Size = New System.Drawing.Size(447, 26)
        Me.TXTDIR.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(63, 102)
        Me.Label11.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 20)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Dirección:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(63, 65)
        Me.Label10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 20)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Señor(es):"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(345, 27)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 20)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "DNI/Ruc:"
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(153, 28)
        Me.lblfecha.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(54, 20)
        Me.lblfecha.TabIndex = 1
        Me.lblfecha.Text = "Fecha"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 28)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Fecha de Emisión:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Cbo_unimed)
        Me.GroupBox3.Controls.Add(Me.TXTPREUNI)
        Me.GroupBox3.Controls.Add(Me.TXTDESC)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TXTIMP)
        Me.GroupBox3.Controls.Add(Me.TXTCANT)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(20, 194)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.GroupBox3.Size = New System.Drawing.Size(1275, 78)
        Me.GroupBox3.TabIndex = 44
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos del Ingreso:"
        '
        'Cbo_unimed
        '
        Me.Cbo_unimed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_unimed.FormattingEnabled = True
        Me.Cbo_unimed.Location = New System.Drawing.Point(239, 35)
        Me.Cbo_unimed.Name = "Cbo_unimed"
        Me.Cbo_unimed.Size = New System.Drawing.Size(113, 28)
        Me.Cbo_unimed.TabIndex = 18
        '
        'TXTPREUNI
        '
        Me.TXTPREUNI.Location = New System.Drawing.Point(912, 32)
        Me.TXTPREUNI.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.TXTPREUNI.Name = "TXTPREUNI"
        Me.TXTPREUNI.Size = New System.Drawing.Size(109, 26)
        Me.TXTPREUNI.TabIndex = 13
        '
        'TXTDESC
        '
        Me.TXTDESC.Location = New System.Drawing.Point(477, 34)
        Me.TXTDESC.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.TXTDESC.Name = "TXTDESC"
        Me.TXTDESC.Size = New System.Drawing.Size(296, 26)
        Me.TXTDESC.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(188, 40)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "U.M.:"
        '
        'TXTIMP
        '
        Me.TXTIMP.Location = New System.Drawing.Point(1101, 31)
        Me.TXTIMP.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.TXTIMP.Name = "TXTIMP"
        Me.TXTIMP.Size = New System.Drawing.Size(139, 26)
        Me.TXTIMP.TabIndex = 8
        '
        'TXTCANT
        '
        Me.TXTCANT.Location = New System.Drawing.Point(88, 35)
        Me.TXTCANT.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.TXTCANT.Name = "TXTCANT"
        Me.TXTCANT.Size = New System.Drawing.Size(89, 26)
        Me.TXTCANT.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(1035, 35)
        Me.Label15.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(68, 20)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Importe:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(788, 38)
        Me.Label14.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(116, 20)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Precio Unitario:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(366, 38)
        Me.Label13.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 20)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Descripción:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 38)
        Me.Label12.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 20)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Cantidad:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(177, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "N° 001  - "
        '
        'DGDATOS
        '
        Me.DGDATOS.AllowUserToAddRows = False
        Me.DGDATOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGDATOS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cantidad, Me.Uni_Me, Me.Descripcion, Me.precio_unitario, Me.importe, Me.accion})
        Me.DGDATOS.Location = New System.Drawing.Point(20, 288)
        Me.DGDATOS.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.DGDATOS.Name = "DGDATOS"
        Me.DGDATOS.ReadOnly = True
        Me.DGDATOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGDATOS.Size = New System.Drawing.Size(1275, 308)
        Me.DGDATOS.TabIndex = 46
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Uni_Me
        '
        Me.Uni_Me.HeaderText = "Uni_Me"
        Me.Uni_Me.Name = "Uni_Me"
        Me.Uni_Me.ReadOnly = True
        '
        'Descripcion
        '
        Me.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 5
        '
        'precio_unitario
        '
        Me.precio_unitario.HeaderText = "precio unitario"
        Me.precio_unitario.Name = "precio_unitario"
        Me.precio_unitario.ReadOnly = True
        '
        'importe
        '
        Me.importe.HeaderText = "importe"
        Me.importe.Name = "importe"
        Me.importe.ReadOnly = True
        '
        'accion
        '
        Me.accion.HeaderText = "accion"
        Me.accion.Name = "accion"
        Me.accion.ReadOnly = True
        Me.accion.Text = "eliminar"
        Me.accion.UseColumnTextForLinkValue = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TXTLETRAS)
        Me.GroupBox4.Controls.Add(Me.lblnota)
        Me.GroupBox4.Controls.Add(Me.BTNIMPRIMIR)
        Me.GroupBox4.Controls.Add(Me.BTNGUARDAR)
        Me.GroupBox4.Controls.Add(Me.BTNMODIFICAR)
        Me.GroupBox4.Controls.Add(Me.BTNELIMINAR)
        Me.GroupBox4.Controls.Add(Me.BTNNUEVO)
        Me.GroupBox4.Location = New System.Drawing.Point(20, 612)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.GroupBox4.Size = New System.Drawing.Size(890, 131)
        Me.GroupBox4.TabIndex = 47
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Registro de Cliente"
        '
        'TXTLETRAS
        '
        Me.TXTLETRAS.Location = New System.Drawing.Point(162, -5)
        Me.TXTLETRAS.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.TXTLETRAS.Name = "TXTLETRAS"
        Me.TXTLETRAS.Size = New System.Drawing.Size(552, 26)
        Me.TXTLETRAS.TabIndex = 51
        '
        'lblnota
        '
        Me.lblnota.AutoSize = True
        Me.lblnota.Location = New System.Drawing.Point(12, 105)
        Me.lblnota.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblnota.Name = "lblnota"
        Me.lblnota.Size = New System.Drawing.Size(711, 60)
        Me.lblnota.TabIndex = 49
        Me.lblnota.Text = "Nota: Para Modificar é Eliminar debe de estar selecciona la fila y Nuevo para ing" &
    "resar nuevo registro." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "           "
        '
        'BTNIMPRIMIR
        '
        Me.BTNIMPRIMIR.Image = Global.WAMarketCasaBlanca.My.Resources.Resources.Delacro_Id_Printer
        Me.BTNIMPRIMIR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNIMPRIMIR.Location = New System.Drawing.Point(728, 35)
        Me.BTNIMPRIMIR.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.BTNIMPRIMIR.Name = "BTNIMPRIMIR"
        Me.BTNIMPRIMIR.Size = New System.Drawing.Size(153, 62)
        Me.BTNIMPRIMIR.TabIndex = 15
        Me.BTNIMPRIMIR.Text = "     Imprimir"
        Me.BTNIMPRIMIR.UseVisualStyleBackColor = True
        '
        'BTNGUARDAR
        '
        Me.BTNGUARDAR.Image = Global.WAMarketCasaBlanca.My.Resources.Resources.Ampeross_Ampola_Floppy_drive_3_12
        Me.BTNGUARDAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNGUARDAR.Location = New System.Drawing.Point(212, 35)
        Me.BTNGUARDAR.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.BTNGUARDAR.Name = "BTNGUARDAR"
        Me.BTNGUARDAR.Size = New System.Drawing.Size(160, 62)
        Me.BTNGUARDAR.TabIndex = 11
        Me.BTNGUARDAR.Text = "      Guardar"
        Me.BTNGUARDAR.UseVisualStyleBackColor = True
        '
        'BTNMODIFICAR
        '
        Me.BTNMODIFICAR.Image = Global.WAMarketCasaBlanca.My.Resources.Resources.Custom_Icon_Design_Pretty_Office_9_Edit_file
        Me.BTNMODIFICAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNMODIFICAR.Location = New System.Drawing.Point(384, 35)
        Me.BTNMODIFICAR.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.BTNMODIFICAR.Name = "BTNMODIFICAR"
        Me.BTNMODIFICAR.Size = New System.Drawing.Size(162, 62)
        Me.BTNMODIFICAR.TabIndex = 12
        Me.BTNMODIFICAR.Text = "       Modificar"
        Me.BTNMODIFICAR.UseVisualStyleBackColor = True
        '
        'BTNELIMINAR
        '
        Me.BTNELIMINAR.Image = Global.WAMarketCasaBlanca.My.Resources.Resources.Custom_Icon_Design_Pretty_Office_9_Delete_file
        Me.BTNELIMINAR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNELIMINAR.Location = New System.Drawing.Point(546, 35)
        Me.BTNELIMINAR.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.BTNELIMINAR.Name = "BTNELIMINAR"
        Me.BTNELIMINAR.Size = New System.Drawing.Size(170, 62)
        Me.BTNELIMINAR.TabIndex = 13
        Me.BTNELIMINAR.Text = "     Eliminar"
        Me.BTNELIMINAR.UseVisualStyleBackColor = True
        '
        'BTNNUEVO
        '
        Me.BTNNUEVO.Image = Global.WAMarketCasaBlanca.My.Resources.Resources.Custom_Icon_Design_Pretty_Office_9_New_file
        Me.BTNNUEVO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNNUEVO.Location = New System.Drawing.Point(32, 35)
        Me.BTNNUEVO.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.BTNNUEVO.Name = "BTNNUEVO"
        Me.BTNNUEVO.Size = New System.Drawing.Size(168, 62)
        Me.BTNNUEVO.TabIndex = 10
        Me.BTNNUEVO.Text = "     Nuevo"
        Me.BTNNUEVO.UseVisualStyleBackColor = True
        '
        'LBLNUM
        '
        Me.LBLNUM.AutoSize = True
        Me.LBLNUM.Location = New System.Drawing.Point(1006, 670)
        Me.LBLNUM.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LBLNUM.Name = "LBLNUM"
        Me.LBLNUM.Size = New System.Drawing.Size(34, 20)
        Me.LBLNUM.TabIndex = 58
        Me.LBLNUM.Text = "Igv:"
        '
        'TXTIGV
        '
        Me.TXTIGV.Location = New System.Drawing.Point(1059, 664)
        Me.TXTIGV.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.TXTIGV.Name = "TXTIGV"
        Me.TXTIGV.Size = New System.Drawing.Size(172, 26)
        Me.TXTIGV.TabIndex = 57
        '
        'TXTTOT
        '
        Me.TXTTOT.Enabled = False
        Me.TXTTOT.Location = New System.Drawing.Point(1059, 706)
        Me.TXTTOT.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.TXTTOT.Name = "TXTTOT"
        Me.TXTTOT.Size = New System.Drawing.Size(172, 26)
        Me.TXTTOT.TabIndex = 56
        '
        'TXTSUBTOT
        '
        Me.TXTSUBTOT.Enabled = False
        Me.TXTSUBTOT.Location = New System.Drawing.Point(1059, 624)
        Me.TXTSUBTOT.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.TXTSUBTOT.Name = "TXTSUBTOT"
        Me.TXTSUBTOT.Size = New System.Drawing.Size(172, 26)
        Me.TXTSUBTOT.TabIndex = 55
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(999, 712)
        Me.Label16.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 20)
        Me.Label16.TabIndex = 54
        Me.Label16.Text = "Total:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(970, 630)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 20)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "SubTotal:"
        '
        'Timer1
        '
        '
        'Frm_Inventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1305, 746)
        Me.Controls.Add(Me.lblfecha_impresion)
        Me.Controls.Add(Me.LBLNUM)
        Me.Controls.Add(Me.TXTIGV)
        Me.Controls.Add(Me.TXTTOT)
        Me.Controls.Add(Me.TXTSUBTOT)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.DGDATOS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TXTCODFAC)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Frm_Inventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modulo de Ventas"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGDATOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXTCODFAC As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblfecha_impresion As Label
    Friend WithEvents btn_cliente As Button
    Friend WithEvents TXTRAZSOC As TextBox
    Friend WithEvents TXTRUC As TextBox
    Friend WithEvents TXTDIR As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblfecha As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TXTPREUNI As TextBox
    Friend WithEvents TXTDESC As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXTIMP As TextBox
    Friend WithEvents TXTCANT As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DGDATOS As DataGridView
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Uni_Me As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents precio_unitario As DataGridViewTextBoxColumn
    Friend WithEvents importe As DataGridViewTextBoxColumn
    Friend WithEvents accion As DataGridViewLinkColumn
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TXTLETRAS As TextBox
    Friend WithEvents lblnota As Label
    Friend WithEvents BTNIMPRIMIR As Button
    Friend WithEvents BTNGUARDAR As Button
    Friend WithEvents BTNMODIFICAR As Button
    Friend WithEvents BTNELIMINAR As Button
    Friend WithEvents BTNNUEVO As Button
    Friend WithEvents LBLNUM As Label
    Friend WithEvents TXTIGV As TextBox
    Friend WithEvents TXTTOT As TextBox
    Friend WithEvents TXTSUBTOT As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Cbo_unimed As ComboBox
    Friend WithEvents Timer1 As Timer
End Class
