Imports System.Data.Odbc
Imports System.Windows
Public Class WebForm1
    Inherits System.Web.UI.Page
    Dim con1 As New OdbcConnection("Dsn=mysqlnew;database=jms;option=0;port=3306;uid=root")

    Dim cmd As OdbcCommand
    Dim dr As OdbcDataReader

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cmdstr As String
        con1.open()
        cmdstr = " select name from journals where id=" & Val(TextBox1.Text)
        cmd = New OdbcCommand(cmdstr, con1)
        dr = cmd.ExecuteReader()
        While dr.Read()
            TextBox2.Text = dr(0)

        End While
        con1.Close()

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ds As New DataSet
        Dim da As OdbcDataAdapter
        con1.Open()
        Dim cmdstr = "select id,name,dept from journals "
        'cmd = New OdbcCommand(cmdstr, con1)
        da = New OdbcDataAdapter(cmdstr, con1)






        con1.Close()
    End Sub
End Class