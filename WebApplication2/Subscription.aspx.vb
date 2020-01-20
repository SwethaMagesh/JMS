Imports MySql.Data.MySqlClient

Public Class WebForm3
    Inherits System.Web.UI.Page
    Dim con As New MySqlConnection("server=127.0.0.1;user id=root;pwd=sanjay2001;database=jms;persistsecurityinfo=True")
    Dim cmd As New MySqlCommand
    Dim cmd1 As New MySqlCommand

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load




    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If code.Text = "" Or fromDate.Text = "" Or toDate.Text = "" Then
            MsgBox("Fill all mandatory fields")
        End If
        con.Open()
        Dim commandstr As String
        commandstr = "insert into subscription (code, fromDate, toDate, subscribedFrom,  remarks, subscribedOn,paymentMode,paymentDetails,voucherRef) values (" & code.Text & ",'" & fromDate.Text & "','" & toDate.Text & "','" & subscribedTo.Text & "','" & remarks.Text & "','" & subscribedOn.Text & "','" & ModeRadioButton.Text & "','" & paymentDetails.Text & "','" & VoucherRef.Text & "')"
        cmd = New MySqlCommand(commandstr, con)
        cmd.ExecuteNonQuery()
        commandstr = "update master  set  fromDate='" & fromDate.Text & "', toDate='" & toDate.Text & "', subscribedFrom='" & subscribedTo.Text & "' where code = " & Val(code.Text)
        cmd1 = New MySqlCommand(commandstr, con)
        cmd1.ExecuteNonQuery()
        con.Close()

    End Sub

    Protected Sub code_TextChanged(sender As Object, e As EventArgs) Handles code.TextChanged
        con.Open()
        Dim cmdstr As String
        Dim dr As MySqlDataReader
        cmdstr = "select title from master where code =" & Val(code.Text)
        cmd = New MySqlCommand(cmdstr, con)
        dr = cmd.ExecuteReader()
        While dr.Read()
            title.Text = dr(0).ToString
        End While
        con.Close()
    End Sub




End Class