<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_AperCaja
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtFonIni = New System.Windows.Forms.TextBox()
        Me.Lbl_fecape = New System.Windows.Forms.Label()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Lbl_nrocaja = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_salir)
        Me.GroupBox1.Controls.Add(Me.btn_guardar)
        Me.GroupBox1.Location = New System.Drawing.Point(592, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(124, 249)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(272, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Fecha Apertura:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(298, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 25)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Fondo Inicial:"
        '
        'TxtFonIni
        '
        Me.TxtFonIni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFonIni.Location = New System.Drawing.Point(453, 182)
        Me.TxtFonIni.Name = "TxtFonIni"
        Me.TxtFonIni.Size = New System.Drawing.Size(117, 35)
        Me.TxtFonIni.TabIndex = 9
        Me.TxtFonIni.Text = "0.00"
        Me.TxtFonIni.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Lbl_fecape
        '
        Me.Lbl_fecape.AutoSize = True
        Me.Lbl_fecape.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_fecape.Location = New System.Drawing.Point(448, 127)
        Me.Lbl_fecape.Name = "Lbl_fecape"
        Me.Lbl_fecape.Size = New System.Drawing.Size(122, 25)
        Me.Lbl_fecape.TabIndex = 10
        Me.Lbl_fecape.Text = "10/07/2023"
        '
        'btn_salir
        '
        Me.btn_salir.Image = Global.WAMarketCasaBlanca.My.Resources.Resources.Custom_Icon_Design_Pretty_Office_7_Generate_keys
        Me.btn_salir.Location = New System.Drawing.Point(18, 135)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(90, 95)
        Me.btn_salir.TabIndex = 5
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'btn_guardar
        '
        Me.btn_guardar.Image = Global.WAMarketCasaBlanca.My.Resources.Resources.Ampeross_Ampola_Floppy_drive_3_12
        Me.btn_guardar.Location = New System.Drawing.Point(18, 22)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(90, 95)
        Me.btn_guardar.TabIndex = 3
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WAMarketCasaBlanca.My.Resources.Resources.CajaVenta
        Me.PictureBox1.Location = New System.Drawing.Point(12, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(239, 238)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Lbl_nrocaja)
        Me.GroupBox2.Location = New System.Drawing.Point(257, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(329, 83)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'Lbl_nrocaja
        '
        Me.Lbl_nrocaja.AutoSize = True
        Me.Lbl_nrocaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_nrocaja.Location = New System.Drawing.Point(74, 33)
        Me.Lbl_nrocaja.Name = "Lbl_nrocaja"
        Me.Lbl_nrocaja.Size = New System.Drawing.Size(171, 37)
        Me.Lbl_nrocaja.TabIndex = 7
        Me.Lbl_nrocaja.Text = "CAJA - 01"
        '
        'Frm_AperCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(722, 275)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Lbl_fecape)
        Me.Controls.Add(Me.TxtFonIni)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_AperCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Apertura de Caja"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_salir As Button
    Friend WithEvents btn_guardar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtFonIni As TextBox
    Friend WithEvents Lbl_fecape As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Lbl_nrocaja As Label
End Class
