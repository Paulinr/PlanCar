Imports ClassLibrary1

Imports System.Data.SqlClient
Imports System.Data
Public Class DomageDao

    ' Methodes / procedures
    Public Shared Function Ajouter(ByVal dom As Domage) As Integer

        Dim conn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing
        Dim result As Integer = 0
        Dim req As String = "Insert into domage values(@domageId,@description)"

        Try
            conn = New SqlConnection(My.Settings.PlanCarConString)
            conn.Open()
            cmd = New SqlCommand(req, conn)
            cmd.Parameters.AddWithValue("@domageId", dom.DomageId)
            cmd.Parameters.AddWithValue("@description", dom.Description)
            result = cmd.ExecuteNonQuery()

        Catch ex As Exception

            Throw New Exception(ex.Message)

        End Try

        Return result

    End Function

    Public Shared Function Editer(ByVal dom As Domage) As Integer

        Dim conn As SqlConnection = Nothing
        Dim Cmd As SqlCommand = Nothing
        ' Dim Dt As SqlDataReader = Nothing
        Dim result As Integer = 0
        Dim req As String = "UPDATE domage SET Description=@description where DomageId=@domageId"


        Try
            conn = New SqlConnection(My.Settings.PlanCarConString)
            conn.Open()
            Cmd = New SqlCommand(req, conn)
            Cmd.Parameters.AddWithValue("@domageId", dom.DomageId)
            Cmd.Parameters.AddWithValue("@libelle", dom.Description)

            result = Cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)


        End Try
        Return result

    End Function

    Public Shared Function supprimer(ByVal dom As Domage) As Boolean

        Dim conn As SqlConnection = Nothing
        Dim Cmd As SqlCommand = Nothing
        ' Dim Dt As SqlDataReader = Nothing
        Dim result As Boolean = False
        Dim req As String = "Delete from domage where DomageId=@domageId"


        Try
            conn = New SqlConnection(My.Settings.PlanCarConString)
            conn.Open()
            Cmd = New SqlCommand(req, conn)
            Cmd.Parameters.AddWithValue("@domageId", dom.DomageId)

            result = Cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)


        End Try
        Return result

    End Function


End Class
