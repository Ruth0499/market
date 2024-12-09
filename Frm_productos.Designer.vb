<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_productos
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DGVProducto = New System.Windows.Forms.DataGridView()
        Me.TxtBuscarProducto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Cbo_unimed = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Cbo_marca = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Txtstock = New System.Windows.Forms.TextBox()
        Me.Cbo_categoria = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txtpreven = New System.Windows.Forms.TextBox()
        Me.Txtprecos = New System.Windows.Forms.TextBox()
        Me.Txtcodbar = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Txtcodigo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Txtstockmin = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Txtstockmax = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGVProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WAMarketCasaBlanca.My.Resources.Resources.Productos
        Me.PictureBox1.Location = New System.Drawing.Point(644, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(352, 412)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DGVProducto)
        Me.GroupBox3.Controls.Add(Me.TxtBuscarProducto)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(10, 446)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(982, 297)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Listado de Productos:"
        '
        'DGVProducto
        '
        Me.DGVProducto.AllowUserToAddRows = False
        Me.DGVProducto.AllowUserToDeleteRows = False
        Me.DGVProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProducto.Location = New System.Drawing.Point(14, 77)
        Me.DGVProducto.Name = "DGVProducto"
        Me.DGVProducto.ReadOnly = True
        Me.DGVProducto.RowTemplate.Height = 28
        Me.DGVProducto.Size = New System.Drawing.Size(963, 208)
        Me.DGVProducto.TabIndex = 2
        '
        'TxtBuscarProducto
        '
        Me.TxtBuscarProducto.Location = New System.Drawing.Point(192, 31)
        Me.TxtBuscarProducto.Name = "TxtBuscarProducto"
        Me.TxtBuscarProducto.Size = New System.Drawing.Size(253, 26)
        Me.TxtBuscarProducto.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(51, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Buscar Producto :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_salir)
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.btn_guardar)
        Me.GroupBox1.Controls.Add(Me.btn_eliminar)
        Me.GroupBox1.Controls.Add(Me.btn_modificar)
        Me.GroupBox1.Controls.Add(Me.btn_nuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(626, 123)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'btn_salir
        '
        Me.btn_salir.Image = Global.WAMarketCasaBlanca.My.Resources.Resources.Custom_Icon_Design_Pretty_Office_7_Generate_keys
        Me.btn_salir.Location = New System.Drawing.Point(522, 15)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(90, 95)
        Me.btn_salir.TabIndex = 5
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Enabled = False
        Me.btn_cancelar.Image = Global.WAMarketCasaBlanca.My.Resources.Resources.Hopstarter_Sleek_Xp_Basic_Close_2
        Me.btn_cancelar.Location = New System.Drawing.Point(417, 15)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(90, 95)
        Me.btn_cancelar.TabIndex = 4
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.Image = Global.WAMarketCasaBlanca.My.Resources.Resources.Ampeross_Ampola_Floppy_drive_3_12
        Me.btn_guardar.Location = New System.Drawing.Point(316, 15)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(90, 95)
        Me.btn_guardar.TabIndex = 3
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Image = Global.WAMarketCasaBlanca.My.Resources.Resources.Custom_Icon_Design_Pretty_Office_9_Delete_file
        Me.btn_eliminar.Location = New System.Drawing.Point(214, 15)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(90, 95)
        Me.btn_eliminar.TabIndex = 2
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Image = Global.WAMarketCasaBlanca.My.Resources.Resources.Custom_Icon_Design_Pretty_Office_9_Edit_file
        Me.btn_modificar.Location = New System.Drawing.Point(112, 15)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(90, 95)
        Me.btn_modificar.TabIndex = 1
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Image = Global.WAMarketCasaBlanca.My.Resources.Resources.Custom_Icon_Design_Pretty_Office_9_New_file
        Me.btn_nuevo.Location = New System.Drawing.Point(15, 15)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(90, 95)
        Me.btn_nuevo.TabIndex = 0
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Txtstockmax)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Txtstockmin)
        Me.GroupBox2.Controls.Add(Me.Cbo_unimed)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Cbo_marca)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Txtstock)
        Me.GroupBox2.Controls.Add(Me.Cbo_categoria)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Txtpreven)
        Me.GroupBox2.Controls.Add(Me.Txtprecos)
        Me.GroupBox2.Controls.Add(Me.Txtcodbar)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtDescripcion)
        Me.GroupBox2.Controls.Add(Me.Txtcodigo)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 142)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(626, 298)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Producto:"
        '
        'Cbo_unimed
        '
        Me.Cbo_unimed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_unimed.FormattingEnabled = True
        Me.Cbo_unimed.Location = New System.Drawing.Point(116, 204)
        Me.Cbo_unimed.Name = "Cbo_unimed"
        Me.Cbo_unimed.Size = New System.Drawing.Size(186, 28)
        Me.Cbo_unimed.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(29, 210)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 20)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "U.Medida:"
        '
        'Cbo_marca
        '
        Me.Cbo_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_marca.FormattingEnabled = True
        Me.Cbo_marca.Location = New System.Drawing.Point(416, 209)
        Me.Cbo_marca.Name = "Cbo_marca"
        Me.Cbo_marca.Size = New System.Drawing.Size(194, 28)
        Me.Cbo_marca.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(353, 212)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 20)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Marca:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(54, 257)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Stock :"
        '
        'Txtstock
        '
        Me.Txtstock.Enabled = False
        Me.Txtstock.Location = New System.Drawing.Point(117, 254)
        Me.Txtstock.Name = "Txtstock"
        Me.Txtstock.Size = New System.Drawing.Size(56, 26)
        Me.Txtstock.TabIndex = 12
        '
        'Cbo_categoria
        '
        Me.Cbo_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_categoria.FormattingEnabled = True
        Me.Cbo_categoria.Location = New System.Drawing.Point(116, 161)
        Me.Cbo_categoria.Name = "Cbo_categoria"
        Me.Cbo_categoria.Size = New System.Drawing.Size(186, 28)
        Me.Cbo_categoria.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 164)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Categoria:"
        '
        'Txtpreven
        '
        Me.Txtpreven.Location = New System.Drawing.Point(416, 163)
        Me.Txtpreven.Name = "Txtpreven"
        Me.Txtpreven.Size = New System.Drawing.Size(140, 26)
        Me.Txtpreven.TabIndex = 9
        '
        'Txtprecos
        '
        Me.Txtprecos.Location = New System.Drawing.Point(415, 117)
        Me.Txtprecos.Name = "Txtprecos"
        Me.Txtprecos.Size = New System.Drawing.Size(140, 26)
        Me.Txtprecos.TabIndex = 8
        '
        'Txtcodbar
        '
        Me.Txtcodbar.Location = New System.Drawing.Point(117, 120)
        Me.Txtcodbar.MaxLength = 30
        Me.Txtcodbar.Name = "Txtcodbar"
        Me.Txtcodbar.Size = New System.Drawing.Size(140, 26)
        Me.Txtcodbar.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(336, 166)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "P. Venta:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(332, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "P. Costo :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Codigo Barra:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Codigo:"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(117, 75)
        Me.TxtDescripcion.MaxLength = 50
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(494, 26)
        Me.TxtDescripcion.TabIndex = 1
        '
        'Txtcodigo
        '
        Me.Txtcodigo.Enabled = False
        Me.Txtcodigo.Location = New System.Drawing.Point(117, 35)
        Me.Txtcodigo.Name = "Txtcodigo"
        Me.Txtcodigo.Size = New System.Drawing.Size(140, 26)
        Me.Txtcodigo.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(343, 260)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 20)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Stk Min:"
        '
        'Txtstockmin
        '
        Me.Txtstockmin.Enabled = False
        Me.Txtstockmin.Location = New System.Drawing.Point(415, 257)
        Me.Txtstockmin.Name = "Txtstockmin"
        Me.Txtstockmin.Size = New System.Drawing.Size(57, 26)
        Me.Txtstockmin.TabIndex = 18
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(478, 260)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(70, 20)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Stk Max:"
        '
        'Txtstockmax
        '
        Me.Txtstockmax.Enabled = False
        Me.Txtstockmax.Location = New System.Drawing.Point(554, 257)
        Me.Txtstockmax.Name = "Txtstockmax"
        Me.Txtstockmax.Size = New System.Drawing.Size(57, 26)
        Me.Txtstockmax.TabIndex = 20
        '
        'Frm_productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 749)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Productos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGVProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DGVProducto As DataGridView
    Friend WithEvents TxtBuscarProducto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_modificar As Button
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Txtstock As TextBox
    Friend WithEvents Cbo_categoria As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Txtpreven As TextBox
    Friend WithEvents Txtprecos As TextBox
    Friend WithEvents Txtcodbar As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Txtcodigo As TextBox
    Friend WithEvents Cbo_marca As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Cbo_unimed As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Txtstockmax As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Txtstockmin As TextBox
End Class
