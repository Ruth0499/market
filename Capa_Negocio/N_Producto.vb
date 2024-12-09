Public Class N_Producto

    Dim objd As New D_Producto

    Public Function n_Registrar(ByVal objenti As E_Producto) As String

        Return objd.D_Registrar(objenti)
    End Function

    Public Function N_listar_prod(ByVal objenti As E_Producto) As DataTable

        Return objd.D_listar_prod(objenti)
    End Function

    Public Function n_actualizar(ByVal objenti As E_Producto) As String

        Return objd.D_Actualizar(objenti)
    End Function

    Public Function N_eliminar_prod(ByVal objenti As E_Producto) As String

        Return objd.D_eliminar_prod(objenti)
    End Function

End Class
