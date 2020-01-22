<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="WebApplication2.WebForm5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Login</title>
</head>
    <style>
        html {
            font-size:20px;
            font-family: 'Segoe UI';
        }
    .jumbotron
    h1,h2
    {
        align-content:center ;
        text-align: center;
       

    }
        #home,#home:visited

        .auto-style1 {
            margin-left: 0px;
        }
        .auto-style2 {
            width: 179px;
        }

        .auto-style3 {
            width: 179px;
            height: 22px;
        }
        .auto-style4 {
            height: 22px;
        }

    </style>
<body>
    <div class="jumbotron">
        <h1>Journal Management System</h1>
        <h2>LOGIN</h2>
    </div>
     <form id="form1" runat="server">
    
    <center>     
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">User Name</td>
                <td rowspan="2">
                    <asp:TextBox ID="username" runat="server" Height="30px" Width="260px" CssClass="form-control"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="username"
                                CssClass="text-danger" ForeColor="Red" ErrorMessage="The User Name field is required." />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">Password</td>
                <td class="auto-style4" rowspan="2">
                    <asp:TextBox ID="password" runat="server"  TextMode="Password" Height="31px" Width="260px" CssClass="form-control"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="password" 
                        CssClass="text-danger" ForeColor="Red" ErrorMessage="The password field is required." />
                </td>
            </tr>
      
            <tr>
                <td class="auto-style3">&nbsp;</td>
            </tr>
      
        </table>
        
        <p>
            <asp:Button ID="login" runat="server" Text="Login" Width="99px" />
        </p>
      </center>
    </form>
</body>
</html>