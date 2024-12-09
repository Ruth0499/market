Public Class E_Empleado

    Private _codemp As String
    Private _apeemp As String
    Private _nomemp As String
    Private _fecnac As Date
    Private _sexo As String
    Private _diremp As String
    Private _telemp As String
    Private _email As String
    Private _cargo As String
    Private _criterio As String
    Public Property codemp() As String
        Get
            Return _codemp
        End Get
        Set(ByVal value As String)
            _codemp = value
        End Set
    End Property
    Public Property apeemp() As String
        Get
            Return _apeemp
        End Get
        Set(ByVal value As String)
            _apeemp = value
        End Set
    End Property
    Public Property nomemp() As String
        Get
            Return _nomemp
        End Get
        Set(ByVal value As String)
            _nomemp = value
        End Set
    End Property
    Public Property fecnac() As Date
        Get
            Return _fecnac
        End Get
        Set(ByVal value As Date)
            _fecnac = value
        End Set
    End Property
    Public Property sexo() As String
        Get
            Return _sexo
        End Get
        Set(ByVal value As String)
            _sexo = value
        End Set
    End Property
    Public Property diremp() As String
        Get
            Return _diremp
        End Get
        Set(ByVal value As String)
            _diremp = value
        End Set
    End Property
    Public Property telemp() As String
        Get
            Return _telemp
        End Get
        Set(ByVal value As String)
            _telemp = value
        End Set
    End Property
    Public Property email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
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
    Public Property cargo() As String
        Get
            Return _cargo
        End Get
        Set(ByVal value As String)
            _cargo = value
        End Set
    End Property

End Class
