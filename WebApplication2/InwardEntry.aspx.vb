Imports MySql.Data.MySqlClient
Public Class InwardEntry
    Inherits System.Web.UI.Page
    Dim constr As String = ConfigurationManager.ConnectionStrings("jmsConnectionString2").ConnectionString
    Dim con As New MySqlConnection(constr)
    Dim cmd As New MySqlCommand

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If codeBox.Text = "" Or VolNoBox.Text = "" Or IssueNoBox.Text = "" Then
            MsgBox("Fill all mandatory fields", 0, "Attention Required")
        Else
            Try
                con.Open()
                Dim cmdstr As String
                cmdstr = "Insert into inwardentry (jcode,volno,issueno,fromdate,todate,mergeremark) values (" & codeBox.Text & "," & VolNoBox.Text & "," & IssueNoBox.Text & ",'" & FromDateBox.Text & "','" & ToDateBox.Text & "','" & MergeRemarkBox.Text & "'"
                cmd = New MySqlCommand(cmdstr, con)
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Saved successfully")


            Catch ex As Exception
                MsgBox("error" & ex.ToString)
            End Try

        End If
    End Sub

    Protected Sub codeBox_TextChanged(sender As Object, e As EventArgs) Handles codeBox.TextChanged
        Try


        Catch ex As MySql.Data.MySqlClient.MySqlException
            MsgBox(ex.ToString & "Database error")

        End Try

    End Sub
End Class