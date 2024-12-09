<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ConsProducto
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grd_listar = New System.Windows.Forms.DataGridView()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txtdato = New System.Windows.Forms.TextBox()
        Me.btn_salir = New System.Windows.Forms.Button()
        Me.Cbo_TipoStk = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.grd_listar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_listar
        '
        Me.grd_listar.AllowUserToAddRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.grd_listar.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grd_listar.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grd_listar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.grd_listar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Brown
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_listar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.grd_listar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_listar.EnableHeadersVisualStyles = False
        Me.grd_listar.Location = New System.Drawing.Point(13, 66)
        Me.grd_listar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.grd_listar.Name = "grd_listar"
        Me.grd_listar.RowHeadersVisible = False
        Me.grd_listar.Size = New System.Drawing.Size(1020, 392)
        Me.grd_listar.TabIndex = 25
        '
        'btn_buscar
        '
        Me.btn_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.Location = New System.Drawing.Point(640, 10)
        Me.btn_buscar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(178, 45)
        Me.btn_buscar.TabIndex = 24
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'txtdato
        '
        Me.txtdato.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdato.Location = New System.Drawing.Point(115, 14)
        Me.txtdato.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtdato.MaxLength = 30
        Me.txtdato.Name = "txtdato"
        Me.txtdato.Size = New System.Drawing.Size(267, 33)
        Me.txtdato.TabIndex = 23
        '
        'btn_salir
        '
        Me.btn_salir.Image = Global.WAMarketCasaBlanca.My.Resources.Resources.Custom_Icon_Design_Pretty_Office_7_Generate_keys
        Me.btn_salir.Location = New System.Drawing.Point(895, 10)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(138, 45)
        Me.btn_salir.TabIndex = 26
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'Cbo_TipoStk
        '
        Me.Cbo_TipoStk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cbo_TipoStk.FormattingEnabled = True
        Me.Cbo_TipoStk.Location = New System.Drawing.Point(484, 19)
        Me.Cbo_TipoStk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Cbo_TipoStk.Name = "Cbo_TipoStk"
        Me.Cbo_TipoStk.Size = New System.Drawing.Size(148, 28)
        Me.Cbo_TipoStk.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(389, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Tipo Stock:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 20)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Descripcion:"
        '
        'Frm_ConsProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 461)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Cbo_TipoStk)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.grd_listar)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.txtdato)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_ConsProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Productos"
        CType(Me.grd_listar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_salir As Button
    Friend WithEvents grd_listar As DataGridView
    Friend WithEvents btn_buscar As Button
    Friend WithEvents txtdato As TextBox
    Friend WithEvents Cbo_TipoStk As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
