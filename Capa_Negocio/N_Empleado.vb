Public Class N_Empleado

    Dim objd As New D_Empleado

    Public Function n_Registrar(ByVal objenti As E_Empleado) As String

        Return objd.D_Registrar(objenti)
    End Function
    Public Function N_listar_emp(ByVal objenti As E_Empleado) As DataTable

        Return objd.D_listar_emp(objenti)
    End Function
    Public Function n_actualizar(ByVal objenti As E_Empleado) As String

        Return objd.D_Actualizar(objenti)
    End Function
    Public Function N_eliminar_emp(ByVal objenti As E_Empleado) As String
        Return objd.D_eliminar_emp(objenti)
    End Function

End Class
