<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_CuadreCaja
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DGVMarca = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.BTNIMPRIMIR = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGVMarca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BTNIMPRIMIR)
        Me.GroupBox2.Controls.Add(Me.btn_salir)
        Me.GroupBox2.Controls.Add(Me.btn_guardar)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(622, 102)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nro. Caja:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(128, 22)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox1.TabIndex = 2
        Me.ComboBox1.Text = "01"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(128, 59)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(121, 26)
        Me.DateTimePicker1.TabIndex = 8
        '
        'DGVMarca
        '
        Me.DGVMarca.AllowUserToAddRows = False
        Me.DGVMarca.AllowUserToDeleteRows = False
        Me.DGVMarca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMarca.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.DGVMarca.Location = New System.Drawing.Point(12, 129)
        Me.DGVMarca.Name = "DGVMarca"
        Me.DGVMarca.ReadOnly = True
        Me.DGVMarca.RowTemplate.Height = 28
        Me.DGVMarca.Size = New System.Drawing.Size(622, 264)
        Me.DGVMarca.TabIndex = 15
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WAMarketCasaBlanca.My.Resources.Resources.CajaVenta
        Me.PictureBox1.Location = New System.Drawing.Point(653, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(239, 428)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'btn_guardar
        '
        Me.btn_guardar.Image = Global.WAMarketCasaBlanca.My.Resources.Resources.Gakuseisean_Ivista_2_Misc_New_Database1
        Me.btn_guardar.Location = New System.Drawing.Point(266, 11)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(90, 85)
        Me.btn_guardar.TabIndex = 9
        Me.btn_guardar.Text = "Consultar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_salir
        '
        Me.btn_salir.Image = Global.WAMarketCasaBlanca.My.Resources.Resources.Custom_Icon_Design_Pretty_Office_7_Generate_keys
        Me.btn_salir.Location = New System.Drawing.Point(527, 11)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(90, 85)
        Me.btn_salir.TabIndex = 10
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'BTNIMPRIMIR
        '
        Me.BTNIMPRIMIR.Image = Global.WAMarketCasaBlanca.My.Resources.Resources.Delacro_Id_Printer
        Me.BTNIMPRIMIR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTNIMPRIMIR.Location = New System.Drawing.Point(365, 22)
        Me.BTNIMPRIMIR.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.BTNIMPRIMIR.Name = "BTNIMPRIMIR"
        Me.BTNIMPRIMIR.Size = New System.Drawing.Size(153, 62)
        Me.BTNIMPRIMIR.TabIndex = 16
        Me.BTNIMPRIMIR.Text = "     Imprimir"
        Me.BTNIMPRIMIR.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(405, 413)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Total Sistema:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(529, 407)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 30)
        Me.TextBox1.TabIndex = 17
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Medio de Pago"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Moneda"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Imp. Pago"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Tipo Cambio"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Total Pagado"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Frm_CuadreCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(905, 452)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DGVMarca)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_CuadreCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuadre de Caja"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGVMarca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DGVMarca As DataGridView
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents BTNIMPRIMIR As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
