Public Class Frm_Sucursal

    Dim objenti As New E_Sucursal
    Dim objnego As New N_Sucursal

#Region "Funciones y procedimientos "
    Public Sub grabar()
        objenti.dessucu = TxtDescripcion.Text.Trim
        objenti.dirsucu = Txtdirsucu.Text.Trim
        objenti.telsucu = TxtTelsucu.Text.Trim
        objenti.mailsucu = Txtmailsucu.Text.Trim

        Dim fac As String = objnego.n_Registrar(objenti)

        MsgBox("Se grabo exitosamente el nueva sucursal con el codigo: " + fac + " !!!", 32, "mensaje del sistema")
    End Sub

    Public Sub actualizar()
        objenti.codsucu = Txtcodigo.Text.Trim
        objenti.dessucu = TxtDescripcion.Text.Trim
        objenti.dirsucu = Txtdirsucu.Text.Trim
        objenti.telsucu = TxtTelsucu.Text.Trim
        objenti.mailsucu = Txtmailsucu.Text.Trim

        Dim fac As String = objnego.n_actualizar(objenti)

        MsgBox("Se Actualizo exitosamente la sucursal con el codigo: " + fac + " !!!", 32, "mensaje del sistema")
    End Sub

    Public Sub eliminar()
        objenti.codsucu = Txtcodigo.Text.Trim
        Dim fac As String = objnego.N_eliminar_sucu(objenti)
        MsgBox("Se Eliminó El Registro Correctamente : " + fac, MsgBoxStyle.Information)
    End Sub

    Public Sub limpiar()
        Dim CRT As New Control
        For Each CRT In Me.GroupBox2.Controls
            If TypeOf CRT Is TextBox Then
                CRT.Text = ""
            End If
        Next
        'DateTimePicker1.Value = Now.Date
        'RB_M.Checked = True

    End Sub

    Public Sub nuevo()
        'Dim CRT As New Control
        'For Each CRT In Me.GroupBox1.Controls
        '    If TypeOf CRT Is Button Then
        '        CRT.Enabled = True
        '    End If
        'Next
        'For Each CRT In Me.GroupBox2.Controls
        '    If TypeOf CRT Is TextBox Then
        '        CRT.Enabled = True
        '    End If
        '    'If TypeOf CRT Is RadioButton Then
        '    '    CRT.Enabled = True
        '    'End If
        'Next
        'Txtcodigo.Enabled = False
        'DateTimePicker1.Enabled = True

        btn_nuevo.Enabled = False
        btn_modificar.Enabled = False
        btn_eliminar.Enabled = False
        btn_guardar.Enabled = True
        btn_cancelar.Enabled = True
        btn_salir.Enabled = False

        Txtcodigo.Enabled = False
        TxtDescripcion.Focus()

    End Sub

    Public Sub deshabilitar()

        Dim CRT As New Control

        For Each CRT In Me.GroupBox1.Controls
            If TypeOf CRT Is Button Then
                CRT.Enabled = False
            End If
        Next
        For Each CRT In Me.GroupBox2.Controls
            If TypeOf CRT Is TextBox Then
                CRT.Enabled = False
            End If
            If TypeOf CRT Is RadioButton Then
                CRT.Enabled = False
            End If
        Next
        'DateTimePicker1.Enabled = False
        btn_nuevo.Enabled = True

    End Sub

    Private Sub CancelarGrabar()
        btn_nuevo.Enabled = True
        btn_modificar.Enabled = True
        btn_eliminar.Enabled = True
        btn_guardar.Enabled = False
        btn_cancelar.Enabled = False
        btn_salir.Enabled = True
    End Sub

    Public Sub cargar_sucu()
        objenti.criterio = TxtBuscarMarca.Text.Trim
        Dim Tabla As DataTable = objnego.N_listar_sucu(objenti)
        DGVSucursal.DataSource = Tabla
    End Sub

    Public Sub RecuperarDatosGrilla()
        With DGVSucursal.CurrentRow
            Txtcodigo.Text = .Cells("Codigo").Value
            If IsDBNull(.Cells("Descripcion").Value) Then TxtDescripcion.Text = "" Else TxtDescripcion.Text = .Cells("Descripcion").Value
            If IsDBNull(.Cells("Direccion").Value) Then Txtdirsucu.Text = "" Else Txtdirsucu.Text = .Cells("Direccion").Value
            If IsDBNull(.Cells("Telefono").Value) Then TxtTelsucu.Text = "" Else TxtTelsucu.Text = .Cells("Telefono").Value
            If IsDBNull(.Cells("Email").Value) Then Txtmailsucu.Text = "" Else Txtmailsucu.Text = .Cells("Email").Value
        End With

    End Sub

    Private Function Validar() As Boolean

        If TxtDescripcion.Text = "" Then
            MsgBox("Ingrese Descripcion", MsgBoxStyle.Critical)
            TxtDescripcion.Focus()
            Return False
        End If

        If Txtdirsucu.Text = "" Then
            MsgBox("Ingrese Dirección", MsgBoxStyle.Critical)
            Txtdirsucu.Focus()
            Return False
        End If

        Return True
    End Function

#End Region

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        nuevo()
        limpiar()
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If Txtcodigo.Text = "" Then
            MsgBox("Seleccione un Registro", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If Validar() = False Then
            Exit Sub
        End If

        actualizar()
        limpiar()
        cargar_sucu()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If Txtcodigo.Text = "" Then
            MsgBox("Seleccione un Registro", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           "Tutorial", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            eliminar()
            cargar_sucu()
            'deshabilitar()
            limpiar()
        Else
            MsgBox("Error al Eliminar", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If Validar() = False Then
            Exit Sub
        End If
        grabar()
        limpiar()
        cargar_sucu()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        CancelarGrabar()
        limpiar()
        'deshabilitar()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        If MessageBox.Show("Esta seguro de Salir del Mant. De Sucursal ",
            "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Me.Close()
        Else
            MsgBox("Se Cancelo la operacion.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub TxtBuscarMarca_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarMarca.TextChanged
        cargar_sucu()
    End Sub

    Private Sub DGVSucursal_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSucursal.CellClick
        RecuperarDatosGrilla()
    End Sub

    Private Sub Frm_Sucursal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_sucu()
    End Sub

    Private Sub DGVSucursal_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVSucursal.CellContentClick

    End Sub
End Class