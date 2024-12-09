<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_UnidadMedida
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.Txtcodigo = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.DGVMarca = New System.Windows.Forms.DataGridView()
        Me.TxtBuscarUnidadMedida = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_cancelar = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGVMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TxtDescripcion)
        Me.GroupBox2.Controls.Add(Me.Txtcodigo)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 141)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(626, 127)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Unidad Medida:"
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
        Me.TxtDescripcion.Location = New System.Drawing.Point(154, 81)
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
        Me.GroupBox3.Controls.Add(Me.DGVMarca)
        Me.GroupBox3.Controls.Add(Me.TxtBuscarUnidadMedida)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 274)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(626, 358)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Listado de Unidad Medida:"
        '
        'DGVMarca
        '
        Me.DGVMarca.AllowUserToAddRows = False
        Me.DGVMarca.AllowUserToDeleteRows = False
        Me.DGVMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMarca.Location = New System.Drawing.Point(32, 98)
        Me.DGVMarca.Name = "DGVMarca"
        Me.DGVMarca.ReadOnly = True
        Me.DGVMarca.RowTemplate.Height = 28
        Me.DGVMarca.Size = New System.Drawing.Size(559, 238)
        Me.DGVMarca.TabIndex = 2
        '
        'TxtBuscarUnidadMedida
        '
        Me.TxtBuscarUnidadMedida.Location = New System.Drawing.Point(238, 49)
        Me.TxtBuscarUnidadMedida.Name = "TxtBuscarUnidadMedida"
        Me.TxtBuscarUnidadMedida.Size = New System.Drawing.Size(253, 26)
        Me.TxtBuscarUnidadMedida.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(54, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(178, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Buscar Unidad Medida :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_salir)
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.btn_guardar)
        Me.GroupBox1.Controls.Add(Me.btn_eliminar)
        Me.GroupBox1.Controls.Add(Me.btn_modificar)
        Me.GroupBox1.Controls.Add(Me.btn_nuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
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
        Me.PictureBox1.Image = Global.WAMarketCasaBlanca.My.Resources.Resources.UnidadMedida
        Me.PictureBox1.Location = New System.Drawing.Point(644, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(352, 569)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Frm_UnidadMedida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 639)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_UnidadMedida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Unidad de Medida"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGVMarca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtDescripcion As TextBox
    Friend WithEvents Txtcodigo As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DGVMarca As DataGridView
    Friend WithEvents TxtBuscarUnidadMedida As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_modificar As Button
    Friend WithEvents btn_nuevo As Button
End Class
