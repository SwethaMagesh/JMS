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
        If True Then


            Try
                con.Open()
                Dim cmdstr As String
                cmdstr = "insert into master (jcode,title, acqdate,remark,placementno,acchead,issn,status,lang,fileno,url,subject,pubid,jtype,category,periodType,periodicity) values ( " & code.Text & " , '" & jtitle.Text & "', '" & acqdate.Text & "', '" & remark.Text & "', '" & placementNo.Text & "', '" & acchead.Text & "', '" & issn.Text & "', '" & status.Text & "', '" & lang.Text & "', '" & fileNo.Text & "', '" & url.Text & "', '" & subject.Text & "',  " & publisher.SelectedValue & " , '" & jtype.SelectedValue & "', '" & category.SelectedValue & "', '" & periodType.SelectedValue & "','" & periodicity.SelectedValue & "' )"
                cmd = New MySqlCommand(cmdstr, con)
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Saved successfully")
                Button2_Click(Nothing, Nothing)

            Catch ex As MySqlException
                con.Close()

                MsgBox("error" & ex.ToString)


            End Try
        Else
            MsgBox("Fill all mandatory fields", 0, "Attention Required")
        End If
    End Sub

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
        If True Then

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

End Class