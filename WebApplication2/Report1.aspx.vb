Imports MySql.Data.MySqlClient
Public Class Report1
    Inherits System.Web.UI.Page
    Dim constr As String = ConfigurationManager.ConnectionStrings("jmsConnectionString2").ConnectionString
    Dim con As New MySqlConnection(constr)
    Dim cmd As New MySqlCommand
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        JournalTable()
        PublisherTable()
        JournalPublisherTable()
        JournalDeptTable()
        JournalPeridocityTable()
        JournalProgramTable()
        VolumeIssuesTable()
        SubscriptionsTable()
    End Sub

    Function JournalTable()
        Try
            con.Open()
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable()
            Dim cmd As New MySqlCommand
            Dim cmdstr As String
            cmdstr = "Select * from journall"
            cmd = New MySqlCommand(cmdstr, con)
            da = New MySqlDataAdapter(cmd)
            da.Fill(dt)
            Journals.DataSource = dt
            Journals.DataBind()
            con.Close()

        Catch ex As Exception
            MsgBox("Error" & ex.ToString)
        End Try
    End Function
    Function PublisherTable()
        Try
            con.Open()
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable()
            Dim cmd As New MySqlCommand
            Dim cmdstr As String
            cmdstr = "Select * from publ"
            cmd = New MySqlCommand(cmdstr, con)
            da = New MySqlDataAdapter(cmd)
            da.Fill(dt)
            Publishers.DataSource = dt
            Publishers.DataBind()
            con.Close()
        Catch ex As Exception
            MsgBox("Error" & ex.ToString)
        End Try
    End Function

    Function JournalPublisherTable()
        Try
            con.Open()
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable()
            Dim cmd As New MySqlCommand
            Dim cmdstr As String
            cmdstr = "Select * from jpubl"
            cmd = New MySqlCommand(cmdstr, con)
            da = New MySqlDataAdapter(cmd)
            da.Fill(dt)
            jpubl.DataSource = dt
            jpubl.DataBind()
            con.Close()
            MergeRows(jpubl)
        Catch ex As Exception
            MsgBox("Error" & ex.ToString)
        End Try
    End Function

    Function JournalPeridocityTable()
        Try
            con.Open()
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable()
            Dim cmd As New MySqlCommand
            Dim cmdstr As String
            cmdstr = "Select * from periodicityl"
            cmd = New MySqlCommand(cmdstr, con)
            da = New MySqlDataAdapter(cmd)
            da.Fill(dt)
            periodicityl.DataSource = dt
            periodicityl.DataBind()
            con.Close()
            MergeRows(periodicityl)
        Catch ex As Exception
            MsgBox("Error" & ex.ToString)
        End Try
    End Function


    Function JournalProgramTable()
        Try
            con.Open()
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable()
            Dim cmd As New MySqlCommand
            Dim cmdstr As String
            cmdstr = "Select * from jprogl"
            cmd = New MySqlCommand(cmdstr, con)
            da = New MySqlDataAdapter(cmd)
            da.Fill(dt)
            jprogl.DataSource = dt
            jprogl.DataBind()
            con.Close()
            MergeRows(jprogl)
        Catch ex As Exception
            MsgBox("Error" & ex.ToString)
        End Try
    End Function

    Function JournalDeptTable()
        Try
            con.Open()
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable()
            Dim cmd As New MySqlCommand
            Dim cmdstr As String
            cmdstr = "Select * from jdeptl"
            cmd = New MySqlCommand(cmdstr, con)
            da = New MySqlDataAdapter(cmd)
            da.Fill(dt)
            jdeptl.DataSource = dt
            jdeptl.DataBind()
            con.Close()
            MergeRows(jdeptl)
        Catch ex As Exception
            MsgBox("Error" & ex.ToString)
        End Try
    End Function

    Function VolumeIssuesTable()
        Try
            con.Open()
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable()
            Dim cmd As New MySqlCommand
            Dim cmdstr As String
            cmdstr = "Select * from issuesl"
            cmd = New MySqlCommand(cmdstr, con)
            da = New MySqlDataAdapter(cmd)
            da.Fill(dt)
            issuesl.DataSource = dt
            issuesl.DataBind()
            con.Close()
            MergeRows(issuesl)
        Catch ex As Exception
            MsgBox("Error" & ex.ToString)
        End Try
    End Function

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

    Public Function MergeRows(GridView1 As GridView)
        For i As Integer = GridView1.Rows.Count - 1 To 1 Step -1
            Dim row As GridViewRow = GridView1.Rows(i)
            Dim previousRow As GridViewRow = GridView1.Rows(i - 1)
            Dim j As Integer = 0
            If row.Cells(j).Text = previousRow.Cells(j).Text Then
                If previousRow.Cells(j).RowSpan = 0 Then
                    If row.Cells(j).RowSpan = 0 Then
                        previousRow.Cells(j).RowSpan += 2
                    Else
                        previousRow.Cells(j).RowSpan = row.Cells(j).RowSpan + 1
                    End If
                    row.Cells(j).Visible = False
                End If
            End If
        Next
    End Function



End Class