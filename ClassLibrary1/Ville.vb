Public Class Ville

    'Data member

    Private _libelle As String
    Private _departement As Departement

    ' Properties

    Property Libelle() As String

        Get
            Return _libelle
        End Get
        Set(ByVal value As String)
            _libelle = value

        End Set
    End Property

    Property Departement() As Departement
        Get
            Return _departement
        End Get
        Set(ByVal value As Departement)
            _departement = value

        End Set
    End Property

    Public Sub New()

    End Sub

    Public Overrides Function ToString() As String
        Return Libelle + " " + Departement.Libelle

    End Function

End Class
