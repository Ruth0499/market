Public Class N_Marca

    Dim objd As New D_Marca

    Public Function n_Registrar(ByVal objenti As E_Marca) As String

        Return objd.D_Registrar(objenti)
    End Function

    Public Function N_listar_marc(ByVal objenti As E_Marca) As DataTable

        Return objd.D_listar_marc(objenti)
    End Function

    Public Function n_actualizar(ByVal objenti As E_Marca) As String

        Return objd.D_Actualizar(objenti)
    End Function

    Public Function N_eliminar_marc(ByVal objenti As E_Marca) As String

        Return objd.D_eliminar_marc(objenti)
    End Function

End Class
