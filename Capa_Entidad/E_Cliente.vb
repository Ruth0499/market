Public Class E_Cliente

    Private _codclie As String
    Private _desclie As String
    Private _dirclie As String
    Private _telclie As String
    Private _tipdocclie As String
    Private _docuclie As String
    Private _mailclie As String
    Private _criterio As String

    Public Property codclie() As String
        Get
            Return _codclie
        End Get
        Set(ByVal value As String)
            _codclie = value
        End Set
    End Property

    Public Property desclie() As String
        Get
            Return _desclie
        End Get
        Set(ByVal value As String)
            _desclie = value
        End Set
    End Property

    Public Property tipdocclie() As String
        Get
            Return _tipdocclie
        End Get
        Set(ByVal value As String)
            _tipdocclie = value
        End Set
    End Property

    Public Property docuclie() As String
        Get
            Return _docuclie
        End Get
        Set(ByVal value As String)
            _docuclie = value
        End Set
    End Property

    Public Property dirclie() As String
        Get
            Return _dirclie
        End Get
        Set(ByVal value As String)
            _dirclie = value
        End Set
    End Property

    Public Property telclie() As String
        Get
            Return _telclie
        End Get
        Set(ByVal value As String)
            _telclie = value
        End Set
    End Property

    Public Property mailclie() As String
        Get
            Return _mailclie
        End Get
        Set(ByVal value As String)
            _mailclie = value
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
