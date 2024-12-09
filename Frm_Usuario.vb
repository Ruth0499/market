Public Class Frm_Usuario

    Public Sub CargarCargo()
        Cbo_cargo.Items.Add("SELECCIONE")
        Cbo_cargo.Items.Add("CONSULTOR")
        Cbo_cargo.Items.Add("PROGRAMADOR")
        Cbo_cargo.Items.Add("ASISTENTE")
        Cbo_cargo.Text = Cbo_cargo.Items(0).ToString
    End Sub

    Public Sub CargarEstado()
        Cbo_estado.Items.Add("SELECCIONE")
        Cbo_estado.Items.Add("ACTIVO")
        Cbo_estado.Items.Add("INACTIVO")
        Cbo_estado.Text = Cbo_estado.Items(0).ToString
    End Sub

    Private Sub Frm_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCargo()
        CargarEstado()
    End Sub

    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click

    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click

    End Sub
End Class