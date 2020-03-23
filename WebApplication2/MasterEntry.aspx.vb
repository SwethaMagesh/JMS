Imports MySql.Data.MySqlClient

Public Class MasterEntry
    Inherits System.Web.UI.Page
    Dim constr As String = ConfigurationManager.ConnectionStrings("jmsConnectionString2").ConnectionString
    Dim con As New MySqlConnection(constr)
    Dim cmd As New MySqlCommand
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("username") Is Nothing Then
            Response.Redirect("~/Login.aspx", False)
        End If

        If Not Me.IsPostBack Then
            publisher.Items.Add("--Select--")
            con.Open()
            Dim cmd As New MySqlCommand("select pubName as test,pubid from publisher", con)
            Dim dr As MySqlDataReader
            dr = cmd.ExecuteReader()
            While dr.Read()
                Dim item As New ListItem()
                item.Text = dr(0).ToString()
                item.Value = dr(1).ToString()
                publisher.Items.Add(item)
            End While
            publisher.DataBind()
            con.Close()
        End If
    End Sub



    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles save.Click
        If code.Text IsNot "" And title.Text IsNot "" And periodicity.Text IsNot "" And placementNo.Text IsNot "" And publisher.Text IsNot "" Then


            Try
                con.Open()
                Dim cmdstr As String
                cmdstr = "insert into master (jcode,title, acqdate,remark,placementno,acchead,issn,status,lang,fileno,url,subject,pubid,jtype,category,periodType,periodicity) values ( " & code.Text & " , '" & jtitle.Text & "', '" & acqdate.Text & "', '" & remark.Text & "', '" & placementNo.Text & "', '" & acchead.Text & "', '" & issn.Text & "', '" & status.Text & "', '" & lang.Text & "', '" & fileNo.Text & "', '" & url.Text & "', '" & subject.Text & "',  " & publisher.SelectedValue & " , '" & jtype.SelectedValue & "', '" & category.SelectedValue & "', '" & periodType.SelectedValue & "','" & periodicity.SelectedValue & "' )"
                cmd = New MySqlCommand(cmdstr, con)
                cmd.ExecuteNonQuery()
                con.Close()


            Catch ex As MySqlException
                con.Close()

                MsgBox("error" & ex.ToString)
            End Try

            Try
                Dim cmdstr As String
                If prog1.Enabled Then
                    cmdstr = "insert into progname (jcode,programname) values (" & code.Text & ",'" & prog1.SelectedValue & "')"
                    progNDeptInsert(cmdstr)
                End If
                If prog2.Enabled Then
                    cmdstr = "insert into progname (jcode,programname) values (" & code.Text & ",'" & prog2.SelectedValue & "')"
                    progNDeptInsert(cmdstr)
                End If



                If prog3.Enabled Then
                    cmdstr = "insert into progname (jcode,programname) values (" & code.Text & ",'" & prog3.SelectedValue & "')"
                    progNDeptInsert(cmdstr)
                End If


                If prog4.Enabled Then
                    cmdstr = "insert into progname (jcode,programname) values (" & code.Text & ",'" & prog4.SelectedValue & "')"

                    progNDeptInsert(cmdstr)
                End If
                If prog5.Enabled Then
                    cmdstr = "insert into progname (jcode,programname) values (" & code.Text & ",'" & prog5.SelectedValue & "')"

                    progNDeptInsert(cmdstr)
                End If
                If Department1.Enabled Then
                    cmdstr = "insert into deptname (jcode,deptname) values (" & code.Text & ",'" & Department1.SelectedValue & "')"

                    progNDeptInsert(cmdstr)
                End If
                If Department2.Enabled Then
                    cmdstr = "insert into deptname (jcode,deptname) values (" & code.Text & ",'" & Department2.SelectedValue & "')"

                    progNDeptInsert(cmdstr)
                End If
                If Department3.Enabled Then
                    cmdstr = "insert into deptname (jcode,deptname) values (" & code.Text & ",'" & Department3.SelectedValue & "')"

                    progNDeptInsert(cmdstr)
                End If
                If Department4.Enabled Then
                    cmdstr = "insert into deptname (jcode,deptname) values (" & code.Text & ",'" & Department4.SelectedValue & "')"

                    progNDeptInsert(cmdstr)
                End If
                If Department5.Enabled Then
                    cmdstr = "insert into deptname (jcode,deptname) values (" & code.Text & ",'" & Department5.SelectedValue & "')"
                    progNDeptInsert(cmdstr)
                End If
            Catch ex As Exception

            End Try





        Else
            MsgBox("Fill all mandatory fields", 0, "Attention Required")
        End If
    End Sub
    Function progNDeptInsert(cmdstr As String)
        Try
            con.Open()
            cmd = New MySqlCommand(cmdstr, con)
            cmd.ExecuteNonQuery()
            con.Close()

        Catch ex As MySqlException
            con.Close()

            MsgBox("error" & ex.ToString)
        End Try
        Return 0
    End Function


    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles clearContents.Click
        code.Text = ""
        jtitle.Text = ""
        acqdate.Text = ""
        remark.Text = ""
        placementNo.Text = ""
        acchead.Text = ""
        issn.Text = ""
        status.ClearSelection()
        lang.Text = ""
        fileNo.Text = ""
        url.Text = ""
        subject.Text = ""
        periodicity.ClearSelection()
        publisher.ClearSelection()
        jtype.ClearSelection()
        category.ClearSelection()
        periodType.ClearSelection()
        progNo.Text = ""
        Department.Text = ""

    End Sub

    Protected Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        If code.Text IsNot "" And title.Text IsNot "" And periodicity.Text IsNot "" And placementNo.Text IsNot "" And publisher.Text IsNot "" Then

            Dim ch As Int16
            ch = MsgBox("Are you sure you want To update this entry?", 3, "Confirm Update")
            Select Case ch
                Case vbYes
                    Try
                        con.Open()
                        Dim cmdstr As String
                        cmdstr = "Update master set title='" & jtitle.Text & "', acqdate ='" & acqdate.Text & "', remark ='" & remark.Text & "', placementno ='" & placementNo.Text & "', acchead ='" & acchead.Text & "', issn ='" & issn.Text & "', status ='" & status.Text & "', lang ='" & lang.Text & "', fileno ='" & fileNo.Text & "', url ='" & url.Text & "', subject ='" & subject.Text & "', periodicity='" & periodicity.SelectedValue & "',pubid = " & publisher.SelectedValue & " , jtype = '" & jtype.SelectedValue & "' , category = '" & category.SelectedValue & "' ,periodType = '" & periodType.SelectedValue & "'  where jcode = " & code.Text
                        cmd = New MySqlCommand(cmdstr, con)
                        cmd.ExecuteNonQuery()
                        con.Close()
                        MsgBox("Modified successfully")
                        Button2_Click(Nothing, Nothing)

                    Catch ex As MySqlException
                        con.Close()

                        MsgBox("error" & ex.ToString)



                    End Try


            End Select


        Else
            MsgBox("Fill mandatory details", 0, "Missing Field")
        End If
    End Sub

    Protected Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        'delete
        If code.Text IsNot "" Then

            Dim ch As Int16
            ch = MsgBox("Are you sure you want to delete this entry?", 3, "Confirm Delete")
            Select Case ch
                Case vbYes
                    Try
                        con.Open()
                        Dim cmdstr As String
                        cmdstr = "Delete from master where jcode = " & code.Text
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

    Protected Sub code_TextChanged(sender As Object, e As EventArgs) Handles code.TextChanged
        Try
            Dim var As Integer
            con.Open()
            Dim cmdstr As String
            Dim dr As MySqlDataReader
            cmdstr = "select title,  acqdate,remark,placementno,acchead,issn,status,lang,fileno,url,subject,pubid,jtype,category,periodType,periodicity from master where jcode =" & Val(code.Text)
            cmd = New MySqlCommand(cmdstr, con)
            dr = cmd.ExecuteReader()
            While dr.Read()
                title.Text = dr(0).ToString
                acqdate.Text = dr(1).ToString
                remark.Text = dr(2).ToString
                placementNo.Text = dr(3).ToString
                acchead.Text = dr(4).ToString
                issn.Text = dr(5).ToString
                If dr(6).ToString = "Available" Then
                    status.SelectedIndex = 0
                ElseIf dr(6).ToString = "Expired" Then
                    status.SelectedIndex = 1
                End If
                lang.Text = dr(7).ToString
                fileNo.Text = dr(8).ToString
                url.Text = dr(9).ToString
                subject.Text = dr(10).ToString

                Select Case dr(11).ToString
                    Case "Weekly"
                    Case ""
                End Select
                periodicity.SelectedIndex = var
                publisher.SelectedIndex = 0
                jtype.SelectedIndex = 0
                category.SelectedIndex = 0
                periodType.SelectedIndex = 0
            End While
            dr.Close()
            con.Close()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MsgBox(ex.ToString & "Database error")
        End Try
        con.Close()

        Try
            con.Open()
            Dim cmdstr As String
            Dim dr As MySqlDataReader
            cmdstr = ""
            cmd = New MySqlCommand(cmdstr, con)
            dr = cmd.ExecuteReader()
            While dr.Read()

            End While
            dr.Close()
            con.close()
        Catch ex As MySqlException
            MsgBox(ex.ToString & "Database error")
        End Try
        con.Close()
    End Sub

    Protected Sub addProg_Click(sender As Object, e As EventArgs) Handles addProg.Click
        Dim No_prog As Int16
        No_prog = progNo.Text
        prog1.Enabled = False
        prog2.Enabled = False
        prog3.Enabled = False
        prog4.Enabled = False
        prog5.Enabled = False
        prog1.Visible = False
        prog2.Visible = False
        prog3.Visible = False
        prog4.Visible = False
        prog5.Visible = False
        Select Case No_prog
            Case 1
                prog1.Enabled = True
                prog1.Visible = True

            Case 2
                prog1.Enabled = True
                prog2.Enabled = True
                prog1.Visible = True
                prog2.Visible = True

            Case 3
                prog1.Enabled = True
                prog2.Enabled = True
                prog3.Enabled = True
                prog1.Visible = True
                prog2.Visible = True
                prog3.Visible = True

            Case 4
                prog1.Enabled = True
                prog2.Enabled = True
                prog3.Enabled = True
                prog4.Enabled = True
                prog1.Visible = True
                prog2.Visible = True
                prog3.Visible = True
                prog4.Visible = True
            Case 5
                prog1.Enabled = True
                prog2.Enabled = True
                prog3.Enabled = True
                prog4.Enabled = True
                prog5.Enabled = True
                prog1.Visible = True
                prog2.Visible = True
                prog3.Visible = True
                prog4.Visible = True
                prog5.Visible = True
            Case Else
                progNo.Text = ""
        End Select
    End Sub

    Protected Sub Departmentadd_Click(sender As Object, e As EventArgs) Handles Departmentadd.Click
        Dim No_department As Int16
        No_department = Department.Text
        Department1.Enabled = False
        Department2.Enabled = False
        Department3.Enabled = False
        Department4.Enabled = False
        Department5.Enabled = False
        Select Case No_department
            Case 1
                Department1.Enabled = True

            Case 2
                Department1.Enabled = True
                Department2.Enabled = True

            Case 3
                Department1.Enabled = True
                Department2.Enabled = True
                Department3.Enabled = True

            Case 4
                Department1.Enabled = True
                Department2.Enabled = True
                Department3.Enabled = True
                Department4.Enabled = True
            Case 5
                Department1.Enabled = True
                Department2.Enabled = True
                Department3.Enabled = True
                Department4.Enabled = True
                Department5.Enabled = True
            Case Else
                Department.Text = ""
        End Select
    End Sub
End Class