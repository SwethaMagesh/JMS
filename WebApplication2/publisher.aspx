<%@ Page Title= "Publisher Page" Language="vb"  MasterPageFile="~/Site.Master" AutoEventWireup="false" CodeBehind="publisher.aspx.vb" Inherits="WebApplication2.publisher" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Publisher</h2>
   
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 122px;
        }
        .auto-style3 {
            width: 122px;
            height: 21px;
        }
        .auto-style4 {
            height: 21px;
        }
        .auto-style5 {
            width: 122px;
            height: 42px;
        }
        .auto-style6 {
            height: 42px;
        }
    </style>

    <div class="panel-group" id="accordion">
    <div class="panel panel-default">
      <div class="panel-heading">
        <h4 class="panel-title">
          <a data-toggle="collapse" data-parent="#accordion" href="#publisher">Publisher</a>
        </h4>
      </div>
      <div id="publisher" class="panel-collapse collapse in">
        <div class="panel-body">
             <table class="auto-style1">
                <tr>
                    <td class="auto-style2">
                        Publisher ID</td>
                    <td>
                        <asp:TextBox ID="pubId" runat="server" AutoPostBack="True"></asp:TextBox>
                    </td>
                </tr>
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
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Address</td>
                    <td>
                        <asp:TextBox ID="address" runat="server" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Pincode</td>
                    <td>
                        <asp:TextBox ID="pincode" runat="server" TextMode="Number"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Phone</td>
                    <td>
                        <asp:TextBox ID="phone" runat="server" TextMode="Phone"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">E-mail</td>
                    <td>
                        <asp:TextBox ID="email" runat="server" TextMode="Email"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Website</td>
                    <td>
                        <asp:TextBox ID="website" runat="server" TextMode="Url"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Country</td>
                    <td>
                        <asp:TextBox ID="country" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Fax</td>
                    <td>
                        <asp:TextBox ID="fax" runat="server" TextMode="Phone"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">Agent Name</td>
                    <td class="auto-style4">
                        <asp:TextBox ID="agentname" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5"></td>
                    <td class="auto-style6">
                        </td>
                </tr>
                <tr>
                    <td class="auto-style4" colspan="2">
                        <asp:Button ID="Save" runat="server" Text="Save" Width="136px" />
                        &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="clearContents" runat="server" CssClass="auto-style8" Text="Clear contents" Width="136px" />
                    &nbsp;&nbsp;&nbsp;
                        <asp:Button ID="update" runat="server" CssClass="auto-style8" Text="Update and Save" Width="136px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="deleteRecord" runat="server" Text="Delete record" Width="136px" />
                    &nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
            </table>

        </div>
      </div>
    </div>
    <div class="panel panel-default">
      <div class="panel-heading">
        <h4 class="panel-title">
          <a data-toggle="collapse" data-parent="#accordion" href="#publisherdetails">Publisher Details</a>
        </h4>
      </div>
      <div id="publisherdetails" class="panel-collapse collapse">
        <div class="panel-body">
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
        </div>
      </div>
    </div>
    
  </div> 
   

    </asp:Content>