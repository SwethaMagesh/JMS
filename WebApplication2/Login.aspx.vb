Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient
Imports System.Web.Security
Public Class WebForm5
    Inherits System.Web.UI.Page
    Dim constr As String = ConfigurationManager.ConnectionStrings("jmsConnectionString2").ConnectionString
    Dim con As New MySqlConnection(constr)

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub login_Click(sender As Object, e As EventArgs) Handles login.Click
        Try
            con.Open()
            Dim commandstr As String
            Dim cmd As MySqlCommand
            Dim dr As MySqlDataReader
            commandstr = "select password from login where username = '" & username.Text & "'"
            cmd = New MySqlCommand(commandstr, con)
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                If password.Text = dr(0).ToString Then
                    con.Close()
                    Response.Redirect("~/Default.aspx", False)
                Else
                    MsgBox("Password incorrect", 0, "Retry")
                End If
            Else
                MsgBox("User doesn't exist")
            End If
            con.Close()
        Catch ex As Exception
            MsgBox("Error" & ex.ToString)
        End Try

    End Sub

    Protected Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles username.TextChanged

    End Sub
End Class