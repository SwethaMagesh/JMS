Imports MySql.Data.MySqlClient


Public Class publisher
    Inherits System.Web.UI.Page
    Dim constr As String = ConfigurationManager.ConnectionStrings("jmsConnectionString2").ConnectionString
    Dim con As New MySqlConnection(constr)
    Dim newid As Int16


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            con.Open()
            Dim cmd As New MySqlCommand
            Dim cmdstr As String
            cmdstr = "select max(pubid)+1 from publisher;"
            cmd = New MySqlCommand(cmdstr, con)
            Dim dr As MySqlDataReader
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                newid = dr(0)
            Else
                newid = 1
                pubId.Text = 1
            End If
            dr.Close()
        Catch ex As MySqlException
            MsgBox("Error" & ex.ToString)
        Catch other As Exception
            MsgBox(other.ToString)
        End Try
        con.Close()
        PublisherTable()

        If Not Me.IsPostBack Then
            pubId.Text = newid
        End If


    End Sub

    Function PublisherTable()
        Try
            con.Open()
            Dim da As MySqlDataAdapter
            Dim dt As New DataTable()
            Dim cmd As New MySqlCommand
            Dim cmdstr As String
            cmdstr = "select pubid as 'Publisher ID',pubname as 'Publisher Name',Address,Pincode,Phone,Email,Website,Country,Fax,agentname as 'Agent Name' from publisher"
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

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Save.Click
        If pubName.Text = "" Then
            MsgBox("Please fill the mandatory fields", 0, "Attention Required")
        Else

            Try
                con.Open()
                Dim cmd As MySqlCommand
                Dim valuestr As String
                valuestr = "insert into publisher(pubid,pubName,address,pincode,country,email,phone,fax,website,agentname) values(" & pubId.Text & ",'" & pubName.Text & "','" & address.Text & "'," & Val(pincode.Text) & ",'" & country.Text & "','" & email.Text & "','" & phone.Text & "'," & Val(fax.Text) & ",'" & website.Text & "','" & agentname.Text & "')"
                cmd = New MySqlCommand(valuestr, con)
                cmd.ExecuteNonQuery()
                MsgBox("Saved successfully")
                con.Close()
                If pubId.Text = newid Then
                    newid = newid + 1
                End If
                clearContents_Click(Nothing, Nothing)

                pubId.Text = newid
            Catch ex As MySql.Data.MySqlClient.MySqlException
                MsgBox(ex.ToString)
            Catch other As Exception
                MsgBox(other.ToString)
            End Try
        End If
    End Sub

    Protected Sub clearContents_Click(sender As Object, e As EventArgs) Handles clearContents.Click
        pubName.Text = ""
        address.Text = ""
        pincode.Text = ""
        phone.Text = ""
        email.Text = ""
        website.Text = ""
        country.Text = ""
        fax.Text = ""
        agentname.Text = ""
        pubId.Text = newid
        PublisherTable()
    End Sub

    Protected Sub pubId_TextChanged(sender As Object, e As EventArgs) Handles pubId.TextChanged

        Try


            If pubId.Text >= newid Then
                pubName.Text = ""
                address.Text = ""
                pincode.Text = ""
                phone.Text = ""
                email.Text = ""
                website.Text = ""
                country.Text = ""
                fax.Text = ""
                agentname.Text = ""
                Save.Enabled = True
                Save.Visible = True
                update.Enabled = False
                update.Visible = False
                deleteRecord.Visible = False
                deleteRecord.Enabled = False

            Else
                Save.Enabled = False
                Save.Visible = False
                update.Enabled = True
                update.Visible = True
                deleteRecord.Visible = True
                deleteRecord.Enabled = True
                Try
                    con.Open()
                    Dim cmd As New MySqlCommand
                    Dim cmdstr As String
                    cmdstr = "select pubname,address,pincode,phone,email,website,country,fax,agentname from publisher where pubid = " & pubId.Text
                    cmd = New MySqlCommand(cmdstr, con)
                    Dim dr As MySqlDataReader
                    dr = cmd.ExecuteReader()
                    pubName.Text = ""
                    address.Text = ""
                    pincode.Text = ""
                    phone.Text = ""
                    email.Text = ""
                    website.Text = ""
                    country.Text = ""
                    fax.Text = ""
                    agentname.Text = ""
                    If dr.Read() Then

                        pubName.Text = dr(0).ToString
                        address.Text = dr(1).ToString
                        pincode.Text = dr(2).ToString
                        phone.Text = dr(3).ToString
                        email.Text = dr(4).ToString
                        website.Text = dr(5).ToString
                        country.Text = dr(6).ToString
                        fax.Text = dr(7).ToString
                        agentname.Text = dr(8).ToString
                    Else
                        MsgBox("No such publisher with given id")
                        Save.Enabled = True
                        Save.Visible = True
                        update.Enabled = False
                        update.Visible = False
                        deleteRecord.Visible = False
                        deleteRecord.Enabled = False

                    End If
                    dr.Close()
                    con.Close()

                Catch ex As MySqlException
                    MsgBox(ex.ToString)
                Catch other As Exception
                    MsgBox(other.ToString)
                End Try

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Protected Sub deleteRecord_Click(sender As Object, e As EventArgs) Handles deleteRecord.Click
        If pubId.Text = "" Then
            MsgBox("Enter Pubid", 0, "Mandatory Field")
        Else
            Dim ch As Int16
            ch = MsgBox("Are you sure you want to delete this entry?", 3, "Confirm Delete")
            If ch = vbYes Then
                Try
                    con.Open()
                    Dim cmd As MySqlCommand
                    Dim cmdstr As String
                    cmdstr = "delete from publisher where pubid=" & pubId.Text
                    cmd = New MySqlCommand(cmdstr, con)
                    cmd.ExecuteNonQuery()

                    con.Close()
                    MsgBox("Deleted successfully")
                    If pubId.Text = newid Then
                        newid = newid - 1
                    End If
                    clearContents_Click(Nothing, Nothing)


                Catch ex As MySqlException

                    MsgBox("error" & ex.ToString)


                End Try

            End If


        End If

    End Sub

    Protected Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        If pubId.Text = "" Then
            MsgBox("Enter Pubid", 0, "Mandatory Field")
        Else
            Dim ch As Int16
            ch = MsgBox("Are you sure you want to update this entry?", 3, "Confirm update")
            If ch = vbYes Then
                Try
                    con.Open()
                    Dim cmd As MySqlCommand
                    Dim cmdstr As String
                    cmdstr = "update publisher set pubname='" & pubName.Text & "',address='" & address.Text & "',pincode=" & pincode.Text & ",country='" & country.Text & "',email='" & email.Text & "',phone= '" & phone.Text & "',fax= " & fax.Text & ",website='" & website.Text & "',agentname='" & agentname.Text & "'  where pubid=" & pubId.Text
                    cmd = New MySqlCommand(cmdstr, con)
                    cmd.ExecuteNonQuery()

                    con.Close()
                    MsgBox("Modified successfully")
                    clearContents_Click(Nothing, Nothing)


                Catch ex As MySqlException

                    MsgBox("error" & ex.ToString)


                End Try

            End If


        End If
    End Sub
End Class