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
                cmdstr = "Insert into inwardentry (jcode,volno,issueno,fromdate,todate,mergeremark) values (" & codeBox.Text & "," & VolNoBox.Text & "," & IssueNoBox.Text & ",'" & FromDateBox.Text & "','" & ToDateBox.Text & "','" & MergeRemarkBox.Text & "')"
                cmd = New MySqlCommand(cmdstr, con)
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Saved successfully")
                Button2_Click(Nothing, Nothing)

            Catch ex As MySqlException
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
        FromDateBox.Text = ""
        ToDateBox.Text = ""
        MergeRemarkBox.Text = ""
    End Sub

    Protected Sub codeBox_TextChanged(sender As Object, e As EventArgs) Handles codeBox.TextChanged
        'needs changes
        Try
            con.Open()
            Dim command As String
            command = "select m.title,i.volno,i.issueno from master m,inwardentry i where m.code =" & codeBox.Text & " and i.jcode =" & codeBox.Text & " order by i.volno desc,i.issueno desc limit 1;"
            cmd = New MySqlCommand(command, con)
            Dim dr As MySqlDataReader
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                TitleBox.Text = dr(0)
                VolNoBox.Text = dr(1)
                IssueNoBox.Text = dr(2)

            End If
            con.Close()

        Catch ex As Exception
            MsgBox("Error In getting title " & ex.ToString)
        End Try
    End Sub

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

                        MsgBox("error" & ex.ToString)


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

                        MsgBox("error" & ex.ToString)


                    End Try


            End Select


        Else
            MsgBox("Fill mandatory fields", 0, "Missing Field")
        End If

    End Sub
End Class