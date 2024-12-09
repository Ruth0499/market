Public Class N_Cliente

    Dim objd As New D_Cliente

    Public Function n_Registrar(ByVal objenti As E_Cliente) As String

        Return objd.D_Registrar(objenti)
    End Function

    Public Function N_listar_clie(ByVal objenti As E_Cliente) As DataTable

        Return objd.D_listar_clie(objenti)
    End Function

    Public Function n_actualizar(ByVal objenti As E_Cliente) As String

        Return objd.D_Actualizar(objenti)
    End Function

    Public Function N_eliminar_clie(ByVal objenti As E_Cliente) As String

        Return objd.D_eliminar_clie(objenti)
    End Function

End Class
