<%@ Page Title="Report Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Report1.aspx.vb" Inherits="WebApplication2.Report1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  
        <div style="height: 167px">
            <table style="width: 100%">
                <tr>
                    <td style="width: 312px">
                        <br />
                        Show :&nbsp;
                        <asp:DropDownList ID="List1" runat="server">
                            <asp:ListItem Value="0">Count</asp:ListItem>
                            <asp:ListItem Value="1">List</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td style="width: 439px">
                        <br />
                        Of :&nbsp;
                        <asp:DropDownList ID="List2" runat="server">
                            <asp:ListItem Value="0">Publishers</asp:ListItem>
                            <asp:ListItem Value="1">Journals</asp:ListItem>
                            <asp:ListItem Value="2">Subscriptions</asp:ListItem>
                            <asp:ListItem Value="3">Issues</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <br />
                        <br />
                        Sort :
                        <asp:DropDownList ID="List3" runat="server">
                            <asp:ListItem Value="0">None</asp:ListItem>
                            <asp:ListItem Value="1">Ascending</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                        <br />
                    </td>
                </tr>
                <tr>
                    <td style="width: 312px">&nbsp;</td>
                    <td style="width: 439px">
                        <br />
                        <br />
                        <asp:Button ID="obtain" runat="server" Text="OBTAIN" />
                        <br />
                        <br />
                    </td>
                    <td>
                        <br />
                    </td>
                </tr>
            </table>
        </div>
    
            <asp:GridView ID="GridView1" runat="server" style="width: 187px; height: 127px">
            </asp:GridView>
            
</asp:Content>