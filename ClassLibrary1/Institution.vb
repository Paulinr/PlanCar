Public Class Institution

    Private _adresse As String
    Private _email As String
    Private _emailResponsable As String
    Private _nom As String
    Private _nomResponsable As String
    Private _telephone As String
    Private _telephoneResponsable As String
    Private _localisation As Ville

    Public Sub New(ByVal Iadresse As String, ByVal Iemail As String, ByVal IemailResponsable As String, ByVal Inom As String, ByVal InomResponsable As String, ByVal Itelephone As String, ByVal ItelephoneResponsable As String, ByVal Ilocalisation As Ville)
        _adresse = Iadresse
        _email = Iemail
        _emailResponsable = IemailResponsable
        _nom = Inom
        _nomResponsable = InomResponsable
        _telephone = Itelephone
        _telephoneResponsable = ItelephoneResponsable
        _localisation = Ilocalisation
    End Sub

    Public Sub New()
      
    End Sub

    Public Property adresse() As String

        Get
            Return _adresse
        End Get

        Set(ByVal value As String)

            _adresse = value

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

    Public Property emailResponsable() As String

        Get
            Return _emailResponsable
        End Get

        Set(ByVal value As String)

            _emailResponsable = value


        End Set
    End Property

    Public Property nom() As String

        Get
            Return _nom
        End Get

        Set(ByVal value As String)

            _nom = value

        End Set
    End Property

    Public Property nomResponsable()

        Get
            Return _nomResponsable
        End Get
        Set(ByVal value)

            _nomResponsable = value

        End Set
    End Property


End Class
