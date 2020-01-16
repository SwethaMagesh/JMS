<%@ Page Title="Renewal Page"  Language="vb" AutoEventWireup="false" CodeBehind="Renewal.aspx.vb" Inherits="WebApplication2.WebForm4"  MasterPageFile="~/Site.Master" %>

<asp:Content ContentPlaceHolderID="MainContent" ID="BodyContext" runat="server">
    <style type="text/css">
    .center_button
    {
        text-align:center;
        align-self:center;
    }
    </style>

         <h2><%: Title %>.</h2>

        <div class ="center_button">
             <asp:Button ID="Button2" runat="server" Text="Load Renewals Approaching" />
              <br />
              <br />
        </div>
        <div class="center_button">
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>
   
    </asp:Content>