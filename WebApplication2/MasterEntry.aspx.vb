Imports MySql.Data.MySqlClient

Public Class WebForm2
    Inherits System.Web.UI.Page
    Dim constr As String = ConfigurationManager.ConnectionStrings("jmsConnectionString2").ConnectionString
    Dim con1 As New MySqlConnection(constr)
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Me.IsPostBack Then
            publisher.Items.Add("--Select--")
            con1.Open()
            Dim cmd As New MySqlCommand("select pubName as test from publisher", con1)
            Dim dr As MySqlDataReader
            dr = cmd.ExecuteReader()
            While dr.Read()
                publisher.Items.Add(dr(0).ToString)
            End While
            publisher.DataBind()
            con1.Close()
        End If
    End Sub



    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles save.Click
        If code.Text = "" Or title.Text = "" Or periodicity.SelectedItem.ToString = "" Or placementNo.Text = "" Or publisher.SelectedItem.ToString = "" Then
            MsgBox("Please fill all required fields", 0, "Attention Required")
        Else
            con1.Open()
            Dim cmd As MySqlCommand
            Dim valuestr As String
            valuestr = "insert into master (code,title,acqDate,periodicity,remark,placementNo,subject,dept,publisher,issn) values(" & Val(code.Text) & ",'" & title.Text & "','" & acqdate.Text & "','" & periodicity.SelectedItem.ToString & " ','" & remark.Text & "','" & placementNo.Text & "','" & subject.Text & "','" & acchead.Text & "','" & publisher.SelectedItem.ToString & "','" & issn.Text & "')"

            cmd = New MySqlCommand(valuestr, con1)
            cmd.ExecuteNonQuery()
            con1.Close()
            MsgBox("Saved Successfully", 0, "Saved")
        End If
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles clearContents.Click
        code.Text = ""
        title.Text = ""
        acqdate.Text = ""
        periodicity.ClearSelection()
        remark.Text = ""
        placementNo.Text = ""
        subject.Text = ""
        acchead.Text = ""
        publisher.ClearSelection()
        issn.Text = ""
    End Sub


End Class