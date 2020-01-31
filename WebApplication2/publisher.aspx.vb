Imports MySql.Data.MySqlClient


Public Class publisher
    Inherits System.Web.UI.Page
    Dim constr As String = ConfigurationManager.ConnectionStrings("jmsConnectionString2").ConnectionString
    Dim con As New MySqlConnection(constr)

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

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
            MsgBox("Saved successfully")
            clearContents_Click(Nothing, Nothing)
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

    Protected Sub deleteRecord_Click(sender As Object, e As EventArgs) Handles deleteRecord.Click
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
End Class