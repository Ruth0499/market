Imports System.Data
Imports System.Data.SqlClient
Public Class Frm_productos

    Dim cn As New SqlConnection("Data Source=191.1.70.92;Initial Catalog=BDMARKET;User ID=RetailUser;Password=retail")

    Dim objenti As New E_Producto
    Dim objnego As New N_Producto

#Region "Funciones y procedimientos "
    Public Sub grabar()
        objenti.desprod = TxtDescripcion.Text.Trim
        objenti.barprod = Txtcodbar.Text.Trim
        objenti.pcosprod = Txtprecos.Text.Trim
        objenti.pvenprod = Txtpreven.Text.Trim
        objenti.codcatprod = Cbo_categoria.SelectedValue
        objenti.codmarprod = Cbo_marca.SelectedValue
        objenti.unimedprod = Cbo_unimed.SelectedValue
        objenti.stkprod = Txtstock.Text.Trim

        Dim fac As String = objnego.n_Registrar(objenti)

        MsgBox("Se grabo exitosamente el nuevo producto con el codigo: " + fac + " !!!", 32, "mensaje del sistema")
    End Sub

    Public Sub actualizar()
        objenti.codprod = Txtcodigo.Text.Trim
        objenti.desprod = TxtDescripcion.Text.Trim
        objenti.barprod = Txtcodbar.Text.Trim
        objenti.pcosprod = Txtprecos.Text.Trim
        objenti.pvenprod = Txtpreven.Text.Trim
        objenti.codcatprod = Cbo_categoria.SelectedValue
        objenti.codmarprod = Cbo_marca.SelectedValue
        objenti.unimedprod = Cbo_unimed.SelectedValue
        objenti.stkprod = Txtstock.Text.Trim

        Dim fac As String = objnego.n_actualizar(objenti)

        MsgBox("Se Actualizo exitosamente el producto con el codigo: " + fac + " !!!", 32, "mensaje del sistema")
    End Sub

    Public Sub eliminar()
        objenti.codprod = Txtcodigo.Text.Trim
        Dim fac As String = objnego.N_eliminar_prod(objenti)
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

    Public Sub cargar_prod()
        objenti.criterio = TxtBuscarProducto.Text.Trim
        Dim Tabla As DataTable = objnego.N_listar_prod(objenti)
        DGVProducto.DataSource = Tabla
    End Sub

    Public Sub RecuperarDatosGrilla()
        With DGVProducto.CurrentRow
            Txtcodigo.Text = .Cells("Codigo").Value
            If IsDBNull(.Cells("Descripcion").Value) Then TxtDescripcion.Text = "" Else TxtDescripcion.Text = .Cells("Descripcion").Value
            If IsDBNull(.Cells("CodBarra").Value) Then Txtcodbar.Text = "" Else Txtcodbar.Text = .Cells("CodBarra").Value
            If IsDBNull(.Cells("P.Costo").Value) Then Txtprecos.Text = "" Else Txtprecos.Text = .Cells("P.Costo").Value
            If IsDBNull(.Cells("P.venta").Value) Then Txtpreven.Text = "" Else Txtpreven.Text = .Cells("P.venta").Value
            'If IsDBNull(.Cells("CodCategoria").Value) Then Txtdirprod.Text = "" Else Txtdirprod.Text = .Cells("CodCategoria").Value
            If IsDBNull(.Cells("NombreCategoria").Value) Then Cbo_categoria.Text = "" Else Cbo_categoria.Text = .Cells("NombreCategoria").Value
            'If IsDBNull(.Cells("CodMarca").Value) Then Txtdirprod.Text = "" Else Txtdirprod.Text = .Cells("CodMarca").Value
            If IsDBNull(.Cells("NombreMarca").Value) Then Cbo_marca.Text = "" Else Cbo_marca.Text = .Cells("NombreMarca").Value
            'If IsDBNull(.Cells("CodUmedida").Value) Then Txtdirprod.Text = "" Else Txtdirprod.Text = .Cells("CodUmedida").Value
            If IsDBNull(.Cells("NombreUMedida").Value) Then Cbo_unimed.Text = "" Else Cbo_unimed.Text = .Cells("NombreUMedida").Value
            If IsDBNull(.Cells("Stock").Value) Then Txtstock.Text = "" Else Txtstock.Text = .Cells("Stock").Value
            If IsDBNull(.Cells("Stockmin").Value) Then Txtstockmin.Text = "" Else Txtstockmin.Text = .Cells("Stockmin").Value
            If IsDBNull(.Cells("Stockmax").Value) Then Txtstockmax.Text = "" Else Txtstockmax.Text = .Cells("Stockmax").Value
        End With

    End Sub

    Private Function Validar() As Boolean

        If TxtDescripcion.Text = "" Then
            MsgBox("Ingrese el Nombre del producto", MsgBoxStyle.Critical)
            TxtDescripcion.Focus()
            Return False
        End If

        If Txtcodbar.Text = "" Then
            MsgBox("Ingrese el Codigo de Barra", MsgBoxStyle.Critical)
            Txtcodbar.Focus()
            Return False
        End If

        If Txtprecos.Text = "" Then
            MsgBox("Ingrese el Precio Costo del Producto", MsgBoxStyle.Critical)
            Txtprecos.Focus()
            Return False
        End If

        If Txtpreven.Text = "" Then
            MsgBox("Ingrese el Precio Venta del Producto", MsgBoxStyle.Critical)
            Txtpreven.Focus()
            Return False
        End If

        If Cbo_categoria.Text = "" Then
            MsgBox("Seleccione la Categoria del Producto", MsgBoxStyle.Critical)
            Cbo_categoria.Focus()
            Return False
        End If

        If Cbo_marca.Text = "" Then
            MsgBox("Seleccione la Categoria del Producto", MsgBoxStyle.Critical)
            Cbo_marca.Focus()
            Return False
        End If

        If Cbo_unimed.Text = "" Then
            MsgBox("Seleccione la Categoria del Producto", MsgBoxStyle.Critical)
            Cbo_unimed.Focus()
            Return False
        End If

        Return True
    End Function

#End Region

    Public Sub CargarCategoria()
        Dim tabla As New DataTable
        Dim sql As String = "SELECT c_codi_cate, c_nomb_cate FROM sco_categoria"
        Dim da As New SqlDataAdapter(sql, cn)
        da.Fill(tabla)

        Cbo_categoria.DataSource = tabla
        Cbo_categoria.DisplayMember = "c_nomb_cate"
        Cbo_categoria.ValueMember = "c_codi_cate"

    End Sub

    Public Sub CargarMarca()
        Dim tabla As New DataTable
        Dim sql As String = "SELECT c_codi_marc, c_nomb_marc FROM sco_marca"
        Dim da As New SqlDataAdapter(sql, cn)
        da.Fill(tabla)

        Cbo_marca.DataSource = tabla
        Cbo_marca.DisplayMember = "c_nomb_marc"
        Cbo_marca.ValueMember = "c_codi_marc"

    End Sub

    Public Sub CargarUmedida()
        Dim tabla As New DataTable
        Dim sql As String = "SELECT c_codi_umed, c_nomb_umed FROM sco_unidadmedida"
        Dim da As New SqlDataAdapter(sql, cn)
        da.Fill(tabla)

        Cbo_unimed.DataSource = tabla
        Cbo_unimed.DisplayMember = "c_nomb_umed"
        Cbo_unimed.ValueMember = "c_codi_umed"

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
        cargar_prod()
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
            cargar_prod()
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
        cargar_prod()
        CancelarGrabar()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        CancelarGrabar()
        limpiar()
        'deshabilitar()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        If MessageBox.Show("Esta seguro de Salir del Mant. de productos ",
    "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
    MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Me.Close()
        Else
            MsgBox("Se Cancelo la operacion.", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub DGVProducto_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVProducto.CellClick
        RecuperarDatosGrilla()
    End Sub

    Private Sub TxtBuscarProducto_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarProducto.TextChanged
        cargar_prod()
    End Sub

    Private Sub Frm_productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCategoria()
        CargarMarca()
        CargarUmedida()
        cargar_prod()
    End Sub

    Private Sub Txtprecos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtprecos.KeyPress
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        Else
            If e.KeyChar = "." And InStr(1, Txtprecos.Text, ".") > 0 Then e.KeyChar = ""
        End If
    End Sub

    Private Sub Txtpreven_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtpreven.KeyPress
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        Else
            If e.KeyChar = "." And InStr(1, Txtpreven.Text, ".") > 0 Then e.KeyChar = ""
        End If
    End Sub

    Private Sub Txtcodbar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtcodbar.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

End Class