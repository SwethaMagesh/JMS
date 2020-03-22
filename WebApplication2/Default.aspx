<%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="WebApplication2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.8.3/jquery.min.js"></script>
<script type="text/javascript" src="https://www.google.com/jsapi"></script>
<script type="text/javascript">
    google.load("visualization", "1", { packages: ["corechart"] });
    google.setOnLoadCallback(drawChart);
    function drawChart() {
        var options = {
            title: 'USA City Distribution'
        };
        $.ajax({
            type: "POST",
            url: "Default.aspx/GetChartData",
            data: '{}',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (r) {
                var data = google.visualization.arrayToDataTable(r.d);
                var chart = new google.visualization.PieChart($("#chart")[0]);
                chart.draw(data, options);
            },
            failure: function (r) {
                alert(r.d);
            },
            error: function (r) {
                alert(r.d);
            }
        });
    }
</script>

<div id="chart" style="width: 900px; height: 500px;">
</div>


</asp:Content>
