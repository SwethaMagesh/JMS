Imports MySql.Data.MySqlClient
Public Class WebForm3
    Inherits System.Web.UI.Page
    Dim constr As String = ConfigurationManager.ConnectionStrings("jmsConnectionString2").ConnectionString
    Dim con As New MySqlConnection(constr)
    Dim cmd As New MySqlCommand
    Dim cmd1 As New MySqlCommand

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'subscribedFrom.Items.Clear()
        If Not Me.IsPostBack Then
            subscribedFrom.Items.Add("--Select--")
            Try
                con.Open()
                Dim cmd As New MySqlCommand("select pubName as test from publisher", con)
                Dim dr As MySqlDataReader
                dr = cmd.ExecuteReader()
                While dr.Read()
                    subscribedFrom.Items.Add(dr(0).ToString)
                End While
                subscribedFrom.DataBind()
                con.Close()

            Catch ex As MySql.Data.MySqlClient.MySqlException
                MsgBox("Error " & ex.ToString)
            End Try

        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If code.Text = "" Or fromDate.Text = "" Or toDate.Text = "" Then
            MsgBox("Fill all mandatory fields", 0, "Attention Required")
        Else
            Try
                con.Open()
                Dim commandstr As String
                commandstr = "insert into subscription (code, fromDate, toDate, subscribedFrom,  remarks, subscribedOn,paymentMode,paymentDetails,voucherRef) values (" & code.Text & ",'" & fromDate.Text & "','" & toDate.Text & "','" & subscribedFrom.SelectedItem.ToString & "','" & remarks.Text & "','" & subscribedOn.Text & "','" & ModeRadioButton.Text & "','" & paymentDetails.Text & "','" & VoucherRef.Text & "')"
                cmd = New MySqlCommand(commandstr, con)
                MsgBox(subscribedFrom.SelectedItem.ToString)
                cmd.ExecuteNonQuery()
                commandstr = "update master  set  fromDate='" & fromDate.Text & "', toDate='" & toDate.Text & "', subscribedFrom='" & subscribedFrom.Text & "' where code = " & Val(code.Text)
                cmd1 = New MySqlCommand(commandstr, con)
                cmd1.ExecuteNonQuery()
                MsgBox("Saved successfully", 0, "Saved")
                con.Close()
            Catch ex As MySql.Data.MySqlClient.MySqlException
                If ex.Number = 3819 Then
                    MsgBox("Check the from and to dates provided")
                Else
                    MsgBox("database error" & ex.ToString)
                    con.Close()

                End If


            End Try

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
                ' subscribedFrom.text = dr(0).ToString

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
        subscribedFrom.ClearSelection()
        subscribedOn.Text = ""
        paymentDetails.Text = ""
        VoucherRef.Text = ""
        remarks.Text = ""

    End Sub
End Class