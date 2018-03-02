Imports System.Data.SqlClient
Imports System.Data
Imports ClassLibrary1

Public Class DepartementDao

    ' Methodes / procedures

    Public Shared Function Ajouter(ByVal Dept As Departement) As Integer

        Dim conn As SqlConnection = Nothing
        Dim Cmd As SqlCommand = Nothing
        ' Dim Dt As SqlDataReader = Nothing
        Dim result As Integer = 0
        Dim req As String = "insert into departement values (@libelle)"

        Try
            conn = New SqlConnection(My.Settings.PlanCarConString)
            conn.Open()
            Cmd = New SqlCommand(req, conn)
            Cmd.Parameters.AddWithValue("@libelle", Dept.Libelle)
            result = Cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)


        End Try
        Return result

    End Function

    Public Shared Function Editer(ByVal Dept As Departement) As Integer

        Dim conn As SqlConnection = Nothing
        Dim Cmd As SqlCommand = Nothing
        ' Dim Dt As SqlDataReader = Nothing
        Dim result As Integer = 0
        Dim req As String = "UPDATE departement SET (@libelle) where departementID="

        Try
            conn = New SqlConnection(My.Settings.PlanCarConString)
            conn.Open()
            Cmd = New SqlCommand(req, conn)
            Cmd.Parameters.AddWithValue("@libelle", Dept.Libelle)
            result = Cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)


        End Try
        Return result

    End Function

End Class
