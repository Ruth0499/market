Public Class E_Almacen

    Private _nro_cod As String
    Private _serie As String
    Private _ruc As String
    Private _igv As String
    Private _cliente As String
    Private _dir As String
    Private _imp As String
    Private _subtot As String
    Private _tot As String
    Private _est As String

    Private _dt As DataTable

    Public Property tabladetalle() As DataTable
        Get
            Return _dt
        End Get
        Set(ByVal value As DataTable)
            _dt = value
        End Set
    End Property
    Public Property igv() As String
        Get
            Return _igv
        End Get
        Set(ByVal value As String)
            _igv = value
        End Set
    End Property


    Public Property tot() As String
        Get
            Return _tot
        End Get
        Set(ByVal value As String)
            _tot = value
        End Set
    End Property

    Public Property subtot() As String
        Get
            Return _subtot
        End Get
        Set(ByVal value As String)
            _subtot = value
        End Set
    End Property

    Public Property imp() As String
        Get
            Return _imp
        End Get
        Set(ByVal value As String)
            _imp = value
        End Set
    End Property

    Public Property dir() As String
        Get
            Return _dir
        End Get
        Set(ByVal value As String)
            _dir = value
        End Set
    End Property

    Public Property cliente() As String
        Get
            Return _cliente
        End Get
        Set(ByVal value As String)
            _cliente = value
        End Set
    End Property


    Public Property ruc() As String
        Get
            Return _ruc
        End Get
        Set(ByVal value As String)
            _ruc = value
        End Set
    End Property

    Public Property serie() As String
        Get
            Return _serie
        End Get
        Set(ByVal value As String)
            _serie = value
        End Set
    End Property


    Public Property nro_cod() As String
        Get
            Return _nro_cod
        End Get
        Set(ByVal value As String)
            _nro_cod = value
        End Set
    End Property
    Public Property est() As String
        Get
            Return _est
        End Get
        Set(ByVal value As String)
            _est = value
        End Set
    End Property
End Class
