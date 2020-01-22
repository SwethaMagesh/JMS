<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Subscription.aspx.vb" Inherits="WebApplication2.WebForm3"  MasterPageFile="~/Site.Master" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    <h2>Subscription Page</h2>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 275px;
        }
        .auto-style4 {
            width: 223px;
        }
        .auto-style5 {
            width: 182px;
        }
        .auto-style6 {
            width: 134px;
        }
        .auto-style7 {
            width: 163px;
        }
        .auto-style8 {
            margin-left: 0;
        }
    </style>


   
        <div>

            <table class="auto-style1">
                <tr>
                    <td class="auto-style4">Journal code*</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="code" runat="server" AutoPostBack="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Title</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="title" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Subscription Start date*</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="fromDate" runat="server" TextMode="Date"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Subscription End date*</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="toDate" runat="server" TextMode="Date"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Subscribed From</td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="subscribedFrom" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Subscribed Date*</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="subscribedOn" runat="server" TextMode="Date"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Payment mode*</td>
                    <td class="auto-style3">
                        <asp:RadioButtonList ID="ModeRadioButton" runat="server">
                            <asp:ListItem>DD</asp:ListItem>
                            <asp:ListItem>RTGS</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Payment Details (DD or UPSR No)</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="paymentDetails" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Remarks</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="remarks" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Voucher Ref Number</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="VoucherRef" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        &nbsp;</td>
                    <td class="auto-style3">
                        &nbsp;</td>
                </tr>
                   
               </table>

        </div>
        <p>
            <table class="nav-justified">
                <tr>
                    <td class="auto-style5">
                        <asp:Button ID="Button1" runat="server" Text="Save subscription" />
                    </td>
                    <td class="auto-style6">
                        <asp:Button ID="Button2" runat="server" CssClass="auto-style8" Text="Clear contents" Width="120px" />
                    </td>
                    <td class="auto-style7">
                        <asp:Button ID="Button3" runat="server" Text="Delete record" Width="132px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
    </p>
    <p>
            &nbsp;</p>
    </asp:Content>