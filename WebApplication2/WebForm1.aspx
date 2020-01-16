<%@ Page Language="vb" Title="Form Page" AutoEventWireup="false"  CodeBehind="WebForm1.aspx.vb" Inherits="WebApplication2.webform1" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 461px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Button" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="Button" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        Name<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <p>
            dept<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <p>
            start date
        </p>
        <p>
            end date</p>
    </form>
</body>
</html>
