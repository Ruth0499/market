Public Class Frm_Empleados
    Dim objenti As New E_Empleado
    Dim objnego As New N_Empleado

#Region "Funciones y procedimientos "
    Public Sub grabar()
        Dim SEXO As String = ""
        If RB_M.Checked = True Then
            SEXO = "M"
        ElseIf RB_F.Checked = True Then
            SEXO = "F"
        End If
        objenti.apeemp = TXT_APE.Text.Trim
        objenti.nomemp = TXT_NOM.Text.Trim
        objenti.fecnac = DateTimePicker1.Value
        objenti.sexo = SEXO.ToString.Trim
        objenti.diremp = TXT_DIR.Text.Trim
        objenti.telemp = TXT_TLF.Text.Trim
        objenti.email = TXT_EMAIL.Text.Trim
        objenti.cargo = TXT_CARGO.Text.Trim

        Dim fac As String = objnego.n_Registrar(objenti)

        MsgBox("Se grabo exitosamente el nuevo empleado con el codigo: " + fac + " !!!", 32, "mensaje del sistema")
    End Sub

    Public Sub actualizar()
        Dim SEXO As String = ""
        If RB_M.Checked = True Then
            SEXO = "M"
        ElseIf RB_F.Checked = True Then
            SEXO = "F"
        End If
        objenti.codemp = TXT_COD.Text.Trim
        objenti.apeemp = TXT_APE.Text.Trim
        objenti.nomemp = TXT_NOM.Text.Trim
        objenti.fecnac = DateTimePicker1.Value
        objenti.sexo = SEXO.ToString.Trim
        objenti.diremp = TXT_DIR.Text.Trim
        objenti.telemp = TXT_TLF.Text.Trim
        objenti.email = TXT_EMAIL.Text.Trim
        objenti.cargo = TXT_CARGO.Text.Trim

        Dim fac As String = objnego.n_actualizar(objenti)

        MsgBox("Se Actualizo exitosamente el empleado con el codigo: " + fac + " !!!", 32, "mensaje del sistema")
    End Sub

    Public Sub eliminar()
        objenti.codemp = TXT_COD.Text.Trim
        Dim fac As String = objnego.N_eliminar_emp(objenti)
        MsgBox("Se Eliminó El Registro Correctamente : " + fac, MsgBoxStyle.Information)
    End Sub

    Public Sub limpiar()
        Dim CRT As New Control
        For Each CRT In Me.GroupBox1.Controls
            If TypeOf CRT Is TextBox Then
                CRT.Text = ""
            End If
        Next
        DateTimePicker1.Value = Now.Date
        RB_M.Checked = True

    End Sub

    Public Sub nuevo()
        'Dim CRT As New Control
        'For Each CRT In Me.GroupBox2.Controls
        '    If TypeOf CRT Is Button Then
        '        CRT.Enabled = True
        '    End If
        'Next
        'For Each CRT In Me.GroupBox1.Controls
        '    If TypeOf CRT Is TextBox Then
        '        CRT.Enabled = True
        '    End If
        '    If TypeOf CRT Is RadioButton Then
        '        CRT.Enabled = True
        '    End If
        'Next

        btn_nuevo.Enabled = False
        btn_modificar.Enabled = False
        btn_eliminar.Enabled = False
        btn_guardar.Enabled = True
        btn_cancelar.Enabled = True
        btn_salir.Enabled = False

        TXT_COD.Enabled = False
        DateTimePicker1.Enabled = True

    End Sub

    Public Sub deshabilitar()

        'Dim CRT As New Control

        'For Each CRT In Me.GroupBox2.Controls
        '    If TypeOf CRT Is Button Then
        '        CRT.Enabled = False
        '    End If
        'Next
        'For Each CRT In Me.GroupBox1.Controls
        '    If TypeOf CRT Is TextBox Then
        '        CRT.Enabled = False
        '    End If
        '    If TypeOf CRT Is RadioButton Then
        '        CRT.Enabled = False
        '    End If
        'Next
        DateTimePicker1.Enabled = False
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

    Public Sub cargar_emp()
        objenti.criterio = txt_busq_emp.Text.Trim
        Dim Tabla As DataTable = objnego.N_listar_emp(objenti)
        dgv_emp.DataSource = Tabla

    End Sub

    Public Sub RecuperarDatosGrilla()
        With dgv_emp.CurrentRow
            TXT_COD.Text = .Cells("Codigo").Value
            If IsDBNull(.Cells("apellidos").Value) Then TXT_APE.Text = "" Else TXT_APE.Text = .Cells("apellidos").Value
            If IsDBNull(.Cells("nombres").Value) Then TXT_NOM.Text = "" Else TXT_NOM.Text = .Cells("nombres").Value
            If IsDBNull(.Cells("Fec. Nac.").Value) Then DateTimePicker1.Value = "" Else DateTimePicker1.Value = .Cells("Fec. Nac.").Value
            'RB_M.Checked = True
            If IsDBNull(.Cells("Dirección").Value) Then TXT_DIR.Text = "" Else TXT_DIR.Text = .Cells("Dirección").Value
            If IsDBNull(.Cells("telefono").Value) Then TXT_TLF.Text = "" Else TXT_TLF.Text = .Cells("telefono").Value
            If IsDBNull(.Cells("email").Value) Then TXT_EMAIL.Text = "" Else TXT_EMAIL.Text = .Cells("email").Value
            If IsDBNull(.Cells("cargo").Value) Then TXT_CARGO.Text = "" Else TXT_CARGO.Text = .Cells("cargo").Value

        End With

    End Sub
    Private Function Validar() As Boolean

        If TXT_APE.Text = "" Then
            MsgBox("Ingrese Apellidos", MsgBoxStyle.Critical)
            TXT_APE.Focus()
            Return False
        End If
        If TXT_NOM.Text = "" Then
            MsgBox("Ingrese Nombres", MsgBoxStyle.Critical)
            TXT_NOM.Focus()
            Return False
        End If
        If RB_F.Checked = False And RB_M.Checked = False Then
            MsgBox("Seleccione una Opcion", MsgBoxStyle.Critical)
            RB_M.Focus()
            Return False
        End If
        If TXT_DIR.Text = "" Then
            MsgBox("Ingrese Una Direccion", MsgBoxStyle.Critical)
            TXT_DIR.Focus()
            Return False
        End If
        If TXT_TLF.Text = "" Then
            MsgBox("Ingrese Telefono", MsgBoxStyle.Critical)
            TXT_TLF.Focus()
            Return False
        End If
        If TXT_EMAIL.Text = "" Then
            MsgBox("Ingrese E-mail", MsgBoxStyle.Critical)
            TXT_EMAIL.Focus()
            Return False
        End If
        If TXT_CARGO.Text = "" Then
            MsgBox("Ingrese un Cargo", MsgBoxStyle.Critical)
            TXT_CARGO.Focus()
            Return False
        End If
        Return True
    End Function
#End Region

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        If MessageBox.Show("Esta seguro de Salir del Mant. De Empleados ",
                          "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                          MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Me.Close()
        Else
            MsgBox("Se Cancelo la operacion.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub btn_nuevo_Click_1(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        nuevo()
        limpiar()
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If TXT_COD.Text = "" Then
            MsgBox("Seleccione un Registro", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If Validar() = False Then
            Exit Sub
        End If

        actualizar()
        limpiar()
        cargar_emp()
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If TXT_COD.Text = "" Then
            MsgBox("Seleccione un Registro", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If MessageBox.Show("Esta seguro de Eliminar el Registro",
                           "Tutorial", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            eliminar()
            cargar_emp()
            deshabilitar()
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
        cargar_emp()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        CancelarGrabar()
        limpiar()
        deshabilitar()
    End Sub

    Private Sub txt_busq_emp_TextChanged(sender As Object, e As EventArgs) Handles txt_busq_emp.TextChanged
        cargar_emp()
    End Sub

    Private Sub dgv_emp_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_emp.CellClick
        RecuperarDatosGrilla()
    End Sub

    Private Sub Frm_Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_emp()
    End Sub
End Class