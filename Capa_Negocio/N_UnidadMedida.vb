Public Class N_UnidadMedida

    Dim objd As New D_UnidadMedida

    Public Function n_Registrar(ByVal objenti As E_UnidadMedida) As String

        Return objd.D_Registrar(objenti)
    End Function

    Public Function N_listar_umed(ByVal objenti As E_UnidadMedida) As DataTable

        Return objd.D_listar_umed(objenti)
    End Function

    Public Function n_actualizar(ByVal objenti As E_UnidadMedida) As String

        Return objd.D_Actualizar(objenti)
    End Function

    Public Function N_eliminar_umed(ByVal objenti As E_UnidadMedida) As String

        Return objd.D_eliminar_umed(objenti)
    End Function

End Class
