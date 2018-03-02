Public Class Vehicule

    Private _couleur As String
    Private _dateservice As Date
    Private _immatriculation As String
    Private _isAssEnRegle As Boolean
    Private _isVehiculeVole As Boolean
    Private _marque As String
    Private _modele As String
    Private _numeroSerie As String
    Private _statutVehicule As String

    Public Sub New(ByVal vcouleur As String, ByVal vdateservice As Date, ByVal vimmatriculation As String, ByVal visAssEnRegle As Boolean, ByVal visVehiculeVole As Boolean, ByVal vmarque As String, ByVal vmodele As String, ByVal vnumeroSerie As String, ByVal vstatutVehicule As String)
        _couleur = vcouleur
        _dateservice = vdateservice
        _immatriculation = vimmatriculation
        _isAssEnRegle = visAssEnRegle
        _isVehiculeVole = visVehiculeVole
        _marque = vmarque
        _modele = vmodele
        _numeroSerie = vnumeroSerie
        _statutVehicule = vstatutVehicule

    End Sub

    Public Sub New()

        _couleur = ""
        _dateservice = ""
        _immatriculation = ""
        _isAssEnRegle = ""
        _isVehiculeVole = ""
        _marque = ""
        _modele = ""
        _numeroSerie = ""
        _statutVehicule = ""


    End Sub


    Public Property couleur() As String
        Get
            Return _couleur
        End Get
        Set(ByVal value As String)

            _couleur = value

        End Set
    End Property

    Public Property dateservice() As Date
        Get
            Return _dateservice
        End Get

        Set(ByVal value As Date)

            _dateservice = value

        End Set
    End Property

    Public Property immatriculation() As String
        Get
            Return _immatriculation
        End Get

        Set(ByVal value As String)

            _immatriculation = value

        End Set
    End Property

    Public Property isAssEnRegle() As Boolean
        Get
            Return _isAssEnRegle
        End Get

        Set(ByVal value As Boolean)

            _isAssEnRegle = value

        End Set
    End Property

    Public Property isVehiculeVole() As Boolean
        Get
            Return _isVehiculeVole
        End Get
        Set(ByVal value As Boolean)

            _isVehiculeVole = value

        End Set
    End Property

    Public Property marque() As String
        Get
            Return _marque
        End Get

        Set(ByVal value As String)

            _marque = value

        End Set
    End Property

    Public Property modele() As String

        Get
            Return _modele
        End Get
        Set(ByVal value As String)
            _modele = value

        End Set
    End Property

    Public Property numerSerie() As String

        Get
            Return _numeroSerie
        End Get

        Set(ByVal value As String)

            _numeroSerie = value

        End Set
    End Property

    Public Property statutVehicule() As String

        Get
            Return _statutVehicule
        End Get

        Set(ByVal value As String)

            _statutVehicule = value

        End Set
    End Property



End Class
