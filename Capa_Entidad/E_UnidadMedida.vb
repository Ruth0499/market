Public Class E_UnidadMedida

    Private _codumed As String
    Private _desumed As String
    Private _criterio As String

    Public Property codumed() As String
        Get
            Return _codumed
        End Get
        Set(ByVal value As String)
            _codumed = value
        End Set
    End Property

    Public Property desumed() As String
        Get
            Return _desumed
        End Get
        Set(ByVal value As String)
            _desumed = value
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
