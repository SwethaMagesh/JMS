Imports MySql.Data.MySqlClient
Public Class WebForm3
    Inherits System.Web.UI.Page
    Dim constr As String = ConfigurationManager.ConnectionStrings("jmsConnectionString2").ConnectionString
    Dim con As New MySqlConnection(constr)
    Dim cmd As New MySqlCommand
    Dim cmd1 As New MySqlCommand

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not Me.IsPostBack Then
            fromDate.Text = Today.ToString("yyyy-MM-dd")
            paymentDate.Text = Today.ToString("yyyy-MM-dd")
            vendor.Items.Add("--Select--")
            Try
                con.Open()
                Dim cmd As New MySqlCommand("select pubName,pubid from publisher", con)
                Dim dr As MySqlDataReader
                dr = cmd.ExecuteReader()
                While dr.Read()
                    Dim item As New ListItem()
                    item.Text = dr(0).ToString()
                    item.Value = dr(1).ToString()
                    vendor.Items.Add(item)

                End While
                vendor.DataBind()
                con.Close()

            Catch ex As MySql.Data.MySqlClient.MySqlException
                MsgBox("Error " & ex.ToString)
            End Try
            SubscriptionTable()

        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles save.Click
        If code.Text = "" Or fromDate.Text = "" Or toDate.Text = "" Or paymentDate.Text = "" Or vendor.Text = "" Or amt.Text = "" Then
            MsgBox("Fill all mandatory fields", 0, "Attention Required")
        Else
            Try
                con.Open()
                Dim commandstr As String
                commandstr = "insert into subscription (jcode, fromDate, toDate, vendorid,  remarks, paymentDate,paymentMode,paymentDetails,voucherRef,amount) values (" & code.Text & ",'" & fromDate.Text & "','" & toDate.Text & "'," & vendor.SelectedValue & ",'" & remarks.Text & "','" & paymentDate.Text & "','" & ModeRadioButton.Text & "','" & paymentDetails.Text & "','" & VoucherRef.Text & "'," & amt.Text & " )"
                cmd = New MySqlCommand(commandstr, con)
                cmd.ExecuteNonQuery()
                MsgBox("Saved successfully", 0, "Saved")
                con.Close()
                Button2_Click(Nothing, Nothing)
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

    Protected Sub updateSave_Click(sender As Object, e As EventArgs) Handles updateSave.Click
        If code.Text IsNot "" And fromDate.Text IsNot "" And toDate.Text IsNot "" And paymentDate.Text IsNot "" And
            amt.Text IsNot "" And vendor.Text IsNot "" Then

            Dim ch As Int16
            ch = MsgBox("Are you sure you want To update this entry?", 3, "Confirm Update")
            Select Case ch
                Case vbYes
                    Try
                        con.Open()
                        Dim cmdstr As String
                        cmdstr = "update subscription  set fromdate = '" & fromDate.Text & "',todate='" & toDate.Text & "',paymentmode='" & ModeRadioButton.Text & "', paymentdetails='" & paymentDetails.Text & "' , voucherref='" & VoucherRef.Text & "',vendorid=" & vendor.SelectedValue & ", amount =" & amt.Text & ",remarks ='" & remarks.Text & "' where jcode =" & code.Text & " and paymentdate='" & paymentDate.Text & "'"
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

    Protected Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        If code.Text IsNot "" And fromDate.Text IsNot "" And toDate.Text IsNot "" And paymentDate.Text IsNot "" And
            amt.Text IsNot "" And vendor.Text IsNot "" Then

            Dim ch As Int16
            ch = MsgBox("Are you sure you want to delete this entry?", 3, "Confirm Delete")
            Select Case ch
                Case vbYes
                    Try
                        con.Open()
                        Dim cmdstr As String
                        cmdstr = "delete from subscription where jcode= " & code.Text & "and paymentdate='" & paymentDate.Text & "'"
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

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles clear.Click
        code.Text = ""
        title.Text = ""
        toDate.Text = ""
        ModeRadioButton.ClearSelection()
        vendor.ClearSelection()
        fromDate.Text = Today.ToString("yyyy-mm-dd")
        paymentDate.Text = Today.ToString("yyyy-mm-dd")
        paymentDetails.Text = ""
        VoucherRef.Text = ""
        remarks.Text = ""
        amt.Text = ""
        SubscriptionTable()
    End Sub

    Function SubscriptionTable()
        Try
            con.Open()
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable()
            Dim cmd As New MySqlCommand
            Dim cmdstr As String
            cmdstr = "select jcode as 'Journal Code',title as 'Title',date_format(fromDate,'%d-%m-%Y') as FromDate,date_format(toDate,'%d-%m-%Y') as ToDate,PaymentMode,PaymentDetails,VendorID,pubname as 'Vendor Name',Amount,date_format(paymentDate,'%d-%m-%Y') as PaymentDate,Remarks from subscription natural join master inner join publisher where publisher.pubid = subscription.vendorid"
            cmd = New MySqlCommand(cmdstr, con)
            da = New MySqlDataAdapter(cmd)
            da.Fill(dt)
            GridView1.DataSource = dt
            GridView1.DataBind()
            con.Close()

        Catch ex As Exception
            MsgBox("Error" & ex.ToString)
        End Try
    End Function

    Protected Sub code_TextChanged(sender As Object, e As EventArgs) Handles code.TextChanged

        Try
            con.Open()
            Dim cmdstr As String
            Dim dr As MySqlDataReader
            cmdstr = "select title from master where jcode =" & Val(code.Text)
            cmd = New MySqlCommand(cmdstr, con)
            dr = cmd.ExecuteReader()
            While dr.Read()
                title.Text = dr(0).ToString
            End While
            dr.Close()
            con.Close()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MsgBox(ex.ToString & "Database error")
        End Try
    End Sub

    Protected Sub fromDate_TextChanged(sender As Object, e As EventArgs) Handles fromDate.TextChanged
        Dim fd As Date
        'needs work
        Select Case period.SelectedValue
            Case 0

            Case 1
                fd.AddMonths(6)
            Case 2
                fd.AddYears(1)
            Case 3
                fd.AddYears(2)
        End Select
        ' toDate.Text = fd.ToString("yyyy-mm-dd")
        'toDate.Text = fromDate.ToString("yyyy-mm-dd")
    End Sub
End Class