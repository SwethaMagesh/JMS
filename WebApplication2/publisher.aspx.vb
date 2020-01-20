Imports MySql.Data.MySqlClient


Public Class publisher
    Inherits System.Web.UI.Page
    Dim con As New MySqlConnection("server=127.0.01;user id=root;pwd=sanjay2001;database=jms")

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Save.Click
        If pubName.Text = "" Or address.Text = "" Or pincode.Text = "" Then
            MsgBox("Please fill the mandatory fields", 0, "Attention Required")
        End If
        con.Open()
        Dim cmd As MySqlCommand
        Dim valuestr As String
        valuestr = "insert into publisher(pubName,address,pincode,country,email,phone,fax,website,contactPerson) values('" & pubName.Text & "','" & address.Text & "'," & Val(pincode.Text) & ",'" & country.Text & "','" & email.Text & "'," & Val(phone.Text) & "," & Val(fax.Text) & ",'" & website.Text & "','" & contactPerson.Text & "')"
        cmd = New MySqlCommand(valuestr, con)
        cmd.ExecuteNonQuery()
        con.Close()
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
End Class