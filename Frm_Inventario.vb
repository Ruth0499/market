Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Printing
'Imports CrystalDecisions.Windows.Forms
'Imports Microsoft.Reporting.WinForms
Imports System
Imports System.Text
Imports System.Globalization
Public Class Frm_Inventario
    Dim INS1 As New N_Codigo
    Dim INS2 As New N_Cliente
    Dim INS3 As New N_DetalleAlmacen

    Dim cn As New SqlConnection("Data Source=191.1.70.92;Initial Catalog=BDMARKET;User ID=RetailUser;Password=retail")

    Public Sub CargarUmedida()
        Dim tabla As New DataTable
        Dim sql As String = "SELECT c_codi_umed, c_nomb_umed FROM sco_unidadmedida"
        Dim da As New SqlDataAdapter(sql, cn)
        da.Fill(tabla)

        Cbo_unimed.DataSource = tabla
        Cbo_unimed.DisplayMember = "c_nomb_umed"
        Cbo_unimed.ValueMember = "c_codi_umed"

    End Sub

    Sub AucompletarRuc()
        Try
            Dim cmd As New SqlCommand("SELECT c_ndoc_prov FROM sco_proveedor", cn)
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(ds, "sco_proveedor")
            Dim col As New AutoCompleteStringCollection
            Dim i As Integer
            For i = 0 To ds.Tables(0).Rows.Count - 1
                col.Add(ds.Tables(0).Rows(i)("c_ndoc_prov").ToString())
            Next
            TXTRUC.AutoCompleteSource = AutoCompleteSource.CustomSource
            TXTRUC.AutoCompleteCustomSource = col
            TXTRUC.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Catch ex As Exception

        End Try
    End Sub

    Sub AucompletarDesc()
        Try
            Dim cmd As New SqlCommand("SELECT c_codi_prod FROM sco_DetInventario", cn)
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(ds, "sco_inventario")
            Dim col As New AutoCompleteStringCollection
            Dim i As Integer
            For i = 0 To ds.Tables(0).Rows.Count - 1
                col.Add(ds.Tables(0).Rows(i)("c_codi_prod").ToString())
            Next
            TXTDESC.AutoCompleteSource = AutoCompleteSource.CustomSource
            TXTDESC.AutoCompleteCustomSource = col
            TXTDESC.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Catch ex As Exception

        End Try
    End Sub

    Sub AucompletarDir()
        Try
            Dim cmd As New SqlCommand("SELECT c_dire_prov FROM sco_proveedor", cn)
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(ds, "sco_proveedor")
            Dim col As New AutoCompleteStringCollection
            Dim i As Integer
            For i = 0 To ds.Tables(0).Rows.Count - 1
                col.Add(ds.Tables(0).Rows(i)("c_dire_prov").ToString())
            Next
            TXTDIR.AutoCompleteSource = AutoCompleteSource.CustomSource
            TXTDIR.AutoCompleteCustomSource = col
            TXTDIR.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Catch ex As Exception

        End Try
    End Sub

    Sub AutocompletarRazsoc()
        Try
            Dim cmd As New SqlCommand("select c_nomb_prov from sco_proveedor", cn)
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(ds, "sco_proveedor")
            Dim col As New AutoCompleteStringCollection
            Dim i As Integer
            For i = 0 To ds.Tables(0).Rows.Count - 1
                col.Add(ds.Tables(0).Rows(i)("c_nomb_prov").ToString())
            Next
            TXTRAZSOC.AutoCompleteSource = AutoCompleteSource.CustomSource
            TXTRAZSOC.AutoCompleteCustomSource = col
            TXTRAZSOC.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Catch ex As Exception

        End Try
    End Sub

    Public Sub NUEVO()
        TXTCODFAC.Visible = False
        Dim X As String = INS1.GENERACODIGOALMACEN
        TXTCODFAC.Text = X
        TXTCODFAC.Focus()
        'Dim X1 As String = INS1.GENERAFACTURA
        'lblnumerofactura.Text = X1
        'lblnumerofactura.Focus()
    End Sub

    Public Sub INICIO()
        TXTCODFAC.Enabled = False
        'TXTUM.Visible = False
        TXTIMP.Enabled = False
        Timer1.Enabled = True
        lblfecha_impresion.Enabled = False
        TXTSUBTOT.Enabled = False
        TXTIGV.Text = "0.00"
        TXTLETRAS.Enabled = True
        TXTIGV.Enabled = False
        TXTIMP.Enabled = False
        TXTTOT.Enabled = False

        'Cbo_unimed.Items.Add("KLS")
        'Cbo_unimed.Items.Add("AT")
        'Cbo_unimed.Items.Add("UNID")
        'Cbo_unimed.SelectedIndex = 0
    End Sub

    Public Sub LIMPIAR()
        TXTCODFAC.Clear()
        Dim CRT As New Control
        'For Each CRT In Me.GroupBox1.Controls
        '    If TypeOf CRT Is TextBox Then
        '        CRT.Text = ""
        '    End If
        'Next
        For Each CRT In Me.GroupBox2.Controls
            If TypeOf CRT Is TextBox Then
                CRT.Text = ""
            End If
        Next
        For Each CRT In Me.GroupBox3.Controls
            If TypeOf CRT Is TextBox Then
                CRT.Text = ""
            End If
        Next
        'TXTIGV.Clear()
        TXTSUBTOT.Clear()
        TXTTOT.Clear()
        TXTLETRAS.Clear()

    End Sub

    Public Sub DESHABILITA()
        BTNGUARDAR.Enabled = False
        BTNMODIFICAR.Enabled = False
        BTNELIMINAR.Enabled = False
        BTNIMPRIMIR.Enabled = False
    End Sub

    Public Sub HABILITA()
        BTNGUARDAR.Enabled = True
        BTNMODIFICAR.Enabled = True
        BTNELIMINAR.Enabled = True
        BTNIMPRIMIR.Enabled = True
    End Sub

    Public Sub GUARDAR()
        Try
            If DGDATOS.Rows.Count = 0 Then
                MsgBox("No hay registros en la grilla", 32, "Mensaje")
                Exit Sub
            End If
            '
            '
            Dim cod As String = INS1.GENERACODIGOALMACEN 'Al grabar genera el codigo
            Dim dt As DataTable = f_llenar_tabla()

            Dim objenti As New E_Almacen
            With objenti
                .cliente = TXTRAZSOC.Text
                .dir = TXTDIR.Text
                ' .igv = TXTIGV.Text
                .nro_cod = cod
                .ruc = TXTRUC.Text
                .serie = "001"
                .subtot = TXTSUBTOT.Text 'TXTIMP .Text 
                .tabladetalle = dt
                .tot = TXTTOT.Text
                .est = "Emitido"

            End With
            Dim factura$ = INS1.grabar_Almacen(objenti)
            MsgBox("Se Genero la Factura Nro " & factura, 32, "mensaje del sistema")
            'p_imprimir(cod)

            'Dim frm As New Form1
            'frm.valor = cod
            'frm.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Public Function f_llenar_tabla() As DataTable
        Dim dt As New DataTable

        dt.Columns.Add("Cantidad")
        dt.Columns.Add("U_M")
        dt.Columns.Add("Descripción")
        dt.Columns.Add("PrecioUnitario")
        dt.Columns.Add("Importe")
        For x As Integer = 0 To DGDATOS.Rows.Count - 1
            Dim dr As DataRow
            dr = dt.NewRow
            dr(0) = DGDATOS.Rows(x).Cells(0).Value.ToString
            dr(1) = DGDATOS.Rows(x).Cells(1).Value.ToString
            dr(2) = DGDATOS.Rows(x).Cells(2).Value.ToString
            dr(3) = DGDATOS.Rows(x).Cells(3).Value.ToString
            dr(4) = DGDATOS.Rows(x).Cells(4).Value.ToString
            dt.Rows.Add(dr)

        Next
        Return dt
    End Function

    'Sub p_imprimir(ByVal cod$)
    '    Dim CrReport As New CrystalDecisions.CrystalReports.Engine.ReportDocument
    '    Try
    '        Dim ds As New DataSet


    '        'Dim dt1 As DataTable = INS1.Impresion1(cod)
    '        'Dim dt2 As DataTable = INS1.Impresion2(cod)

    '        Dim dt3 As DataTable = INS1.Impresion3(cod)

    '        ds.Tables.Add(dt3)
    '        ds.Tables(0).TableName = "cabecera"

    '        'ds.Tables.Add(dt2)
    '        'ds.Tables(1).TableName = "cabeceradet"


    '        CrReport = New CrystalDecisions.CrystalReports.Engine.ReportDocument()
    '        Dim ruta As String = Application.StartupPath & "\..\..\CrystalReport1.rpt"

    '        CrReport.Load(ruta)
    '        CrReport.SetDataSource(ds)

    '        Dim rpt As New CrystalReport1
    '        rpt.SetDataSource(ds)
    '        'aca le pasamos el valor del parametro creado
    '        rpt.SetParameterValue("letras", TXTLETRAS.Text)
    '        rpt.SetParameterValue("subtotal", TXTSUBTOT.Text)
    '        rpt.SetParameterValue("igv", TXTIGV.Text)
    '        rpt.SetParameterValue("total", TXTTOT.Text)
    '        rpt.SetParameterValue("LBLFECHA", lblfecha_impresion.Text)




    '        CrystalReportViewer1.ReportSource = rpt

    '        'CrystalReportViewer1.ReportSource = CrReport
    '        'CrystalReportViewer1.Refresh()
    '        CrystalReportViewer1.PrintReport()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        'Exit Sub
    '    End Try


    '    Try
    '        'Dim pd As New PrintDocument

    '        'CrReport.PrintOptions.PrinterName = pd.PrinterSettings.PrinterName
    '        'CrReport.PrintToPrinter(1, False, 0, 0)

    '    Catch ex As Exception
    '        MsgBox("No se encuentra la Impresora", 32, "Mensaje")

    '    End Try

    'End Sub

    Public Sub llenar_prod(ByVal x As Boolean) ' toda esta parte es para desabilitar la factura una vez llegado al limite
        TXTCANT.Enabled = x
        TXTDESC.Enabled = x
        Cbo_unimed.Enabled = x
        TXTPREUNI.Enabled = x
    End Sub

    Public Sub DATAGRID()
        Dim can As Integer = 0 'declarando  una variable para usarla en el conteo de registros
        Try

            DGDATOS.Columns(0).DefaultCellStyle.Format = "####,##0.00"
            DGDATOS.Columns(3).DefaultCellStyle.Format = "####,##0.00"
            DGDATOS.Columns(4).DefaultCellStyle.Format = "####,##0.00"


            DGDATOS.Rows.Add(CDec(TXTCANT.Text), Cbo_unimed.Text, TXTDESC.Text, CDec(TXTPREUNI.Text), TXTIMP.Text)
            can = DGDATOS.Rows.Count  'igualando la variable para el conteo de registros
            Dim totalValue As Decimal
            For Each dgvRow As DataGridViewRow In DGDATOS.Rows
                If Not dgvRow.IsNewRow Then
                    totalValue = totalValue + CDbl(dgvRow.Cells(4).Value)
                    TXTSUBTOT.Text = Format(totalValue, "####,##0.00")
                    ' TXTIGV.Text = Format(CDbl(totalValue * 0.18), "##,##0.00")

                    TXTTOT.Text = Format(totalValue, "####,####0.00")
                    '  TXTSUBTOT.Text = totalValue
                End If
            Next
            '  Label6.Text = can.ToString
            'realizando un if para darle la cantidad de registro en el que nos enviara un mensaje
            If can = 23 Then
                llenar_prod(True)
                MsgBox("La factura ah llegado a su limite !", 32, "Mensaje del sistema")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub SUMA01()
        Try
            Dim x As Decimal
            x = Format((TXTPREUNI.Text * TXTCANT.Text), "####,####0.00")
            TXTIMP.Text = x
        Catch ex As Exception
            TXTIMP.Text = ""
        End Try
    End Sub

    Sub SUMA02()
        Try
            Dim x As Decimal
            x = Format((TXTPREUNI.Text * TXTCANT.Text), "####,####0.00")
            TXTIMP.Text = x
        Catch ex As Exception
            TXTIMP.Text = ""
        End Try
    End Sub

    Private Shared Function FillDgv() As List(Of Articulo)
        '
        'Cree una lista generica de la entidad EArticulo
        '
        Dim listaArticulos As New List(Of Articulo)()
        '
        'Instancie la clase EArticulo para agregar datos a la lista
        '
        'Establezca valores a cada una de las propiedades
        Dim item As New Articulo()

        Return listaArticulos
    End Function

    Public Sub IMPRIMIR()
        '
        'La funcion GenerateNumber() se utiliza unicamente para generar un Número
        'aleatorio que simulara ser el numerod e factura
        'txtnumero.Text = GenerateNumber().ToString()

        'Establecemos la propiedad AutoGenerateColumns en False para evitar que se agreguen
        'nuevas columnas a la derecha de las que creamos en tiempo de diseño.
        '
        DGDATOS.AutoGenerateColumns = False
        '
        'Establecemos el DataSource del control DataGridView
        '
        DGDATOS.DataSource = FillDgv()
        '
        'Mapeamos las propiedades de la clase devuelta por la Funcion FillDgv()
        'recuerde que esta funcion devuelve una lista del tipo EArticulo
        '
        DGDATOS.Columns("columnNumero").DataPropertyName = "Numero"
        DGDATOS.Columns("columnUpc").DataPropertyName = "Cantidad"
        DGDATOS.Columns("columnDescripcion").DataPropertyName = "U M"
        DGDATOS.Columns("columnPiezas").DataPropertyName = "Descripcion"
        DGDATOS.Columns("columnPrecio").DataPropertyName = "PrecioU"
        DGDATOS.Columns("columnImporte").DataPropertyName = "Importe"
        '
        'Hacemos las sumatorias usando un método de extensión de Linq
        '
        Dim sum As Decimal = FillDgv().Sum(Function(x) x.Importe)
        'Dim iva As Decimal = (Math.Round(((sum / 116) * 16), 2))
        Dim subtotal As Decimal = (sum)

        TXTTOT.Text = Convert.ToDecimal(TXTTOT())
        '.Text = Convert.ToString(iva)
        TXTSUBTOT.Text = TXTTOT.Text


        '------------------------------++++++++++++++++++++++++------------------

    End Sub

    Private Sub InvoiceGenerate()
        '
        'Hacemos una instancia de la clase EFactura para
        'llenarla con los valores contenidos en los controles del Formulario
        Dim invoice As New Almacen()
        'invoice.Codigo = CStr(lblnumerofactura.Text)
        invoice.Nombre = TXTRAZSOC.Text
        invoice.Ruc = TXTRUC.Text
        invoice.Direccion = TXTDIR.Text
        invoice.FechaFacturacion = lblfecha.Text
        invoice.Subtotal = Convert.ToDecimal(TXTSUBTOT.Text)
        '  invoice.igv = Convert.ToDecimal(TXTIGV.Text)
        invoice.Total = Convert.ToDecimal(TXTTOT.Text)

        'Recorremos los Rows existentes actualmente en el control DataGridView
        'para asignar los datos a las propiedades
        For Each row As DataGridViewRow In DGDATOS.Rows
            Dim article As New Articulo()
            '
            'Vamos tomando los valores de las celdas del row que estamos 
            'recorriendo actualmente y asignamos su valor a la propiedad de la clase intanciada
            '
            'article.Codigo = Convert.ToString(row.Cells("Codigo").Value).ToString
            article.Cantidad = Convert.ToString(row.Cells("UM").Value)
            article.UM = Convert.ToString(row.Cells("Cantidad").Value).ToString
            article.Descripcion = Convert.ToString(row.Cells("Descripcion").Value).ToString
            article.PrecioUnitario = Convert.ToDecimal(row.Cells("PrecioUnitario").Value)
            article.Importe = Convert.ToDecimal(row.Cells("Importe").Value)

            '
            'Vamos agregando el Item a la lista del detalle
            '
            invoice.Detail.Add(article)
        Next

        '
        'Creamos una instancia del Formulario que contiene nuestro
        'ReportViewer
        '

        '
        'Usamos las propiedades publicas del formulario, aqui es donde enviamos el valor
        'que se mostrara en los parametros creados en el LocalReport, para este ejemplo
        'estamos Seteando los valores directamente pero usted puede usar algun control
        '
        'frm.Titulo = "Este es un ejemplo de Factura"
        'frm.Empresa = "Este es un ejemplo del Nombre de la Empresa"
        '
        'Recuerde que invoice es una Lista Generica declarada en FacturaRtp, es una lista
        'porque el origen de datos del LocalReport unicamente permite ser enlazado a objetos que 
        'implementen IEnumerable.
        '
        'Usamos el metod Add porque Invoice es una lista e invoice es una entidad simple
        'frm.Invoice.Add(invoice)
        '
        'Enviamos el detalle de la Factura, como Detail es una lista e invoide.Details tambien
        'es un lista del tipo EArticulo bastara con igualarla
        '
        'frm.Detail = invoice.Detail

    End Sub

    Private Sub btn_cliente_Click(sender As Object, e As EventArgs) Handles btn_cliente.Click
        Dim frm As New Frm_BuscaCliente
        frm.ShowDialog()
        TXTRAZSOC.Text = Send.s_razon
        TXTRUC.Text = Send.s_ruc
        TXTDIR.Text = Send.s_dir
    End Sub

    Private Sub Frm_Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call NUEVO()
        Call INICIO()
        Call DESHABILITA()
        Call AucompletarRuc()
        Call AutocompletarRazsoc()
        Call AucompletarDesc()
        Call AucompletarDir()

        CargarUmedida()
    End Sub

    Private Sub BTNNUEVO_Click(sender As Object, e As EventArgs) Handles BTNNUEVO.Click
        Call LIMPIAR()
        Call NUEVO()
        Call HABILITA()
        TXTRUC.Focus()
    End Sub

    Private Sub BTNGUARDAR_Click(sender As Object, e As EventArgs) Handles BTNGUARDAR.Click
        TXTRUC.Focus()
        'Call DATAGRID()
        Call GUARDAR()
        'Call DETALLE_VENTA()
        Call LIMPIAR()
        '' BTNIMPRIMIR.Enabled = True
        DGDATOS.Rows.Clear()
    End Sub

    Private Sub BTNELIMINAR_Click(sender As Object, e As EventArgs) Handles BTNELIMINAR.Click
        If (DGDATOS.Rows.Count > 0) Then

            Dim fila As Integer = DGDATOS.CurrentRow.Index

            DGDATOS.Rows.RemoveAt(fila)
        Else
            MsgBox("NO HAY REGISTROS EN LA GRILLA")
        End If
    End Sub

    Private Sub BTNIMPRIMIR_Click(sender As Object, e As EventArgs) Handles BTNIMPRIMIR.Click
        TXTRUC.Focus()
        Call GUARDAR()
        Call LIMPIAR()
        DGDATOS.Rows.Clear()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            lblfecha.Text = System.DateTime.Now.ToString(("yyyy/MM/dd HH:mm:ss"))
            lblfecha_impresion.Text = System.DateTime.Now.ToString(("dd               MM               yyyy"))
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TXTCANT_TextChanged(sender As Object, e As EventArgs) Handles TXTCANT.TextChanged
        Call SUMA01()
    End Sub

    Private Sub TXTCANT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTCANT.KeyPress
        Dim TECLA As Integer
        TECLA = Asc(e.KeyChar)
        Select Case TECLA
            Case 48 To 57
            Case 8
            Case 32
            Case 46
            Case Else
                e.Handled = True
        End Select
        'clase.NumeroDec(e, Me.TXTCANT)
    End Sub

    Private Sub TXTPREUNI_TextChanged(sender As Object, e As EventArgs) Handles TXTPREUNI.TextChanged
        Call SUMA02()
    End Sub

    Private Sub TXTPREUNI_KeyDown(sender As Object, e As KeyEventArgs) Handles TXTPREUNI.KeyDown
        Dim TECLA As Integer
        TECLA = Asc(e.KeyData)
        If e.KeyData = Keys.Enter Then
            Call DATAGRID()
            'Call GUARDAR()
            'Call DETALLE_VENTA()
            'Call LIMPIAR()
            TXTCANT.Text = "" : TXTDESC.Text = "" : TXTPREUNI.Text = "" : TXTIMP.Text = ""
            ' BTNIMPRIMIR.Enabled = True
        End If
    End Sub

    Private Sub TXTPREUNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTPREUNI.KeyPress
        Dim TECLA As Integer
        TECLA = Asc(e.KeyChar)
        Select Case TECLA
            Case 48 To 57
            Case 8
            Case 32
            Case 46
            Case Else
                e.Handled = True
        End Select
        'Clase_num.NumeroDec(e, Me.TXTPREUNI)
    End Sub

    Private Sub TXTRUC_TextChanged(sender As Object, e As EventArgs) Handles TXTRUC.TextChanged

    End Sub

    Private Sub TXTRUC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTRUC.KeyPress
        Dim TECLA As Integer
        TECLA = Asc(e.KeyChar)
        Select Case TECLA
            Case 48 To 57
            Case 8
            Case 32
            Case Else
                e.Handled = True
        End Select
    End Sub

    Public Sub guardar2()
        If DGDATOS.Rows.Count = 0 Then
            MsgBox("No hay registros en la grilla", 32, "Mensaje")
            Exit Sub
        End If
        cn.Open()
        Dim objenti As New E_Almacen
        Dim cod As String = INS1.GENERACODIGOALMACEN
        Dim cmd As New SqlCommand("grabar_venta2", cn)
        Dim prm As New SqlParameter
        With cmd
            .CommandType = CommandType.StoredProcedure
            prm = .Parameters.Add("@nro_cod", SqlDbType.VarChar, 11)
            prm.Value = cod.ToString

            prm = .Parameters.Add("@serie", SqlDbType.VarChar, 10)
            prm.Value = "001"
            prm = .Parameters.Add("@ruc", SqlDbType.VarChar, 11)
            prm.Value = TXTRUC.Text

            prm = .Parameters.Add("@razon", SqlDbType.VarChar, 200)
            prm.Value = TXTRAZSOC.Text

            prm = .Parameters.Add("@dir", SqlDbType.VarChar, 200)
            prm.Value = TXTDIR.Text

            prm = .Parameters.Add("@igv", SqlDbType.Decimal)
            'prm.Value = TXTIGV.Text

            prm = .Parameters.Add("@subtot", SqlDbType.Decimal)
            prm.Value = TXTSUBTOT.Text

            prm = .Parameters.Add("@tot", SqlDbType.Decimal)
            prm.Value = TXTTOT.Text

            cmd.Parameters.Add("@codfacgen", SqlDbType.VarChar, 9).Value = "100"
            .Parameters("@codfacgen").Direction = ParameterDirection.Output
            .ExecuteNonQuery()

        End With
        cn.Close()
        cmd.Dispose()
        Dim i As Integer
        Dim nro As String
        Dim cantidad As Decimal
        Dim um As String
        Dim desc As String
        Dim pre As Decimal
        Dim imp As Decimal

        For i = 0 To DGDATOS.Rows.Count - 1
            cn.Open()
            nro = cod.ToString
            cantidad = CDec(DGDATOS.Rows(i).Cells(0).Value)
            um = DGDATOS.Rows(i).Cells(1).Value
            desc = DGDATOS.Rows(i).Cells(2).Value
            pre = CDec(DGDATOS.Rows(i).Cells(3).Value)
            imp = CDec(DGDATOS.Rows(i).Cells(4).Value)
            Dim cmd2 As New SqlCommand("grabar_detalle2", cn)
            Dim prm2 As New SqlParameter
            ' sql2 = "insert into Detalle_Venta VALUES(" + nro + "," + desc + "," + pre + "," + cantidad + "," + um + "," + imp + ")"
            ' Dim cmd2 As New SqlCommand("grabar_detalle2", cn)
            With cmd2
                .CommandType = CommandType.StoredProcedure
                prm = .Parameters.Add("@nro_cod", SqlDbType.VarChar, 11)
                prm.Value = cod.ToString
                prm = .Parameters.Add("@cantidad", SqlDbType.Decimal)
                prm.Value = cantidad
                prm = .Parameters.Add("@U_M", SqlDbType.VarChar, 5)
                prm.Value = um
                prm = .Parameters.Add("@Descripción", SqlDbType.VarChar)
                prm.Value = desc
                prm = .Parameters.Add("@PrecioUnitario", SqlDbType.Decimal)
                prm.Value = pre
                prm = .Parameters.Add("@importe", SqlDbType.Decimal)
                prm.Value = imp
                .ExecuteNonQuery()
            End With
            cn.Close()
            cmd2.Dispose()
        Next
        Dim cad As String = cmd.Parameters("@codfacgen").Value.ToString()
        MsgBox("Se Genero la Factura Nro " & cad, 32, "mensaje del sistema")
        'p_imprimir(cod)
    End Sub

    Private Sub DGDATOS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGDATOS.CellContentClick

    End Sub

    Private Sub DGDATOS_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGDATOS.CellClick
        Dim fila = e.RowIndex 'obtiene la fila
        Dim col = e.ColumnIndex

        If (col = 5) Then
            DGDATOS.Rows.RemoveAt(fila)

        End If
    End Sub
End Class