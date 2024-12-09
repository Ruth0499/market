Public Class N_Categoria

    Dim objd As New D_Categoria

    Public Function n_Registrar(ByVal objenti As E_Categoria) As String

        Return objd.D_Registrar(objenti)
    End Function

    Public Function N_listar_cat(ByVal objenti As E_Categoria) As DataTable

        Return objd.D_listar_cat(objenti)
    End Function

    Public Function n_actualizar(ByVal objenti As E_Categoria) As String

        Return objd.D_Actualizar(objenti)
    End Function

    Public Function N_eliminar_cat(ByVal objenti As E_Categoria) As String

        Return objd.D_eliminar_cat(objenti)
    End Function

End Class
