Public Class E_Sucursal

    Private _codsucu As String
    Private _dessucu As String
    Private _dirsucu As String
    Private _telsucu As String
    Private _mailsucu As String
    Private _criterio As String

    Public Property codsucu() As String
        Get
            Return _codsucu
        End Get
        Set(ByVal value As String)
            _codsucu = value
        End Set
    End Property

    Public Property dessucu() As String
        Get
            Return _dessucu
        End Get
        Set(ByVal value As String)
            _dessucu = value
        End Set
    End Property

    Public Property dirsucu() As String
        Get
            Return _dirsucu
        End Get
        Set(ByVal value As String)
            _dirsucu = value
        End Set
    End Property

    Public Property telsucu() As String
        Get
            Return _telsucu
        End Get
        Set(ByVal value As String)
            _telsucu = value
        End Set
    End Property

    Public Property mailsucu() As String
        Get
            Return _mailsucu
        End Get
        Set(ByVal value As String)
            _mailsucu = value
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
