Imports System.IO
Imports System.Net
Imports System.Net.Mail
Public Class Email
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        txtSubject.Text = "Missing Issues"
        txtBody.Text = "The following issues are missing as of now"
    End Sub

    Protected Sub SendEmail(sender As Object, e As EventArgs)
        Try
            Using mm As New MailMessage(txtEmail.Text, txtTo.Text)
                mm.Subject = txtSubject.Text
                mm.Body = txtBody.Text
                If fuAttachment.HasFile Then
                    Dim FileName As String = Path.GetFileName(fuAttachment.PostedFile.FileName)
                    mm.Attachments.Add(New Attachment(fuAttachment.PostedFile.InputStream, FileName))
                End If
                mm.IsBodyHtml = False
                Dim smtp As New SmtpClient()
                smtp.Host = "smtp.gmail.com"
                smtp.EnableSsl = True
                Dim NetworkCred As New NetworkCredential(txtEmail.Text, txtPassword.Text)
                smtp.UseDefaultCredentials = True
                smtp.Credentials = NetworkCred
                smtp.Port = 587
                smtp.Send(mm)
                ClientScript.RegisterStartupScript(Me.GetType, "alert", "alert('Email sent.');", True)
            End Using

        Catch ex As Exception
            MsgBox("Error" & ex.ToString)
        End Try

    End Sub

End Class