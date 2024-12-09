Imports System.Data
Imports System.Data.SqlClient
Public Class FrmInicio
    Dim cont As Integer = 0
    Dim cnt As Integer = 0
    Dim cn As New SqlConnection("Data Source=191.1.70.92;Initial Catalog=BDMARKET;User ID=RetailUser;Password=retail")

    Public Sub INGRESO()

        Dim dt As New DataTable
        Dim da As New SqlDataAdapter("select * from Usuario where c_codi_usua='" & txtusuario.Text.Trim & "' and c_clav_usua='" & txtclave.Text.Trim & "' and c_carg_usua='" & cbotipousuario.Text & "' and c_esta_usus='1'", cn)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            Send.USUARIO = txtusuario.Text
            HABILITAR()
        Else
            cont = 0
            Call LIMPIAR()
            Call DESHABILITAR()
            MsgBox("Error de usuario ó cotraseña, el usuario no existe ó esta deshabilitado.", 16, "Mensaje Login")
            Timer1.Stop()
            Timer1.Enabled = False
            Timer1.Dispose()
            cnt = cnt + 1
        End If
        If cnt >= 3 Then
            MsgBox("Ud. intento ingresar el mayor número de veces, vuelva a intentarlo ó ingrese más tarde.", MsgBoxStyle.Information, "Mensaje Login")
            Application.Exit()
        End If
    End Sub

    Private Sub cmdingresar_Click(sender As Object, e As EventArgs) Handles cmdingresar.Click
        Call INGRESO()
    End Sub

    Private Sub cmdcancelar_Click(sender As Object, e As EventArgs) Handles cmdcancelar.Click
        Try
            If PGB1.Step Then
                Timer1.Enabled = False
                Dim RPTAS As New Integer
                RPTAS = MessageBox.Show("Desea salir cancelar.?", "Mensaje Login", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                If RPTAS = 6 Then
                    Application.Exit()
                    Timer1.Stop()
                    Timer1.Dispose()
                Else
                    Timer1.Enabled = True
                    PGB1.Enabled = True
                End If
            End If

            '-----------------+++++++++++++++++--+++++++++++
            If txtusuario.Text = "" And txtclave.Text = "" Then
                Call DESHABILITAR()
                Timer1.Enabled = False
                PGB1.Enabled = False
                cont = 0
            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub CARGAR()
        cbotipousuario.Sorted = True
        Dim x As String() = ({"Seleccione..."})
        cbotipousuario.Items.AddRange(x)
        Dim DT As New DataTable
        Dim DA As New SqlDataAdapter(" SELECT DISTINCT c_carg_usua FROM USUARIO", cn)
        DA.Fill(DT)
        cbotipousuario.DataSource = DT
        cbotipousuario.DisplayMember = "c_carg_usua"
    End Sub
    Sub LIMPIAR()
        Dim CRT As New Control
        For Each CRT In GBILOAD.Controls
            If TypeOf CRT Is TextBox Then
                CRT.Text = ""
            End If
        Next
        txtusuario.Focus()
    End Sub
    Public Sub HABILITAR()
        Timer1.Enabled = True
        PGB1.Visible = True
        LBLMENSAJE.Visible = True
    End Sub
    Public Sub DESHABILITAR()
        PGB1.Visible = False
        LBLMENSAJE.Visible = False
    End Sub
    Sub DESHABILITABUTTON()
        cbotipousuario.Enabled = False
        txtusuario.Enabled = False
        txtclave.Enabled = False
    End Sub
    Sub HABILITABUTTON()
        cbotipousuario.Enabled = True
        txtusuario.Enabled = True
        txtclave.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        PGB1.Value = cont
        LBLMENSAJE.Text = "Se está cargando " & cont & "%"
        cont = cont + 4
        If cont = 100 Then
            Timer1.Enabled = False
            Timer1.Dispose()
            cont = 0
            Dim frm As New Frm_MenuPrincipal
            frm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub txtclave_KeyDown(sender As Object, e As KeyEventArgs) Handles txtclave.KeyDown
        Dim TECLA As Integer
        TECLA = Asc(e.KeyData)
        If e.KeyData = Keys.Enter Then
            Call INGRESO()
        End If
    End Sub

    Private Sub cbotipousuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbotipousuario.KeyPress
        e.Handled = True
    End Sub

    Private Sub FrmInicio_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call DESHABILITAR()
        Call LIMPIAR()
        Call CARGAR()
    End Sub

    Private Sub cbotipousuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbotipousuario.SelectedIndexChanged
        txtusuario.Focus()
    End Sub
End Class
