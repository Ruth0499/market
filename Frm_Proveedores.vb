Imports System.Data
Imports System.Data.SqlClient
Public Class Frm_Proveedores
    Dim cn As New SqlConnection("Data Source=191.1.70.92;Initial Catalog=BDMARKET;User ID=RetailUser;Password=retail")

    Dim objenti As New E_Proveedor
    Dim objnego As New N_Proveedor

#Region "Funciones y procedimientos "
    Public Sub grabar()
        objenti.desprov = TxtDescripcion.Text.Trim
        objenti.dirprov = Txtdirprov.Text.Trim
        objenti.tipdocprov = Cbo_tipoDocu.SelectedValue
        objenti.docuprov = TxtNumdoc.Text.Trim
        objenti.telprov = TxtTelprov.Text.Trim
        objenti.mailprov = Txtmailprov.Text.Trim

        Dim fac As String = objnego.n_Registrar(objenti)

        MsgBox("Se grabo exitosamente el nuevo proveedor con el codigo: " + fac + " !!!", 32, "mensaje del sistema")
    End Sub

    Public Sub actualizar()
        objenti.codprov = Txtcodigo.Text.Trim
        objenti.desprov = TxtDescripcion.Text.Trim
        objenti.dirprov = Txtdirprov.Text.Trim
        objenti.tipdocprov = Cbo_tipoDocu.SelectedValue
        objenti.docuprov = TxtNumdoc.Text.Trim
        objenti.telprov = TxtTelprov.Text.Trim
        objenti.mailprov = Txtmailprov.Text.Trim

        Dim fac As String = objnego.n_actualizar(objenti)

        MsgBox("Se Actualizo exitosamente la proveedor con el codigo: " + fac + " !!!", 32, "mensaje del sistema")
    End Sub

    Public Sub eliminar()
        objenti.codprov = Txtcodigo.Text.Trim
        Dim fac As String = objnego.N_eliminar_prov(objenti)
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

    Public Sub cargar_prov()
        objenti.criterio = TxtBuscarProveedor.Text.Trim
        Dim Tabla As DataTable = objnego.N_listar_prov(objenti)
        DGVProveedor.DataSource = Tabla
    End Sub

    Public Sub RecuperarDatosGrilla()
        With DGVProveedor.CurrentRow
            Txtcodigo.Text = .Cells("Codigo").Value
            If IsDBNull(.Cells("Descripcion").Value) Then TxtDescripcion.Text = "" Else TxtDescripcion.Text = .Cells("Descripcion").Value
            If IsDBNull(.Cells("Direccion").Value) Then Txtdirprov.Text = "" Else Txtdirprov.Text = .Cells("Direccion").Value
            If IsDBNull(.Cells("TipoDocumento").Value) Then Cbo_tipoDocu.Text = "" Else Cbo_tipoDocu.Text = .Cells("TipoDocumento").Value
            If IsDBNull(.Cells("NumDocumento").Value) Then TxtNumdoc.Text = "" Else TxtNumdoc.Text = .Cells("NumDocumento").Value
            If IsDBNull(.Cells("Telefono").Value) Then TxtTelprov.Text = "" Else TxtTelprov.Text = .Cells("Telefono").Value
            If IsDBNull(.Cells("Email").Value) Then Txtmailprov.Text = "" Else Txtmailprov.Text = .Cells("Email").Value
        End With

    End Sub

    Private Function Validar() As Boolean

        If TxtDescripcion.Text = "" Then
            MsgBox("Ingrese el Nombre", MsgBoxStyle.Critical)
            TxtDescripcion.Focus()
            Return False
        End If

        If Txtdirprov.Text = "" Then
            MsgBox("Ingrese la Dirección", MsgBoxStyle.Critical)
            Txtdirprov.Focus()
            Return False
        End If

        If Cbo_tipoDocu.Text = "" Then
            MsgBox("Seleccione Tipo de Documento", MsgBoxStyle.Critical)
            Cbo_tipoDocu.Focus()
            Return False
        End If

        If TxtNumdoc.Text = "" Then
            MsgBox("Ingrese Numero de Documento", MsgBoxStyle.Critical)
            TxtNumdoc.Focus()
            Return False
        End If

        Return True
    End Function

#End Region

    Public Sub CARGAR()
        Dim tabla As New DataTable
        Dim sql As String = "SELECT c_codi_tdoc, c_nomb_tdoc FROM sco_tipodocumento"
        Dim da As New SqlDataAdapter(sql, cn)
        da.Fill(tabla)

        Cbo_tipoDocu.DataSource = tabla
        Cbo_tipoDocu.DisplayMember = "c_nomb_tdoc"
        Cbo_tipoDocu.ValueMember = "c_codi_tdoc"

    End Sub

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
        cargar_prov()
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
            cargar_prov()
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
        cargar_prov()
        CancelarGrabar()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        CancelarGrabar()
        limpiar()
        'deshabilitar()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        If MessageBox.Show("Esta seguro de Salir del Mant. de Proveedores ",
            "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Me.Close()
        Else
            MsgBox("Se Cancelo la operacion.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub DGVMarca_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVProveedor.CellClick
        RecuperarDatosGrilla()
    End Sub

    Private Sub TxtBuscarProveedor_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarProveedor.TextChanged
        cargar_prov()
    End Sub

    Private Sub Frm_Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CARGAR()
        cargar_prov()
    End Sub

    Private Sub Cbo_tipoDocu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbo_tipoDocu.SelectedIndexChanged
        TxtNumdoc.Focus()
        'Cbo_tipoDocu.Refresh()
    End Sub

End Class