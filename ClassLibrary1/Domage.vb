Public Class Domage

    ' Data member
    Private _domageId As Integer
    Private _description As String

    'Properties
    Property Description As String
        Get
            Return _description
        End Get
        Set(ByVal value As String)

            _description = value
        End Set
    End Property

    Property DomageId As Integer
        Get
            Return _domageId
        End Get
        Set(ByVal value As Integer)

            _domageId = value

        End Set
    End Property

    ' constructor

    Public Sub New()

    End Sub

    Public Overrides Function ToString() As String
        Return DomageId + " " + Description

    End Function


End Class
