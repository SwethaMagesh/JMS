Imports MySql.Data.MySqlClient

Public Class WebForm4
    Inherits System.Web.UI.Page
    Dim constr As String = ConfigurationManager.ConnectionStrings("jmsConnectionString2").ConnectionString
    Dim con As New MySqlConnection(constr)
    Dim cmd As New MySqlCommand
    Dim cmd1 As New MySqlCommand
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            SubscriptionsTable()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MsgBox("ERROR" & ex.ToString)

        End Try
    End Sub



    Function SubscriptionsTable()
        Subdiscontinued()
        Subapproaching()
        SubAvailable()
    End Function

    Function Subdiscontinued()
        Try
            con.Open()
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable()
            Dim cmd As New MySqlCommand
            Dim cmdstr As String
            cmdstr = My.Resources.Subscription & "dis"
            cmd = New MySqlCommand(cmdstr, con)
            da = New MySqlDataAdapter(cmd)
            da.Fill(dt)
            subdis.DataSource = dt
            subdis.DataBind()
            con.Close()
        Catch ex As Exception
            MsgBox("Error" & ex.ToString)
        End Try
    End Function

    Function Subapproaching()
        Try
            con.Open()
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable()
            Dim cmd As New MySqlCommand
            Dim cmdstr As String
            cmdstr = My.Resources.Subscription & "app"
            cmd = New MySqlCommand(cmdstr, con)
            da = New MySqlDataAdapter(cmd)
            da.Fill(dt)
            subapp.DataSource = dt
            subapp.DataBind()
            con.Close()
        Catch ex As Exception
            MsgBox("Error" & ex.ToString)
        End Try
    End Function

    Function SubAvailable()
        Try
            con.Open()
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable()
            Dim cmd As New MySqlCommand
            Dim cmdstr As String
            cmdstr = My.Resources.Subscription & "avl"
            cmd = New MySqlCommand(cmdstr, con)
            da = New MySqlDataAdapter(cmd)
            da.Fill(dt)
            subavl.DataSource = dt
            subavl.DataBind()
            con.Close()
        Catch ex As Exception
            MsgBox("Error" & ex.ToString)
        End Try
    End Function
End Class