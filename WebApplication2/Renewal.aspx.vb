Imports MySql.Data.MySqlClient

Public Class WebForm4
    Inherits System.Web.UI.Page
    Dim constr As String = ConfigurationManager.ConnectionStrings("jmsConnectionString2").ConnectionString
    Dim con As New MySqlConnection(constr)
    Dim cmd As New MySqlCommand
    Dim cmd1 As New MySqlCommand
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub



    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            con.Open()
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable()

            Dim cmdstr As String
            cmdstr = My.Resources.Renewal
            cmd = New MySqlCommand(cmdstr, con)
            da = New MySqlDataAdapter(cmd)
            da.Fill(dt)
            GridView1.DataSource = dt
            GridView1.DataBind()
            con.Close()

        Catch ex As MySql.Data.MySqlClient.MySqlException
            MsgBox("ERROR" & ex.ToString)

        End Try

    End Sub
End Class