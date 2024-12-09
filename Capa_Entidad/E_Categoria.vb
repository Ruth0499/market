Public Class E_Categoria
    Private _codcat As String
    Private _descat As String
    Private _criterio As String

    Public Property codcat() As String
        Get
            Return _codcat
        End Get
        Set(ByVal value As String)
            _codcat = value
        End Set
    End Property

    Public Property descat() As String
        Get
            Return _descat
        End Get
        Set(ByVal value As String)
            _descat = value
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
