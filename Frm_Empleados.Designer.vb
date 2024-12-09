<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Empleados
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
        Me.dgv_emp = New System.Windows.Forms.DataGridView()
        Me.txt_busq_emp = New System.Windows.Forms.TextBox()
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
        Me.TXT_COD = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXT_CARGO = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_EMAIL = New System.Windows.Forms.TextBox()
        Me.RB_F = New System.Windows.Forms.RadioButton()
        Me.RB_M = New System.Windows.Forms.RadioButton()
        Me.TXT_TLF = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TXT_DIR = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXT_APE = New System.Windows.Forms.TextBox()
        Me.TXT_NOM = New System.Windows.Forms.TextBox()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_emp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgv_emp)
        Me.GroupBox3.Controls.Add(Me.txt_busq_emp)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 378)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(984, 214)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Listado de Empleado:"
        '
        'dgv_emp
        '
        Me.dgv_emp.AllowUserToAddRows = False
        Me.dgv_emp.AllowUserToDeleteRows = False
        Me.dgv_emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_emp.Location = New System.Drawing.Point(15, 63)
        Me.dgv_emp.Name = "dgv_emp"
        Me.dgv_emp.ReadOnly = True
        Me.dgv_emp.RowTemplate.Height = 28
        Me.dgv_emp.Size = New System.Drawing.Size(963, 145)
        Me.dgv_emp.TabIndex = 2
        '
        'txt_busq_emp
        '
        Me.txt_busq_emp.Location = New System.Drawing.Point(189, 26)
        Me.txt_busq_emp.Name = "txt_busq_emp"
        Me.txt_busq_emp.Size = New System.Drawing.Size(253, 26)
        Me.txt_busq_emp.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Buscar Empleado :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_salir)
        Me.GroupBox1.Controls.Add(Me.btn_cancelar)
        Me.GroupBox1.Controls.Add(Me.btn_guardar)
        Me.GroupBox1.Controls.Add(Me.btn_eliminar)
        Me.GroupBox1.Controls.Add(Me.btn_modificar)
        Me.GroupBox1.Controls.Add(Me.btn_nuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(642, 123)
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WAMarketCasaBlanca.My.Resources.Resources.Empleado
        Me.PictureBox1.Location = New System.Drawing.Point(658, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(334, 349)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TXT_COD)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TXT_CARGO)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TXT_EMAIL)
        Me.GroupBox2.Controls.Add(Me.RB_F)
        Me.GroupBox2.Controls.Add(Me.RB_M)
        Me.GroupBox2.Controls.Add(Me.TXT_TLF)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TXT_DIR)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TXT_APE)
        Me.GroupBox2.Controls.Add(Me.TXT_NOM)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 134)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.GroupBox2.Size = New System.Drawing.Size(642, 238)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos Empleado"
        '
        'TXT_COD
        '
        Me.TXT_COD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_COD.Enabled = False
        Me.TXT_COD.Location = New System.Drawing.Point(112, 26)
        Me.TXT_COD.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TXT_COD.Name = "TXT_COD"
        Me.TXT_COD.Size = New System.Drawing.Size(150, 26)
        Me.TXT_COD.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(411, 23)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Cargo :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(274, 197)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "E-mail:"
        '
        'TXT_CARGO
        '
        Me.TXT_CARGO.Location = New System.Drawing.Point(482, 18)
        Me.TXT_CARGO.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TXT_CARGO.Name = "TXT_CARGO"
        Me.TXT_CARGO.Size = New System.Drawing.Size(150, 26)
        Me.TXT_CARGO.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 191)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Telefono :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 149)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Direccion :"
        '
        'TXT_EMAIL
        '
        Me.TXT_EMAIL.Location = New System.Drawing.Point(336, 192)
        Me.TXT_EMAIL.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TXT_EMAIL.Name = "TXT_EMAIL"
        Me.TXT_EMAIL.Size = New System.Drawing.Size(298, 26)
        Me.TXT_EMAIL.TabIndex = 5
        '
        'RB_F
        '
        Me.RB_F.AutoSize = True
        Me.RB_F.Location = New System.Drawing.Point(528, 103)
        Me.RB_F.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.RB_F.Name = "RB_F"
        Me.RB_F.Size = New System.Drawing.Size(105, 24)
        Me.RB_F.TabIndex = 9
        Me.RB_F.TabStop = True
        Me.RB_F.Text = "Femenino"
        Me.RB_F.UseVisualStyleBackColor = True
        '
        'RB_M
        '
        Me.RB_M.AutoSize = True
        Me.RB_M.Location = New System.Drawing.Point(417, 103)
        Me.RB_M.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.RB_M.Name = "RB_M"
        Me.RB_M.Size = New System.Drawing.Size(105, 24)
        Me.RB_M.TabIndex = 8
        Me.RB_M.TabStop = True
        Me.RB_M.Text = "Masculino"
        Me.RB_M.UseVisualStyleBackColor = True
        '
        'TXT_TLF
        '
        Me.TXT_TLF.Location = New System.Drawing.Point(112, 191)
        Me.TXT_TLF.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TXT_TLF.Name = "TXT_TLF"
        Me.TXT_TLF.Size = New System.Drawing.Size(150, 26)
        Me.TXT_TLF.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 109)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fec. Nac. :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(333, 68)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombres: "
        '
        'TXT_DIR
        '
        Me.TXT_DIR.Location = New System.Drawing.Point(112, 149)
        Me.TXT_DIR.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TXT_DIR.Name = "TXT_DIR"
        Me.TXT_DIR.Size = New System.Drawing.Size(520, 26)
        Me.TXT_DIR.TabIndex = 3
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(112, 106)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(150, 26)
        Me.DateTimePicker1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellidos:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(34, 29)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 20)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Codigo :"
        '
        'TXT_APE
        '
        Me.TXT_APE.Location = New System.Drawing.Point(112, 63)
        Me.TXT_APE.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TXT_APE.Name = "TXT_APE"
        Me.TXT_APE.Size = New System.Drawing.Size(216, 26)
        Me.TXT_APE.TabIndex = 0
        '
        'TXT_NOM
        '
        Me.TXT_NOM.Location = New System.Drawing.Point(417, 63)
        Me.TXT_NOM.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.TXT_NOM.Name = "TXT_NOM"
        Me.TXT_NOM.Size = New System.Drawing.Size(216, 26)
        Me.TXT_NOM.TabIndex = 1
        '
        'Frm_Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 595)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_Empleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Empleados"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgv_emp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents dgv_emp As DataGridView
    Friend WithEvents txt_busq_emp As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_cancelar As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents btn_modificar As Button
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TXT_COD As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TXT_CARGO As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_EMAIL As TextBox
    Friend WithEvents RB_F As RadioButton
    Friend WithEvents RB_M As RadioButton
    Friend WithEvents TXT_TLF As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TXT_DIR As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TXT_APE As TextBox
    Friend WithEvents TXT_NOM As TextBox
End Class
