<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ConsProveedor
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.grd_listar = New System.Windows.Forms.DataGridView()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.txtdato = New System.Windows.Forms.TextBox()
        Me.btn_salir = New System.Windows.Forms.Button()
        CType(Me.grd_listar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grd_listar
        '
        Me.grd_listar.AllowUserToAddRows = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.grd_listar.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.grd_listar.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.grd_listar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        Me.grd_listar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.Brown
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grd_listar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.grd_listar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grd_listar.EnableHeadersVisualStyles = False
        Me.grd_listar.Location = New System.Drawing.Point(9, 42)
        Me.grd_listar.Name = "grd_listar"
        Me.grd_listar.RowHeadersVisible = False
        Me.grd_listar.Size = New System.Drawing.Size(680, 255)
        Me.grd_listar.TabIndex = 20
        '
        'btn_buscar
        '
        Me.btn_buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_buscar.Location = New System.Drawing.Point(201, 5)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(119, 29)
        Me.btn_buscar.TabIndex = 19
        Me.btn_buscar.Text = "Buscar"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'txtdato
        '
        Me.txtdato.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdato.Location = New System.Drawing.Point(9, 8)
        Me.txtdato.MaxLength = 30
        Me.txtdato.Name = "txtdato"
        Me.txtdato.Size = New System.Drawing.Size(186, 24)
        Me.txtdato.TabIndex = 18
        '
        'btn_salir
        '
        Me.btn_salir.Image = Global.WAMarketCasaBlanca.My.Resources.Resources.Custom_Icon_Design_Pretty_Office_7_Generate_keys
        Me.btn_salir.Location = New System.Drawing.Point(596, 8)
        Me.btn_salir.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_salir.Name = "btn_salir"
        Me.btn_salir.Size = New System.Drawing.Size(92, 29)
        Me.btn_salir.TabIndex = 21
        Me.btn_salir.Text = "Salir"
        Me.btn_salir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_salir.UseVisualStyleBackColor = True
        '
        'Frm_ConsProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 302)
        Me.Controls.Add(Me.btn_salir)
        Me.Controls.Add(Me.grd_listar)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.txtdato)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_ConsProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Proveedores"
        CType(Me.grd_listar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grd_listar As DataGridView
    Friend WithEvents btn_buscar As Button
    Friend WithEvents txtdato As TextBox
    Friend WithEvents btn_salir As Button
End Class
