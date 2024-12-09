<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_IngSalMercaderia
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Cbo_Proveedor = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Cbo_Documento = New System.Windows.Forms.ComboBox()
        Me.Cbo_Motivo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Cbo_categoria = New System.Windows.Forms.ComboBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Cbo_unimed = New System.Windows.Forms.ComboBox()
        Me.TXTPREUNI = New System.Windows.Forms.TextBox()
        Me.TXTDESC = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TXTIMP = New System.Windows.Forms.TextBox()
        Me.TXTCANT = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
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
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGDATOS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Cbo_Proveedor)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Cbo_Documento)
        Me.GroupBox1.Controls.Add(Me.Cbo_Motivo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Cbo_categoria)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(890, 161)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Cbo_Proveedor
        '
        Me.Cbo_Proveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_Proveedor.FormattingEnabled = True
        Me.Cbo_Proveedor.Location = New System.Drawing.Point(114, 114)
        Me.Cbo_Proveedor.Name = "Cbo_Proveedor"
        Me.Cbo_Proveedor.Size = New System.Drawing.Size(275, 28)
        Me.Cbo_Proveedor.TabIndex = 26
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(717, 69)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(155, 26)
        Me.DateTimePicker1.TabIndex = 25
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(395, 68)
        Me.TextBox2.MaxLength = 10
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(169, 26)
        Me.TextBox2.TabIndex = 24
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(333, 68)
        Me.TextBox1.MaxLength = 4
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(56, 26)
        Me.TextBox1.TabIndex = 23
        '
        'Cbo_Documento
        '
        Me.Cbo_Documento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_Documento.FormattingEnabled = True
        Me.Cbo_Documento.Location = New System.Drawing.Point(114, 66)
        Me.Cbo_Documento.Name = "Cbo_Documento"
        Me.Cbo_Documento.Size = New System.Drawing.Size(213, 28)
        Me.Cbo_Documento.TabIndex = 22
        '
        'Cbo_Motivo
        '
        Me.Cbo_Motivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_Motivo.FormattingEnabled = True
        Me.Cbo_Motivo.Location = New System.Drawing.Point(654, 19)
        Me.Cbo_Motivo.Name = "Cbo_Motivo"
        Me.Cbo_Motivo.Size = New System.Drawing.Size(218, 28)
        Me.Cbo_Motivo.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(589, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 20)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Motivo:"
        '
        'Cbo_categoria
        '
        Me.Cbo_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_categoria.FormattingEnabled = True
        Me.Cbo_categoria.Location = New System.Drawing.Point(432, 19)
        Me.Cbo_categoria.Name = "Cbo_categoria"
        Me.Cbo_categoria.Size = New System.Drawing.Size(132, 28)
        Me.Cbo_categoria.TabIndex = 19
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(179, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(148, 24)
        Me.RadioButton2.TabIndex = 5
        Me.RadioButton2.Text = "Almacen/Tienda"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(14, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(159, 24)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Cliente/Proveedor"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(48, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Origen:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(344, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Categoria:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Documento:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(589, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha Registro:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Cbo_unimed)
        Me.GroupBox3.Controls.Add(Me.TXTPREUNI)
        Me.GroupBox3.Controls.Add(Me.TXTDESC)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.TXTIMP)
        Me.GroupBox3.Controls.Add(Me.TXTCANT)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 184)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.GroupBox3.Size = New System.Drawing.Size(1275, 78)
        Me.GroupBox3.TabIndex = 45
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos del Ingreso/Salida:"
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
        Me.TXTDESC.MaxLength = 50
        Me.TXTDESC.Name = "TXTDESC"
        Me.TXTDESC.Size = New System.Drawing.Size(296, 26)
        Me.TXTDESC.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(188, 40)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "U.M.:"
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
        Me.TXTCANT.MaxLength = 7
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
        'DGDATOS
        '
        Me.DGDATOS.AllowUserToAddRows = False
        Me.DGDATOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGDATOS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cantidad, Me.Uni_Me, Me.Descripcion, Me.precio_unitario, Me.importe, Me.accion})
        Me.DGDATOS.Location = New System.Drawing.Point(12, 278)
        Me.DGDATOS.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.DGDATOS.Name = "DGDATOS"
        Me.DGDATOS.ReadOnly = True
        Me.DGDATOS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGDATOS.Size = New System.Drawing.Size(1275, 308)
        Me.DGDATOS.TabIndex = 47
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
        Me.GroupBox4.Location = New System.Drawing.Point(12, 602)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.GroupBox4.Size = New System.Drawing.Size(890, 131)
        Me.GroupBox4.TabIndex = 48
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
        'Frm_IngSalMercaderia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1301, 736)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.DGDATOS)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_IngSalMercaderia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso / Salida deMercaderia"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGDATOS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Cbo_Documento As ComboBox
    Friend WithEvents Cbo_Motivo As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Cbo_categoria As ComboBox
    Friend WithEvents Cbo_Proveedor As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Cbo_unimed As ComboBox
    Friend WithEvents TXTPREUNI As TextBox
    Friend WithEvents TXTDESC As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TXTIMP As TextBox
    Friend WithEvents TXTCANT As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
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
End Class
