Public Class Departement

    Private _libelle As String

    Public Property Libelle As String


        Get
            Return _libelle

        End Get
        Set(value As String)
            Me._libelle = value

        End Set
    End Property

    Public Sub New()

    End Sub

    Public Overrides Function ToString() As String
        Return Libelle
    End Function

    Public Overrides Function Equals(obj As Object) As Boolean
        Dim rep As Boolean = False
        Dim dep As Departement = Nothing
        'On convertit obj en departement
        'dep=obj as Departement
        If dep.Libelle.Equals(Me.Libelle) Then
            rep = True
        End If

        Return rep
    End Function

End Class
