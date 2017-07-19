<Serializable>
Public Class jsonStructure

    Private _action As Short
    Public Property action() As Short
        Get
            Return _action
        End Get
        Set(value As Short)
            _action = value
        End Set
    End Property

    Private _response As Short
    Public Property response() As Short
        Get
            Return _response
        End Get
        Set(value As Short)
            _response = value
        End Set
    End Property

    Dim _puid As String
    Public Property puid() As String
        Get
            Return _puid
        End Get
        Set(value As String)
            _puid = value
        End Set
    End Property

    Dim _serial As String
    Public Property serial() As String
        Get
            Return _serial
        End Get
        Set(value As String)
            _serial = value
        End Set
    End Property

    Dim _name As String
    Public Property name() As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Dim _email As String
    Public Property email() As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Dim _phone As String
    Public Property phone() As String
        Get
            Return _phone
        End Get
        Set(value As String)
            _phone = value
        End Set
    End Property

    Dim _package As String
    Public Property package() As String
        Get
            Return _package
        End Get
        Set(value As String)
            _package = value
        End Set
    End Property

    Dim _ranber As Long
    Public Property ranber() As Long
        Get
            Return _ranber
        End Get
        Set(value As Long)
            _ranber = value
        End Set
    End Property
End Class
