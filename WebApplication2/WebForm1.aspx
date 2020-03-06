<%@ Page Language="vb" Title="Form Page" AutoEventWireup="false"  CodeBehind="WebForm1.aspx.vb" Inherits="WebApplication2.webform1" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .newStyle1 {
            padding: 10px;
        }
        .auto-style3 {
            margin-left: 8px;
        }
        .auto-style4 {
            height: 32px;
            margin-top: 202px;
        }
        .auto-style5 {
            margin-left: 451px;
            margin-top: 0px;
        }
        .auto-style7 {
            margin-left: 35px;
        }
        .auto-style9 {
            margin-left: 4px;
        }
        .auto-style10 {
            width: 435px;
            height: 263px;
            color: #3399FF;
        }
        .auto-style11 {
            height: 263px;
        }
        .auto-style12 {
            width: 435px;
            height: 24px;
        }
        .auto-style15 {
            margin-left: 39px;
        }
        .auto-style16 {
            margin-left: 37px;
        }
        .auto-style17 {
            margin-left: 25px;
        }
        .auto-style18 {
            margin-left: 62px;
        }
        .auto-style14 {
            margin-left: 13px;
        }
        .auto-style19 {
            color: #000000;
        }
        .auto-style20 {
            margin-left: 14px;
        }
        .auto-style21 {
            height: 24px;
        }
        .auto-style22 {
            margin-left: 5px;
        }
        .auto-style23 {
            margin-left: 142px;
        }
        .auto-style24 {
            margin-left: 88px;
        }
        .auto-style25 {
            margin-left: 42px;
        }
        .auto-style26 {
            margin-left: 80px;
        }
        .auto-style27 {
            margin-left: 57px;
        }
        .auto-style28 {
            margin-left: 123px;
        }
        .auto-style29 {
            margin-left: 95px;
        }
    </style>
</head>
<body style="height: 676px">
    <form id="form1" runat="server">
        <h1>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; JOURNAL MASTER</h1>
        <table class="auto-style1">
            <tr>
                <td class="auto-style10">
                    &nbsp; <span class="auto-style19">&nbsp;JCode &nbsp;</span>
                    <asp:TextBox ID="TextBox5" runat="server" CssClass="auto-style14" Width="160px"></asp:TextBox>
                &nbsp;&nbsp;<br />
&nbsp;<span class="auto-style19">AccDate</span><asp:TextBox ID="TextBox6" runat="server" CssClass="auto-style20" Width="160px"></asp:TextBox>
                    <br />
                    <span class="auto-style19">&nbsp;Title&nbsp;&nbsp;&nbsp;</span>&nbsp; <asp:TextBox ID="TextBox7" runat="server" Width="346px" CssClass="auto-style3"></asp:TextBox>
        &nbsp;
                    <br />
                    <span class="auto-style19">Category</span><asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style9" Width="351px">
                        <asp:ListItem>Subscription</asp:ListItem>
                        <asp:ListItem>Gift</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <span class="auto-style19">Type</span><asp:DropDownList ID="DropDownList2" runat="server" CssClass="auto-style7" Width="350px">
                        <asp:ListItem>National</asp:ListItem>
                        <asp:ListItem>International</asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <span class="auto-style19">SubTitle</span>&nbsp; <asp:TextBox ID="TextBox9" runat="server" Width="341px"></asp:TextBox>
                    <br />
                    <br />
                </td>
                <td class="auto-style11">
                    Placement No. *<asp:TextBox ID="TextBox8" runat="server" Width="339px"></asp:TextBox>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; No. of Journal Programs<br />
                    Back/Subject<asp:DropDownList ID="DropDownList3" runat="server" CssClass="auto-style17" Width="351px">
                    </asp:DropDownList>
                    <asp:TextBox ID="TextBox10" runat="server" CssClass="auto-style16" Width="160px" Height="19px"></asp:TextBox>
                    <asp:Button ID="Button8" runat="server" Text="ENTER" Height="29px" Width="119px" CssClass="auto-style18" />
                    <br />
                    Department<asp:DropDownList ID="DropDownList4" runat="server" CssClass="auto-style15" Width="351px">
                    </asp:DropDownList>
                    <br />
                    Prog. Name<asp:DropDownList ID="DropDownList5" runat="server" CssClass="auto-style16" Width="351px">
                    </asp:DropDownList>
                    <br />
                    Publisher*&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox11" runat="server" Width="345px" CssClass="auto-style22"></asp:TextBox>
                    <br />
                    ISSN<asp:TextBox ID="TextBox12" runat="server" Width="156px" CssClass="auto-style24"></asp:TextBox>
        &nbsp;&nbsp; Subscription Amount<asp:TextBox ID="TextBox13" runat="server" Width="168px" CssClass="auto-style25"></asp:TextBox>
                    <br />
                    Series<asp:DropDownList ID="DropDownList6" runat="server" CssClass="auto-style26" Width="164px">
                    </asp:DropDownList>
&nbsp;&nbsp; File No.<asp:TextBox ID="TextBox14" runat="server" Width="166px" CssClass="auto-style23"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
            </tr>
            <tr>
                <td class="auto-style12">
                    Periodicity <asp:DropDownList ID="DropDownList7" runat="server" CssClass="auto-style20" Width="327px">
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                        <asp:ListItem></asp:ListItem>
                    </asp:DropDownList>
                    <br />
                    <br />
                    Period Type&nbsp;
                    <asp:RadioButton ID="midyr" runat="server" Text="Mid-Year" />
                    <asp:RadioButton ID="annual" runat="server" Text="Annual" />
                </td>
                <td class="auto-style21">
                    <br />
                    Account Head<asp:DropDownList ID="DropDownList9" runat="server" CssClass="auto-style27" Width="351px">
                    </asp:DropDownList>
                    <br />
                    Agent<asp:DropDownList ID="DropDownList10" runat="server" CssClass="auto-style28" Width="351px">
                    </asp:DropDownList>
                    <br />
                    Language<asp:DropDownList ID="DropDownList11" runat="server" CssClass="auto-style29" Width="351px">
                    </asp:DropDownList>
                </td>
            </tr>
            </table>
        <p class="auto-style4">
                    <asp:Button ID="Save" runat="server" Text="Save" Height="30px" Width="118px" CssClass="auto-style5" />
                    <asp:Button ID="delete" runat="server" Text="Delete" Height="29px" Width="119px" />
                    <asp:Button ID="Button6" runat="server" Text="Clear " Height="29px" Width="118px" />
                    <asp:Button ID="Button7" runat="server" Text="Exit" Height="29px" Width="118px" />
        </p>
    &nbsp;</form>
</body>
</html>
