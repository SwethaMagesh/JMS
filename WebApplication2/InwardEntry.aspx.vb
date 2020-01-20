Imports MySql.Data.MySqlClient
Public Class InwardEntry
    Inherits System.Web.UI.Page
    Dim con As New MySqlConnection
    Dim cmd As New MySqlCommand("server=127.0.01;user id=root;pwd=sanjay2001;database=jms")

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If codeBox.Text = "" Or VolNoBox.Text = "" Or IssueNoBox.Text = "" Then
            MsgBox("Fill all mandatory fields", 0, "Attention Required")
        Else
            con.Open()
            Dim cmdstr As String
            cmdstr = "Insert into "

        End If
    End Sub


End Class