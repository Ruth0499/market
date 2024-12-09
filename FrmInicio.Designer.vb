<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInicio
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GBILOAD = New System.Windows.Forms.GroupBox()
        Me.LBLMENSAJE = New System.Windows.Forms.Label()
        Me.PGB1 = New System.Windows.Forms.ProgressBar()
        Me.cmdcancelar = New System.Windows.Forms.Button()
        Me.cmdingresar = New System.Windows.Forms.Button()
        Me.txtclave = New System.Windows.Forms.TextBox()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.cbotipousuario = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GBILOAD.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GBILOAD)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(766, 317)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Inicio"
        '
        'GBILOAD
        '
        Me.GBILOAD.Controls.Add(Me.LBLMENSAJE)
        Me.GBILOAD.Controls.Add(Me.PGB1)
        Me.GBILOAD.Controls.Add(Me.cmdcancelar)
        Me.GBILOAD.Controls.Add(Me.cmdingresar)
        Me.GBILOAD.Controls.Add(Me.txtclave)
        Me.GBILOAD.Controls.Add(Me.txtusuario)
        Me.GBILOAD.Controls.Add(Me.cbotipousuario)
        Me.GBILOAD.Controls.Add(Me.Label3)
        Me.GBILOAD.Controls.Add(Me.Label2)
        Me.GBILOAD.Controls.Add(Me.Label1)
        Me.GBILOAD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBILOAD.Location = New System.Drawing.Point(346, 25)
        Me.GBILOAD.Name = "GBILOAD"
        Me.GBILOAD.Size = New System.Drawing.Size(402, 285)
        Me.GBILOAD.TabIndex = 1
        Me.GBILOAD.TabStop = False
        Me.GBILOAD.Text = "Login"
        '
        'LBLMENSAJE
        '
        Me.LBLMENSAJE.AutoSize = True
        Me.LBLMENSAJE.BackColor = System.Drawing.Color.Transparent
        Me.LBLMENSAJE.ForeColor = System.Drawing.Color.Maroon
        Me.LBLMENSAJE.Location = New System.Drawing.Point(100, 246)
        Me.LBLMENSAJE.Name = "LBLMENSAJE"
        Me.LBLMENSAJE.Size = New System.Drawing.Size(76, 20)
        Me.LBLMENSAJE.TabIndex = 9
        Me.LBLMENSAJE.Text = "Mensaje"
        '
        'PGB1
        '
        Me.PGB1.BackColor = System.Drawing.Color.Gainsboro
        Me.PGB1.Location = New System.Drawing.Point(0, 234)
        Me.PGB1.Name = "PGB1"
        Me.PGB1.Size = New System.Drawing.Size(402, 45)
        Me.PGB1.TabIndex = 8
        '
        'cmdcancelar
        '
        Me.cmdcancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdcancelar.Location = New System.Drawing.Point(254, 182)
        Me.cmdcancelar.Name = "cmdcancelar"
        Me.cmdcancelar.Size = New System.Drawing.Size(123, 48)
        Me.cmdcancelar.TabIndex = 7
        Me.cmdcancelar.Text = "Cancelar"
        Me.cmdcancelar.UseVisualStyleBackColor = True
        '
        'cmdingresar
        '
        Me.cmdingresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdingresar.Location = New System.Drawing.Point(124, 182)
        Me.cmdingresar.Name = "cmdingresar"
        Me.cmdingresar.Size = New System.Drawing.Size(123, 48)
        Me.cmdingresar.TabIndex = 6
        Me.cmdingresar.Text = "Ingresar"
        Me.cmdingresar.UseVisualStyleBackColor = True
        '
        'txtclave
        '
        Me.txtclave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclave.Location = New System.Drawing.Point(142, 132)
        Me.txtclave.Name = "txtclave"
        Me.txtclave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtclave.Size = New System.Drawing.Size(234, 30)
        Me.txtclave.TabIndex = 5
        '
        'txtusuario
        '
        Me.txtusuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusuario.Location = New System.Drawing.Point(142, 78)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(234, 30)
        Me.txtusuario.TabIndex = 4
        '
        'cbotipousuario
        '
        Me.cbotipousuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbotipousuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbotipousuario.FormattingEnabled = True
        Me.cbotipousuario.Location = New System.Drawing.Point(142, 29)
        Me.cbotipousuario.Name = "cbotipousuario"
        Me.cbotipousuario.Size = New System.Drawing.Size(234, 33)
        Me.cbotipousuario.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contraseña:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(62, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Usuario:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo Usuario:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WAMarketCasaBlanca.My.Resources.Resources.SantoDomingo
        Me.PictureBox1.Location = New System.Drawing.Point(6, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(326, 285)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'FrmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(790, 334)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmInicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar Sesion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GBILOAD.ResumeLayout(False)
        Me.GBILOAD.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GBILOAD As GroupBox
    Friend WithEvents cmdcancelar As Button
    Friend WithEvents cmdingresar As Button
    Friend WithEvents txtclave As TextBox
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents cbotipousuario As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PGB1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents LBLMENSAJE As Label
End Class
