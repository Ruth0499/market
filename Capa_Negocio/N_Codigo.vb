Imports System.Data
Imports System.Data.SqlClient
'Imports D_Codigo

Public Class N_Codigo

    Dim INS As New D_Codigo
    Dim INS1 As New D_Codigo

    Public Function GENERACODIGOALMACEN()
        Return INS1.AutoCodigoAlmacen
    End Function

    'Public Function GENERAFACTURA()
    '    Return INS1.AutoFactura
    'End Function

    Public Function grabar_Almacen(ByVal objen As E_Almacen) As String
        Return INS1.Graba_Almacen(objen)
    End Function

    Public Function elim_Almacen(ByVal cod As String) As Integer
        Return INS1.Elimina_Almacen(cod)
    End Function

    Public Function actualiza_Almacen(ByVal cod As String, ByVal um As String, ByVal nrofac As String, ByVal ruc As Integer, ByVal razsoc As String, ByVal dir As String, ByVal cant As Integer, ByVal desc As String, ByVal preuni As Decimal, ByVal imp As Decimal, ByVal subtot As Decimal, ByVal tot As Decimal, ByVal fechemi As DateTime) As String
        Return INS1.Modifica_Almacen(cod, um, nrofac, ruc, razsoc, dir, cant, desc, preuni, imp, subtot, tot, fechemi)
    End Function

    'Public Function Impresion(ByVal cod As String) As DataSet
    '    Return INS1.Impresion(cod)
    'End Function
    Public Function Impresion1(ByVal cod As String) As DataTable
        Return INS1.Impresion(cod)
    End Function

    Public Function Impresion2(ByVal cod As String) As DataTable
        Return INS1.Impresion2(cod)
    End Function

    Public Function Impresion3(ByVal cod As String) As DataTable
        Return INS1.Impresion3(cod)
    End Function

End Class
