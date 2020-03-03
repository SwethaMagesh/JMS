Imports MySql.Data.MySqlClient
Public Class InwardEntry
    Inherits System.Web.UI.Page
    Dim constr As String = ConfigurationManager.ConnectionStrings("jmsConnectionString2").ConnectionString
    Dim con As New MySqlConnection(constr)
    Dim cmd As New MySqlCommand

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            FromDateBox.Text = DateTime.Today.ToString("yyyy-MM-dd")
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If codeBox.Text = "" Or VolNoBox.Text = "" Or IssueNoBox.Text = "" Then
            MsgBox("Fill all mandatory fields", 0, "Attention Required")
        Else
            Try
                con.Open()
                Dim cmdstr As String
                cmdstr = "Insert into inwardentry (jcode,volno,issueno,fromdate,todate,mergeremark) values (" & codeBox.Text & "," & VolNoBox.Text & "," & IssueNoBox.Text & ",'" & FromDateBox.Text & "','" & ToDateBox.Text & "','" & MergeRemarkBox.Text & "')"
                cmd = New MySqlCommand(cmdstr, con)
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Saved successfully")
                Button2_Click(Nothing, Nothing)

            Catch ex As MySqlException
                con.Close()
                If ex.Number = 3819 Then
                    MsgBox("Date constraint ")
                Else
                    MsgBox("error" & ex.ToString)
                End If

            End Try

        End If
    End Sub



    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        codeBox.Text = ""
        TitleBox.Text = ""
        VolNoBox.Text = ""
        IssueNoBox.Text = ""
        FromDateBox.Text = Today.ToString("yyyy-MM-dd")
        ToDateBox.Text = ""
        MergeRemarkBox.Text = ""
    End Sub

    Protected Sub codeBox_TextChanged(sender As Object, e As EventArgs) Handles codeBox.TextChanged
        'needs changes
        Try
            con.Open()
            Dim command As String
            command = "select volno,issueno,fromdate,todate,mergeremark from inwardentry where jcode=" & codeBox.Text & " order by volno desc,issueno desc limit 1;"
            cmd = New MySqlCommand(command, con)
            Dim dr As MySqlDataReader
            dr = cmd.ExecuteReader()
            If dr.Read() Then

                VolNoBox.Text = dr(0).ToString
                IssueNoBox.Text = dr(1).ToString
                Dim fd As Date
                fd = dr(2)
                Dim td As Date
                td = dr(3)
                FromDateBox.Text = fd.ToString("yyyy-MM-dd")
                ToDateBox.Text = td.ToString("yyyy-MM-dd")
                MergeRemarkBox.Text = dr(4)

            End If
            dr.Close()

            command = "select title from master where code =" & codeBox.Text
            cmd = New MySqlCommand(command, con)
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                TitleBox.Text = dr(0)
            Else
                Button2_Click(Nothing, Nothing)
            End If
            con.Close()

        Catch ex As Exception
            con.Close()

            MsgBox("Error In getting details " & ex.ToString)
        End Try
    End Sub
    Function isIssuePresent()
        Dim flag As Boolean
        Try
            con.Open()
            Dim cmdstr As String
            cmdstr = "select volno,issueno from inwardentry where jcode= " & codeBox.Text & " and issueno= " & IssueNoBox.Text & " and volno =" & VolNoBox.Text
            cmd = New MySqlCommand(cmdstr, con)
            Dim dr As MySqlDataReader
            dr = cmd.ExecuteReader()
            If dr.Read Then
                flag = 1
            Else
                flag = 0
            End If

            con.Close()
            Return flag
        Catch ex As MySqlException
            MsgBox("error" & ex.ToString)
        End Try
        Return -1
    End Function

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'update
        If codeBox.Text IsNot "" And VolNoBox.Text IsNot "" And IssueNoBox.Text IsNot "" Then

            Dim ch As Int16
            ch = MsgBox("Are you sure you want To update this entry?", 3, "Confirm Update")
            Select Case ch
                Case vbYes
                    Try
                        con.Open()
                        Dim cmdstr As String
                        cmdstr = "Update inwardentry Set fromdate='" & FromDateBox.Text & "',todate='" & ToDateBox.Text & "',mergeremark='" & MergeRemarkBox.Text & "' where jcode = " & codeBox.Text & " and volno = " & VolNoBox.Text & " and issueno = " & IssueNoBox.Text
                        cmd = New MySqlCommand(cmdstr, con)
                        cmd.ExecuteNonQuery()
                        con.Close()
                        MsgBox("Modified successfully")
                        Button2_Click(Nothing, Nothing)

                    Catch ex As MySqlException
                        con.Close()
                        If ex.Number = 3819 Then
                            MsgBox("Date constraint ")
                        Else
                            MsgBox("error" & ex.ToString)
                        End If


                    End Try


            End Select


        Else
            MsgBox("Fill mandatory details", 0, "Missing Field")
        End If

    End Sub

    Protected Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'delete
        If codeBox.Text IsNot "" And VolNoBox.Text IsNot "" And IssueNoBox.Text IsNot "" Then

            Dim ch As Int16
            ch = MsgBox("Are you sure you want to delete this entry?", 3, "Confirm Delete")
            Select Case ch
                Case vbYes
                    Try
                        con.Open()
                        Dim cmdstr As String
                        cmdstr = "Delete from inwardentry where jcode = " & codeBox.Text & " and volno = " & VolNoBox.Text & " and issueno = " & IssueNoBox.Text
                        cmd = New MySqlCommand(cmdstr, con)
                        cmd.ExecuteNonQuery()
                        con.Close()
                        MsgBox("Deleted successfully")
                        Button2_Click(Nothing, Nothing)

                    Catch ex As MySqlException
                        con.Close()

                        MsgBox("error" & ex.ToString)


                    End Try


            End Select


        Else
            MsgBox("Fill mandatory fields", 0, "Missing Field")
        End If

    End Sub

    Protected Sub IssueNoBox_TextChanged(sender As Object, e As EventArgs) Handles IssueNoBox.TextChanged
        Dim issuePresent As Boolean

        issuePresent = isIssuePresent()
        If Not issuePresent Then

            MsgBox("no issue")
            Button1.Enabled = True
            Button1.Visible = True
            Button3.Enabled = False
            Button4.Enabled = False
            Button3.Visible = False
            Button4.Visible = False
        Else
            MsgBox("issued")
            Button3.Enabled = True
            Button4.Enabled = True
            Button3.Visible = True
            Button4.Visible = True
            Button1.Enabled = False
            Button1.Visible = False
            Try
                con.Open()
                Dim command As String
                command = "select volno,issueno,fromdate,todate,mergeremark from inwardentry where jcode=" & codeBox.Text & "  and volno = " & VolNoBox.Text & " and issueno = " & IssueNoBox.Text
                cmd = New MySqlCommand(command, con)
                Dim dr As MySqlDataReader
                dr = cmd.ExecuteReader()
                If dr.Read() Then

                    'VolNoBox.Text = dr(0).ToString
                    'IssueNoBox.Text = dr(1).ToString
                    Dim fd As Date
                    fd = dr(2)
                    Dim td As Date
                    td = dr(3)
                    FromDateBox.Text = fd.ToString("yyyy-MM-dd")
                    ToDateBox.Text = td.ToString("yyyy-MM-dd")
                    MergeRemarkBox.Text = dr(4)

                End If
                dr.Close()
                con.Close()


            Catch ex As Exception
                con.Close()

                MsgBox("Error In getting details " & ex.ToString)
            End Try
        End If

    End Sub
End Class