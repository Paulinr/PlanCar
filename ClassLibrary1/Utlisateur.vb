Public Class Utlisateur

    Private _email As String
    Private _password As String
    Private _privilege As String
    Private _statutCompte As String
    Private _institution As Institution

    Public Sub New(ByVal uemail As String, ByVal upassword As String, ByVal uprivilege As String, ByVal ustatutCompte As String, ByVal uinstitution As Institution)
        _email = uemail
        _password = upassword
        _privilege = uprivilege
        _statutCompte = ustatutCompte
        _institution = uinstitution

    End Sub
    Public Sub New()
       

    End Sub

    Public Property email() As String

        Get
            Return _email
        End Get
        Set(ByVal value As String)

            _email = value

        End Set
    End Property

    Public Property password() As String

        Get
            Return _password
        End Get

        Set(ByVal value As String)

            _password = value

        End Set
    End Property

    Public Property privilege() As String

        Get
            Return _privilege

        End Get
        Set(ByVal value As String)

            _privilege = value

        End Set
    End Property

    Public Property statutCompte() As String

        Get
            Return _statutCompte
        End Get

        Set(ByVal value As String)

            _statutCompte = value

        End Set
    End Property

    Public Property institution() As Institution

        Get
            Return _institution
        End Get
        Set(ByVal value As Institution)

            _institution = value

        End Set
    End Property


End Class
