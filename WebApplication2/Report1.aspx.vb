Imports MySql.Data.MySqlClient
Public Class Report1
    Inherits System.Web.UI.Page
    Dim constr As String = ConfigurationManager.ConnectionStrings("jmsConnectionString2").ConnectionString
    Dim con As New MySqlConnection(constr)
    Dim cmd As New MySqlCommand
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub obtain_Click(sender As Object, e As EventArgs) Handles obtain.Click
        Dim val1 As String
        Dim val2 As String
        Dim val3 As String

        Select Case List2.SelectedValue
            Case 0
                val2 = "publisher"
                val1 = " pubid as PubId, pubname as Publisher"

            Case 1
                val2 = " master "
                val1 = "code as JournalCode, title as JournalTitle"

            Case 2
                val2 = "subscription "
                val1 = " "
            Case Else
                val1 = ""
                val2 = " "
        End Select

        If List1.SelectedValue = 0 Then
            val1 = " Count(*)  as Count "

        End If


        con.Open()
        Try
            Dim cmdstr As String
            cmdstr = " select " & val1 & "  from " & val2
            cmd = New MySqlCommand(cmdstr, con)
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable()
            da = New MySqlDataAdapter(cmd)
            da.Fill(dt)
            GridView1.DataSource = dt
            GridView1.DataBind()
        Catch ex As MySqlException
            MsgBox("Error " & ex.ToString)
        End Try


        con.Close()

    End Sub
End Class