<%@ Page  Language="vb" AutoEventWireup="false" CodeBehind="MasterEntry.aspx.vb" Inherits="WebApplication2.WebForm2" MasterPageFile="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
      <h2>Master Page</h2>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 331px;
        }
        .auto-style3 {
            width: 506px;
        }
    .auto-style4 {
        margin-left: 0;
    }
    </style>

   
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">JCode*</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="code" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Title*</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="title" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">acqDate</td>
                    <td class="auto-style3">
                        
                        <asp:TextBox ID="acqdate" runat="server" TextMode="Date" CssClass="auto-style4"></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        
                        &nbsp;</td>
                    <td class="auto-style3">
                        
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Periodicity*</td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="periodicity" runat="server">
                            <asp:ListItem>weekly</asp:ListItem>
                            <asp:ListItem>fortnightly</asp:ListItem>
                            <asp:ListItem>monthly</asp:ListItem>
                            <asp:ListItem></asp:ListItem>
                            <asp:ListItem>quarterly</asp:ListItem>
                            <asp:ListItem>halfyearly</asp:ListItem>
                            <asp:ListItem>bimonthlyannually</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Remark</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="remark" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Placement NO*</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="placementNo" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Subject</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="subject" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Dept</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="dept" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Publisher*</td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="publisher" runat="server" DataMember="DefaultView">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">ISSN</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="issn" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style3">
                        &nbsp;</td>
                    <td class="auto-style3">
                        &nbsp;</td>
                </tr>
            </table>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Save to DB" />
                        
                        <asp:Button ID="clearContents" runat="server" Text="Clear Contents" style="height: 26px" />
        </p>
     </asp:Content>
