Public Class E_Producto

    Private _codprod As String
    Private _desprod As String
    Private _barprod As String
    Private _pcosprod As String
    Private _pvenprod As String
    Private _codcatprod As String
    Private _codmarprod As String
    Private _unimedprod As String
    Private _stkprod As String
    Private _stkmini As String
    Private _stkmaxi As String
    Private _criterio As String

    Public Property codprod() As String
        Get
            Return _codprod
        End Get
        Set(ByVal value As String)
            _codprod = value
        End Set
    End Property

    Public Property desprod() As String
        Get
            Return _desprod
        End Get
        Set(ByVal value As String)
            _desprod = value
        End Set
    End Property

    Public Property barprod() As String
        Get
            Return _barprod
        End Get
        Set(ByVal value As String)
            _barprod = value
        End Set
    End Property

    Public Property pcosprod() As String
        Get
            Return _pcosprod
        End Get
        Set(ByVal value As String)
            _pcosprod = value
        End Set
    End Property

    Public Property pvenprod() As String
        Get
            Return _pvenprod
        End Get
        Set(ByVal value As String)
            _pvenprod = value
        End Set
    End Property

    Public Property codcatprod() As String
        Get
            Return _codcatprod
        End Get
        Set(ByVal value As String)
            _codcatprod = value
        End Set
    End Property

    Public Property codmarprod() As String
        Get
            Return _codmarprod
        End Get
        Set(ByVal value As String)
            _codmarprod = value
        End Set
    End Property

    Public Property unimedprod() As String
        Get
            Return _unimedprod
        End Get
        Set(ByVal value As String)
            _unimedprod = value
        End Set
    End Property

    Public Property stkprod() As String
        Get
            Return _stkprod
        End Get
        Set(ByVal value As String)
            _stkprod = value
        End Set
    End Property

    Public Property stkmini() As String
        Get
            Return _stkmini
        End Get
        Set(ByVal value As String)
            _stkmini = value
        End Set
    End Property

    Public Property stkmaxi() As String
        Get
            Return _stkmaxi
        End Get
        Set(ByVal value As String)
            _stkmaxi = value
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
