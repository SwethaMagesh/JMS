<%@ Page Language="vb"  MasterPageFile="~/Site.Master" AutoEventWireup="false" CodeBehind="publisher.aspx.vb" Inherits="WebApplication2.publisher" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


   
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 284px;
        }
        .auto-style3 {
            width: 284px;
            height: 21px;
        }
        .auto-style4 {
            height: 21px;
        }
    </style>

    
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Text="Publisher Name"></asp:Label>
                        *</td>
                    <td>
                        <asp:TextBox ID="pubName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Address*</td>
                    <td>
                        <asp:TextBox ID="address" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Pincode*</td>
                    <td>
                        <asp:TextBox ID="pincode" runat="server" TextMode="Number"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Phone</td>
                    <td>
                        <asp:TextBox ID="phone" runat="server" TextMode="Phone"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">E-mail</td>
                    <td>
                        <asp:TextBox ID="email" runat="server" TextMode="Email"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Website</td>
                    <td>
                        <asp:TextBox ID="website" runat="server" TextMode="Url"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Country</td>
                    <td>
                        <asp:TextBox ID="country" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Fax</td>
                    <td>
                        <asp:TextBox ID="fax" runat="server" TextMode="Phone"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">Contact Person</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="contactPerson" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style4">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Button ID="Save" runat="server" Text="Save" Width="136px" />
                        <asp:Button ID="clearContents" runat="server" CssClass="auto-style8" Text="Clear contents" Width="136px" />
                    </td>
                    <td class="auto-style4">
                        <asp:Button ID="deleteRecord" runat="server" Text="Delete record" Width="136px" />
                    </td>
                </tr>
            </table>
        </div>
   

    </asp:Content>