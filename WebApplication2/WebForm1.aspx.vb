Imports MySql.Data.MySqlClient
Public Class WebForm1
    Inherits System.Web.UI.Page

    Dim constr As String = ConfigurationManager.ConnectionStrings("jmsConnectionString2").ConnectionString
    Dim con As New MySqlConnection(constr)
    Dim cmd As New MySqlCommand

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub


    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Save.Click
        Dim cmdstr As String
        con.Open()
        cmdstr = " select name from journals where id=" & Val(TextBox11.Text)
        cmd = New MySqlCommand(cmdstr, con)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader()
        While dr.Read()
            TextBox11.Text = dr(0)
        End While
        con.Close()

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim ds As New DataSet
        Dim da As MySqlDataReader
        con.Open()
        Dim cmdstr = "select id,name,dept from journals "
        cmd = New MySqlCommand(cmdstr, con)
        da = cmd.ExecuteReader()
        con.Close()
    End Sub

    Protected Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub
End Class