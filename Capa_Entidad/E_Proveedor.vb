Public Class E_Proveedor

    Private _codprov As String
    Private _desprov As String
    Private _dirprov As String
    Private _telprov As String
    Private _tipdocprov As String
    Private _docuprov As String
    Private _mailprov As String
    Private _criterio As String

    Public Property codprov() As String
        Get
            Return _codprov
        End Get
        Set(ByVal value As String)
            _codprov = value
        End Set
    End Property

    Public Property desprov() As String
        Get
            Return _desprov
        End Get
        Set(ByVal value As String)
            _desprov = value
        End Set
    End Property

    Public Property tipdocprov() As String
        Get
            Return _tipdocprov
        End Get
        Set(ByVal value As String)
            _tipdocprov = value
        End Set
    End Property

    Public Property docuprov() As String
        Get
            Return _docuprov
        End Get
        Set(ByVal value As String)
            _docuprov = value
        End Set
    End Property

    Public Property dirprov() As String
        Get
            Return _dirprov
        End Get
        Set(ByVal value As String)
            _dirprov = value
        End Set
    End Property

    Public Property telprov() As String
        Get
            Return _telprov
        End Get
        Set(ByVal value As String)
            _telprov = value
        End Set
    End Property

    Public Property mailprov() As String
        Get
            Return _mailprov
        End Get
        Set(ByVal value As String)
            _mailprov = value
        End Set
    End Property

    Public Property criterio() As String
        Get
            Return _criterio
        End Get
        Set(ByVal value As String)
            _criterio = value
        End Set
    End Property

End Class
