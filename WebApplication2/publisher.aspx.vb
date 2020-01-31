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
                If Not Me.IsPostBack Then
                    pubId.Text = newid
                    pubId_TextChanged(Nothing, Nothing)
                End If


            End If
                dr.Close()
                con.Close()
            Catch ex As MySqlException
                MsgBox("Error" & ex.ToString)
            End Try


    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Save.Click
        If pubName.Text = "" Or address.Text = "" Or pincode.Text = "" Then
            MsgBox("Please fill the mandatory fields", 0, "Attention Required")
        End If
        Try
            con.Open()
            Dim cmd As MySqlCommand
            Dim valuestr As String
            valuestr = "insert into publisher(pubName,address,pincode,country,email,phone,fax,website,contactPerson) values('" & pubName.Text & "','" & address.Text & "'," & Val(pincode.Text) & ",'" & country.Text & "','" & email.Text & "'," & Val(phone.Text) & "," & Val(fax.Text) & ",'" & website.Text & "','" & contactPerson.Text & "')"
            cmd = New MySqlCommand(valuestr, con)
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MsgBox(ex.ToString)
        End Try

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
        contactPerson.Text = ""
    End Sub

    Protected Sub pubId_TextChanged(sender As Object, e As EventArgs) Handles pubId.TextChanged


        If pubId.Text >= newid Then
            clearContents_Click(Nothing, Nothing)
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
                cmdstr = "select pubname , address,pincode,phone,email,website,country,fax,contactPerson from publisher where pubid = " & pubId.Text
                cmd = New MySqlCommand(cmdstr, con)
                Dim dr As MySqlDataReader
                dr = cmd.ExecuteReader()
                If dr.Read() Then
                    clearContents_Click(Nothing, Nothing)
                    pubName.Text = dr(0)
                    address.Text = dr(1)
                    pincode.Text = dr(2)
                    phone.Text = dr(3)
                    email.Text = dr(4)
                    website.Text = dr(5)
                    country.Text = dr(6)
                    fax.Text = dr(7)
                    contactPerson.Text = dr(8)

                End If
                dr.Close()
                con.Close()
            Catch ex As MySqlException
                MsgBox(ex.ToString)
            Catch other As Exception
                MsgBox(other.ToString)
            End Try

        End If


    End Sub

    Protected Sub deleteRecord_Click(sender As Object, e As EventArgs) Handles deleteRecord.Click
        If pubId.Text = "" Then
            MsgBox("Enter Pubid", 0, "Mandatory Field")
        Else
            Dim ch As Int16
            ch = MsgBox("Are you sure you want to delete this entry?", 3, "Confirm Delete")
            If ch = vbYesNo Then
                Try
                    con.Open()
                    Dim cmd As MySqlCommand
                    Dim cmdstr As String
                    cmdstr = "Delete from publisher where pubid = " & pubId.Text
                    cmd = New MySqlCommand(cmdstr, con)
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MsgBox("Deleted successfully")
                    clearContents_Click(Nothing, Nothing)

                Catch ex As MySqlException

                    MsgBox("error" & ex.ToString)


                End Try

            End If


        End If

    End Sub
End Class