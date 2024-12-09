<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Proveedores
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DGVProveedor = New System.Windows.Forms.DataGridView()
        Me.TxtBuscarProveedor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtNumdoc = New System.Windows.Forms.TextBox()
        Me.Cbo_tipoDocu = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txtmailprov = New System.Windows.Forms.TextBox()
        Me.TxtTelprov = New System.Windows.Forms.TextBox()
        Me.Txtdirprov = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Txtcodigo = New System.Windows.Forms.TextBox()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGVProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DGVProveedor)
        Me.GroupBox3.Controls.Add(Me.TxtBuscarProveedor)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 447)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(983, 284)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Listado de Proveedores:"
        '
        'DGVProveedor
        '
        Me.DGVProveedor.AllowUserToAddRows = False
        Me.DGVProveedor.AllowUserToDeleteRows = False
        Me.DGVProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVProveedor.Location = New System.Drawing.Point(6, 83)
        Me.DGVProveedor.Name = "DGVProveedor"
        Me.DGVProveedor.ReadOnly = True
        Me.DGVProveedor.RowTemplate.Height = 28
        Me.DGVProveedor.Size = New System.Drawing.Size(963, 195)
        Me.DGVProveedor.TabIndex = 2
        '
        'TxtBuscarProveedor
        '
        Me.TxtBuscarProveedor.Location = New System.Drawing.Point(153, 39)
        Me.TxtBuscarProveedor.Name = "TxtBuscarProveedor"
        Me.TxtBuscarProveedor.Size = New System.Drawing.Size(253, 26)
        Me.TxtBuscarProveedor.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Buscar Proveedor :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_salir)
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.btn_guardar)
        Me.GroupBox1.Controls.Add(Me.btn_eliminar)
        Me.GroupBox1.Controls.Add(Me.btn_modificar)
        Me.GroupBox1.Controls.Add(Me.btn_nuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(626, 123)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'btn_salir
        '
        Me.btn_salir.Image = Global.WAMarketCasaBlanca.My.Resources.Resources.Custom_Icon_Design_Pretty_Office_7_Generate_keys
        Me.btn_salir.Location = New System.Drawing.Point(522, 16)
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
        Me.btn_cancelar.Location = New System.Drawing.Point(417, 16)
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
        Me.btn_guardar.Location = New System.Drawing.Point(317, 16)
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
        Me.btn_eliminar.Location = New System.Drawing.Point(214, 16)
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
        Me.btn_modificar.Location = New System.Drawing.Point(112, 16)
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
        Me.btn_nuevo.Location = New System.Drawing.Point(15, 16)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(90, 95)
        Me.btn_nuevo.TabIndex = 0
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WAMarketCasaBlanca.My.Resources.Resources.Proveedores
        Me.PictureBox1.Location = New System.Drawing.Point(643, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(352, 413)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TxtNumdoc)
        Me.GroupBox2.Controls.Add(Me.Cbo_tipoDocu)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Txtmailprov)
        Me.GroupBox2.Controls.Add(Me.TxtTelprov)
        Me.GroupBox2.Controls.Add(Me.Txtdirprov)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtDescripcion)
        Me.GroupBox2.Controls.Add(Me.Txtcodigo)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 141)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(626, 300)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Proveedor:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(392, 169)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Numero :"
        '
        'TxtNumdoc
        '
        Me.TxtNumdoc.Location = New System.Drawing.Point(471, 166)
        Me.TxtNumdoc.Name = "TxtNumdoc"
        Me.TxtNumdoc.Size = New System.Drawing.Size(141, 26)
        Me.TxtNumdoc.TabIndex = 12
        '
        'Cbo_tipoDocu
        '
        Me.Cbo_tipoDocu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_tipoDocu.FormattingEnabled = True
        Me.Cbo_tipoDocu.Location = New System.Drawing.Point(117, 166)
        Me.Cbo_tipoDocu.Name = "Cbo_tipoDocu"
        Me.Cbo_tipoDocu.Size = New System.Drawing.Size(269, 28)
        Me.Cbo_tipoDocu.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(31, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Tipo Doc.:"
        '
        'Txtmailprov
        '
        Me.Txtmailprov.Location = New System.Drawing.Point(117, 257)
        Me.Txtmailprov.Name = "Txtmailprov"
        Me.Txtmailprov.Size = New System.Drawing.Size(495, 26)
        Me.Txtmailprov.TabIndex = 9
        '
        'TxtTelprov
        '
        Me.TxtTelprov.Location = New System.Drawing.Point(117, 215)
        Me.TxtTelprov.Name = "TxtTelprov"
        Me.TxtTelprov.Size = New System.Drawing.Size(141, 26)
        Me.TxtTelprov.TabIndex = 8
        '
        'Txtdirprov
        '
        Me.Txtdirprov.Location = New System.Drawing.Point(117, 120)
        Me.Txtdirprov.Name = "Txtdirprov"
        Me.Txtdirprov.Size = New System.Drawing.Size(495, 26)
        Me.Txtdirprov.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(59, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Telefono:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Direccion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Codigo:"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(117, 76)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(495, 26)
        Me.TxtDescripcion.TabIndex = 1
        '
        'Txtcodigo
        '
        Me.Txtcodigo.Enabled = False
        Me.Txtcodigo.Location = New System.Drawing.Point(117, 35)
        Me.Txtcodigo.Name = "Txtcodigo"
        Me.Txtcodigo.Size = New System.Drawing.Size(141, 26)
        Me.Txtcodigo.TabIndex = 0
        '
        'Frm_Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1005, 743)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Proveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Proveedores"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGVProveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DGVProveedor As DataGridView
    Friend WithEvents TxtBuscarProveedor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_modificar As Button
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtNumdoc As TextBox
    Friend WithEvents Cbo_tipoDocu As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Txtmailprov As TextBox
    Friend WithEvents TxtTelprov As TextBox
    Friend WithEvents Txtdirprov As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Txtcodigo As TextBox
    Friend WithEvents Label8 As Label
End Class
