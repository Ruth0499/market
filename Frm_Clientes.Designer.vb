<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Clientes
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
        Me.DGVCliente = New System.Windows.Forms.DataGridView()
        Me.TxtBuscarCliente = New System.Windows.Forms.TextBox()
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
        Me.Txtmailclie = New System.Windows.Forms.TextBox()
        Me.TxtTelclie = New System.Windows.Forms.TextBox()
        Me.Txtdirclie = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Txtcodigo = New System.Windows.Forms.TextBox()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGVCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DGVCliente)
        Me.GroupBox3.Controls.Add(Me.TxtBuscarCliente)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 291)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(656, 195)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Listado de Clientes:"
        '
        'DGVCliente
        '
        Me.DGVCliente.AllowUserToAddRows = False
        Me.DGVCliente.AllowUserToDeleteRows = False
        Me.DGVCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVCliente.Location = New System.Drawing.Point(10, 49)
        Me.DGVCliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DGVCliente.Name = "DGVCliente"
        Me.DGVCliente.ReadOnly = True
        Me.DGVCliente.RowTemplate.Height = 28
        Me.DGVCliente.Size = New System.Drawing.Size(630, 136)
        Me.DGVCliente.TabIndex = 2
        '
        'TxtBuscarCliente
        '
        Me.TxtBuscarCliente.Location = New System.Drawing.Point(106, 21)
        Me.TxtBuscarCliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtBuscarCliente.Name = "TxtBuscarCliente"
        Me.TxtBuscarCliente.Size = New System.Drawing.Size(170, 20)
        Me.TxtBuscarCliente.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 25)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Buscar Cliente :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_salir)
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.btn_guardar)
        Me.GroupBox1.Controls.Add(Me.btn_eliminar)
        Me.GroupBox1.Controls.Add(Me.btn_modificar)
        Me.GroupBox1.Controls.Add(Me.btn_nuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(417, 80)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'btn_salir
        '
        Me.btn_salir.Image = Global.WAMarketCasaBlanca.My.Resources.Resources.Custom_Icon_Design_Pretty_Office_7_Generate_keys
        Me.btn_salir.Location = New System.Drawing.Point(348, 10)
        Me.btn_salir.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(60, 62)
        Me.btn_salir.TabIndex = 5
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_cancelar
        '
        Me.btn_cancelar.Enabled = False
        Me.btn_cancelar.Image = Global.WAMarketCasaBlanca.My.Resources.Resources.Hopstarter_Sleek_Xp_Basic_Close_2
        Me.btn_cancelar.Location = New System.Drawing.Point(278, 10)
        Me.btn_cancelar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_cancelar.Name = "btn_cancelar"
        Me.btn_cancelar.Size = New System.Drawing.Size(60, 62)
        Me.btn_cancelar.TabIndex = 4
        Me.btn_cancelar.Text = "Cancelar"
        Me.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cancelar.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.Image = Global.WAMarketCasaBlanca.My.Resources.Resources.Ampeross_Ampola_Floppy_drive_3_12
        Me.btn_guardar.Location = New System.Drawing.Point(211, 10)
        Me.btn_guardar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(60, 62)
        Me.btn_guardar.TabIndex = 3
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Image = Global.WAMarketCasaBlanca.My.Resources.Resources.Custom_Icon_Design_Pretty_Office_9_Delete_file
        Me.btn_eliminar.Location = New System.Drawing.Point(143, 10)
        Me.btn_eliminar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(60, 62)
        Me.btn_eliminar.TabIndex = 2
        Me.btn_eliminar.Text = "Eliminar"
        Me.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'btn_modificar
        '
        Me.btn_modificar.Image = Global.WAMarketCasaBlanca.My.Resources.Resources.Custom_Icon_Design_Pretty_Office_9_Edit_file
        Me.btn_modificar.Location = New System.Drawing.Point(75, 10)
        Me.btn_modificar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(60, 62)
        Me.btn_modificar.TabIndex = 1
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.Image = Global.WAMarketCasaBlanca.My.Resources.Resources.Custom_Icon_Design_Pretty_Office_9_New_file
        Me.btn_nuevo.Location = New System.Drawing.Point(10, 10)
        Me.btn_nuevo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(60, 62)
        Me.btn_nuevo.TabIndex = 0
        Me.btn_nuevo.Text = "Nuevo"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WAMarketCasaBlanca.My.Resources.Resources.Clientes
        Me.PictureBox1.Location = New System.Drawing.Point(429, 18)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(235, 268)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TxtNumdoc)
        Me.GroupBox2.Controls.Add(Me.Cbo_tipoDocu)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Txtmailclie)
        Me.GroupBox2.Controls.Add(Me.TxtTelclie)
        Me.GroupBox2.Controls.Add(Me.Txtdirclie)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtDescripcion)
        Me.GroupBox2.Controls.Add(Me.Txtcodigo)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 92)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(417, 195)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Cliente:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(261, 110)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Numero :"
        '
        'TxtNumdoc
        '
        Me.TxtNumdoc.Location = New System.Drawing.Point(314, 108)
        Me.TxtNumdoc.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtNumdoc.Name = "TxtNumdoc"
        Me.TxtNumdoc.Size = New System.Drawing.Size(95, 20)
        Me.TxtNumdoc.TabIndex = 12
        '
        'Cbo_tipoDocu
        '
        Me.Cbo_tipoDocu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_tipoDocu.FormattingEnabled = True
        Me.Cbo_tipoDocu.Location = New System.Drawing.Point(78, 108)
        Me.Cbo_tipoDocu.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Cbo_tipoDocu.Name = "Cbo_tipoDocu"
        Me.Cbo_tipoDocu.Size = New System.Drawing.Size(181, 21)
        Me.Cbo_tipoDocu.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 110)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Tipo Doc.:"
        '
        'Txtmailclie
        '
        Me.Txtmailclie.Location = New System.Drawing.Point(78, 167)
        Me.Txtmailclie.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Txtmailclie.Name = "Txtmailclie"
        Me.Txtmailclie.Size = New System.Drawing.Size(331, 20)
        Me.Txtmailclie.TabIndex = 9
        '
        'TxtTelclie
        '
        Me.TxtTelclie.Location = New System.Drawing.Point(78, 140)
        Me.TxtTelclie.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtTelclie.Name = "TxtTelclie"
        Me.TxtTelclie.Size = New System.Drawing.Size(95, 20)
        Me.TxtTelclie.TabIndex = 8
        '
        'Txtdirclie
        '
        Me.Txtdirclie.Location = New System.Drawing.Point(78, 78)
        Me.Txtdirclie.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Txtdirclie.Name = "Txtdirclie"
        Me.Txtdirclie.Size = New System.Drawing.Size(331, 20)
        Me.Txtdirclie.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 167)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 140)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Telefono:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 78)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Direccion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 49)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Codigo:"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(78, 49)
        Me.TxtDescripcion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(331, 20)
        Me.TxtDescripcion.TabIndex = 1
        '
        'Txtcodigo
        '
        Me.Txtcodigo.Enabled = False
        Me.Txtcodigo.Location = New System.Drawing.Point(78, 23)
        Me.Txtcodigo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Txtcodigo.Name = "Txtcodigo"
        Me.Txtcodigo.Size = New System.Drawing.Size(95, 20)
        Me.Txtcodigo.TabIndex = 0
        '
        'Frm_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 487)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Clientes"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGVCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DGVCliente As DataGridView
    Friend WithEvents TxtBuscarCliente As TextBox
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
    Friend WithEvents TxtNumdoc As TextBox
    Friend WithEvents Cbo_tipoDocu As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Txtmailclie As TextBox
    Friend WithEvents TxtTelclie As TextBox
    Friend WithEvents Txtdirclie As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Txtcodigo As TextBox
End Class
