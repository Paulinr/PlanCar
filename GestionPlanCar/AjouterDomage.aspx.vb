Imports ClassLibrary1
Imports Dao

Public Class AjouterDomage
    Inherits System.Web.UI.Page

    Dim lbl_message As Object

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        Dim dom As New Domage()
        Dim result As Integer = 0
        Try
            dom.Description = txt_desc.Text
            result = DomageDao.Ajouter(dom)
            If result > 0 Then
                lbl_message.ForeColor = Drawing.Color.Blue
                lbl_message.Text = "Insertion effectue avec succes"
            End If
        Catch ex As Exception
            lbl_message.Text = ex.Message

        End Try

    End Sub

    Protected Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

    End Sub
End Class