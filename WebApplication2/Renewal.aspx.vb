Imports MySql.Data.MySqlClient

Public Class WebForm4
    Inherits System.Web.UI.Page
    Dim con As New MySqlConnection("server=127.0.0.1;user id=root;pwd=sanjay2001;database=jms;persistsecurityinfo=True")
    Dim cmd As New MySqlCommand
    Dim cmd1 As New MySqlCommand
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub



    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        con.Open()
        Dim da As MySqlDataAdapter
        Dim dt As New DataTable()

        Dim cmdstr As String
        cmdstr = "select code as JCode ,title as Title ,fromDate as StartDate, toDate as EndDate from master where todate is not null order by toDate,code"
        cmd = New MySqlCommand(cmdstr, con)
        da = New MySqlDataAdapter(cmd)
        da.Fill(dt)
        GridView1.DataSource = dt
        GridView1.DataBind()
        con.Close()
    End Sub
End Class