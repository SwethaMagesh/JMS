Imports MySql.Data.MySqlClient

Public Class _Default
    Inherits Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load

    End Sub

    Public Shared Function GetChartData() As List(Of Object)
        Dim query As String = "SELECT Periodicity, COUNT(*) Total FROM master GROUP BY Periodicity"
        Dim constr As String = ConfigurationManager.ConnectionStrings("jmsConnectionString2").ConnectionString
        Dim con As New MySqlConnection(constr)
        Dim chartData As New List(Of Object)()
        chartData.Add(New Object() {"Periodicity", "Total"})
        Using cmd As New MySqlCommand(query)
            cmd.CommandType = CommandType.Text
            con.Open()
            Using sdr As MySqlDataReader = cmd.ExecuteReader()
                While sdr.Read()
                    chartData.Add(New Object() {sdr("Periodicity"), sdr("Total")})
                End While
            End Using
            con.Close()
            Return chartData
        End Using
    End Function
End Class