Public Class N_Proveedor

    Dim objd As New D_Proveedor

    Public Function n_Registrar(ByVal objenti As E_Proveedor) As String

        Return objd.D_Registrar(objenti)
    End Function

    Public Function N_listar_prov(ByVal objenti As E_Proveedor) As DataTable

        Return objd.D_listar_prov(objenti)
    End Function

    Public Function n_actualizar(ByVal objenti As E_Proveedor) As String

        Return objd.D_Actualizar(objenti)
    End Function

    Public Function N_eliminar_prov(ByVal objenti As E_Proveedor) As String

        Return objd.D_eliminar_prov(objenti)
    End Function
End Class
