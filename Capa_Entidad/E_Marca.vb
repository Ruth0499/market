Public Class E_Marca

    Private _codmarc As String
    Private _desmarc As String
    Private _criterio As String

    Public Property codmarc() As String
        Get
            Return _codmarc
        End Get
        Set(ByVal value As String)
            _codmarc = value
        End Set
    End Property

    Public Property desmarc() As String
        Get
            Return _desmarc
        End Get
        Set(ByVal value As String)
            _desmarc = value
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
