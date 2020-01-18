Imports MySql.Data.MySqlClient

Public Class WebForm3
    Inherits System.Web.UI.Page
    Dim con As New MySqlConnection("server=127.0.0.1;user id=root;pwd=swetha2000;database=jms;persistsecurityinfo=True")
    Dim cmd As New MySqlCommand
    Dim cmd1 As New MySqlCommand

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        con.Open()
        Dim cmd As New MySqlCommand("select pubName as test from publisher", con)
        Dim dr As MySqlDataReader
        dr = cmd.ExecuteReader()
        While dr.Read()
            subscribedFrom.Items.Add(dr(0).ToString)
        End While
        subscribedFrom.DataBind()
        con.Close()



    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If code.Text = "" Or fromDate.Text = "" Or toDate.Text = "" Then
            MsgBox("Fill all mandatory fields")
        Else
            Try
                con.Open()
                Dim commandstr As String
                commandstr = "insert into subscription (code, fromDate, toDate, subscribedFrom,  remarks, subscribedOn,paymentMode,paymentDetails,voucherRef) values (" & code.Text & ",'" & fromDate.Text & "','" & toDate.Text & "','" & subscribedFrom.Text & "','" & remarks.Text & "','" & subscribedOn.Text & "','" & ModeRadioButton.Text & "','" & paymentDetails.Text & "','" & VoucherRef.Text & "')"
                cmd = New MySqlCommand(commandstr, con)
                cmd.ExecuteNonQuery()
                commandstr = "update master  set  fromDate='" & fromDate.Text & "', toDate='" & toDate.Text & "', subscribedFrom='" & subscribedFrom.Text & "' where code = " & Val(code.Text)
                cmd1 = New MySqlCommand(commandstr, con)
                cmd1.ExecuteNonQuery()
                con.Close()
            Catch ex As Exception
                MsgBox("database error" & ex.ToString)
                con.Close()

            End Try
            MsgBox("Saved successfully")
        End If




    End Sub

    Protected Sub code_TextChanged(sender As Object, e As EventArgs) Handles code.TextChanged

        Try
            con.Open()
            Dim cmdstr As String
            Dim dr As MySqlDataReader
            cmdstr = "select title from master where code =" & Val(code.Text)
            cmd = New MySqlCommand(cmdstr, con)
            dr = cmd.ExecuteReader()
            While dr.Read()
                title.Text = dr(0).ToString
            End While
            dr.Close()
            cmdstr = "select subscribedFrom,subscribedOn from subscription where code =" & code.Text & " order by subscribedOn desc limit 1"
            cmd = New MySqlCommand(cmdstr, con)
            dr = cmd.ExecuteReader()
            While dr.Read()
                ' fromDate.Text = dr(0).ToString
                ' toDate.Text = dr(1).ToString
                subscribedFrom.Text = dr(0).ToString

            End While

            con.Close()

        Catch ex As MySql.Data.MySqlClient.MySqlException
            MsgBox(ex.ToString & "Database error")

        End Try

    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        code.Text = ""
        title.Text = ""
        fromDate.Text = ""
        toDate.Text = ""
        ModeRadioButton.ClearSelection()
        subscribedFrom.Text = ""
        subscribedOn.Text = ""
        paymentDetails.Text = ""
        VoucherRef.Text = ""
        remarks.Text = ""

    End Sub
End Class