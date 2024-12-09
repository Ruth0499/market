Public Class N_Sucursal

    Dim objd As New D_Sucursal

    Public Function n_Registrar(ByVal objenti As E_Sucursal) As String

        Return objd.D_Registrar(objenti)
    End Function

    Public Function N_listar_sucu(ByVal objenti As E_Sucursal) As DataTable

        Return objd.D_listar_sucu(objenti)
    End Function

    Public Function n_actualizar(ByVal objenti As E_Sucursal) As String

        Return objd.D_Actualizar(objenti)
    End Function

    Public Function N_eliminar_sucu(ByVal objenti As E_Sucursal) As String

        Return objd.D_eliminar_sucu(objenti)
    End Function

End Class
