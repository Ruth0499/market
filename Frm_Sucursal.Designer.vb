<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Sucursal
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Txtmailsucu = New System.Windows.Forms.TextBox()
        Me.TxtTelsucu = New System.Windows.Forms.TextBox()
        Me.Txtdirsucu = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Txtcodigo = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DGVSucursal = New System.Windows.Forms.DataGridView()
        Me.TxtBuscarMarca = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGVSucursal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WAMarketCasaBlanca.My.Resources.Resources.Sucursal
        Me.PictureBox1.Location = New System.Drawing.Point(644, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(345, 363)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Txtmailsucu)
        Me.GroupBox2.Controls.Add(Me.TxtTelsucu)
        Me.GroupBox2.Controls.Add(Me.Txtdirsucu)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtDescripcion)
        Me.GroupBox2.Controls.Add(Me.Txtcodigo)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 139)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(626, 250)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Sucursal:"
        '
        'Txtmailsucu
        '
        Me.Txtmailsucu.Location = New System.Drawing.Point(154, 208)
        Me.Txtmailsucu.Name = "Txtmailsucu"
        Me.Txtmailsucu.Size = New System.Drawing.Size(377, 26)
        Me.Txtmailsucu.TabIndex = 9
        '
        'TxtTelsucu
        '
        Me.TxtTelsucu.Location = New System.Drawing.Point(154, 166)
        Me.TxtTelsucu.Name = "TxtTelsucu"
        Me.TxtTelsucu.Size = New System.Drawing.Size(141, 26)
        Me.TxtTelsucu.TabIndex = 8
        '
        'Txtdirsucu
        '
        Me.Txtdirsucu.Location = New System.Drawing.Point(154, 122)
        Me.Txtdirsucu.Name = "Txtdirsucu"
        Me.Txtdirsucu.Size = New System.Drawing.Size(377, 26)
        Me.Txtdirsucu.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(87, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 20)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(64, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Telefono:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Direccion:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Descripción:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Codigo:"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(154, 78)
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(377, 26)
        Me.TxtDescripcion.TabIndex = 1
        '
        'Txtcodigo
        '
        Me.Txtcodigo.Enabled = False
        Me.Txtcodigo.Location = New System.Drawing.Point(154, 37)
        Me.Txtcodigo.Name = "Txtcodigo"
        Me.Txtcodigo.Size = New System.Drawing.Size(141, 26)
        Me.Txtcodigo.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DGVSucursal)
        Me.GroupBox3.Controls.Add(Me.TxtBuscarMarca)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 395)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(977, 358)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Listado de Sucursales:"
        '
        'DGVSucursal
        '
        Me.DGVSucursal.AllowUserToAddRows = False
        Me.DGVSucursal.AllowUserToDeleteRows = False
        Me.DGVSucursal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVSucursal.Location = New System.Drawing.Point(26, 98)
        Me.DGVSucursal.Name = "DGVSucursal"
        Me.DGVSucursal.ReadOnly = True
        Me.DGVSucursal.RowTemplate.Height = 28
        Me.DGVSucursal.Size = New System.Drawing.Size(930, 238)
        Me.DGVSucursal.TabIndex = 2
        '
        'TxtBuscarMarca
        '
        Me.TxtBuscarMarca.Location = New System.Drawing.Point(181, 45)
        Me.TxtBuscarMarca.Name = "TxtBuscarMarca"
        Me.TxtBuscarMarca.Size = New System.Drawing.Size(253, 26)
        Me.TxtBuscarMarca.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(31, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Buscar Sucursal :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_salir)
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.btn_guardar)
        Me.GroupBox1.Controls.Add(Me.btn_eliminar)
        Me.GroupBox1.Controls.Add(Me.btn_modificar)
        Me.GroupBox1.Controls.Add(Me.btn_nuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 10)
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
        'Frm_Sucursal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 765)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Sucursal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Sucursal"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGVSucursal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Txtcodigo As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DGVSucursal As DataGridView
    Friend WithEvents TxtBuscarMarca As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_modificar As Button
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents Txtmailsucu As TextBox
    Friend WithEvents TxtTelsucu As TextBox
    Friend WithEvents Txtdirsucu As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
