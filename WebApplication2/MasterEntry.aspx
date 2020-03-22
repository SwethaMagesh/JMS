<%@ Page Title="Master Entry" Language="vb" AutoEventWireup="false" CodeBehind="MasterEntry.aspx.vb" Inherits="WebApplication2.MasterEntry" MasterPageFile="~/Site.Master" %>

    <asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <h2>Master Page</h2>

        <style type="text/css">
            .auto-style1 {
                width: 100%;
            }
            
            .auto-style3 {
                width: 506px;
            }
            
            .auto-style4 {
                margin-left: 0;
            }
            
            .auto-style5 {
                width: 120px;
            }
            
            .auto-style7 {
                width: 336px;
            }
            
            .auto-style9 {
                width: 337px;
            }
            
            .auto-style19 {
                color: #000000;
            }
            
            .auto-style16 {
                margin-left: 37px;
            }
            .auto-style21 {
                width: 339px;
            }
            .auto-style22 {
                width: 338px;
            }
        </style>

        <div class="panel-group" id="accordion">
      <div class="panel panel-default">
      <div class="panel-heading">
        <h4 class="panel-title">
          <a data-toggle="collapse" data-parent="#accordion" href="#Mandatory">Mandatory Details</a>
        </h4>
      </div>
      <div id="Mandatory" class="panel-collapse collapse in ">
        <div class="panel-body">
             <table class="auto-style1">
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">JCode*</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="code" runat="server" AutoPostBack="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">Title*</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="jtitle" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">Acquired Date</td>
                    <td class="auto-style3">

                        <asp:TextBox ID="acqdate" runat="server" TextMode="Date" CssClass="auto-style4"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style3">

                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">Periodicity*</td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="periodicity" runat="server">
                            <asp:ListItem>Weekly</asp:ListItem>
                            <asp:ListItem>Fortnightly</asp:ListItem>
                            <asp:ListItem>Monthly</asp:ListItem>
                            <asp:ListItem>Annually</asp:ListItem>
                            <asp:ListItem>Quarterly</asp:ListItem>
                            <asp:ListItem>Half-yearly</asp:ListItem>
                            <asp:ListItem>Bimonthly</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style3">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">Placement No*</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="placementNo" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style3">
                        &nbsp;</td>
                </tr>

            </table>
        </div>
      </div>
    </div>
        

     <div class="panel panel-default">
      <div class="panel-heading">
        <h4 class="panel-title">
          <a data-toggle="collapse" data-parent="#accordion" href="#TypeDetails">Type Details</a>
        </h4>
      </div>
      <div id="TypeDetails" class="panel-collapse collapse ">
        <div class="panel-body">
             <table class="nav-justified">
                <tr>
                    <td class="auto-style22">
                        <span class="auto-style19">Type</span></td>
                    <td>
                        <asp:DropDownList ID="jtype" runat="server" CssClass="auto-style7" Width="350px">
                            <asp:ListItem>National</asp:ListItem>
                            <asp:ListItem>International</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style22">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style22">Category</td>
                    <td>
                        <asp:DropDownList ID="category" runat="server" CssClass="auto-style9" Width="351px">
                            <asp:ListItem>Subscription</asp:ListItem>
                            <asp:ListItem>Gift</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style22">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style22">Period type</td>
                    <td>
                        <asp:DropDownList ID="periodType" runat="server" CssClass="auto-style9" Width="351px">
                            <asp:ListItem>Mid-Year</asp:ListItem>
                            <asp:ListItem>Annual</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style22">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style22">Status</td>
                    <td>
                        <asp:DropDownList ID="status" runat="server" CssClass="auto-style9" Width="351px">
                            <asp:ListItem>Available</asp:ListItem>
                            <asp:ListItem>Expired</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style22">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style22">Remark</td>
                    <td>
                        <asp:TextBox ID="remark" runat="server"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
      </div>
    </div>
   
<div class="panel panel-default">
      <div class="panel-heading">
        <h4 class="panel-title">
          <a data-toggle="collapse" data-parent="#accordion" href="#PubDet">Publisher Details</a>
        </h4>
      </div>
      <div id="PubDet" class="panel-collapse collapse">
        <div class="panel-body" >
              <table class="nav-justified">
                <tr>
                    <td class="auto-style22">Publisher*</td>
                    <td>
                        <asp:DropDownList ID="publisher" runat="server" DataMember="DefaultView">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style22">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style22">ISSN</td>
                    <td>
                        <asp:TextBox ID="issn" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style22">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>

        </div>
      </div>
    </div>

<div class="panel panel-default">
      <div class="panel-heading">
        <h4 class="panel-title">
          <a data-toggle="collapse" data-parent="#accordion" href="#OtherDet">Other Details</a>
        </h4>
      </div>
      <div id="OtherDet" class="panel-collapse collapse">
        <div class="panel-body" >
             
            <table class="nav-justified">
                <tr>
                    <td class="auto-style21">Language</td>
                    <td>
                        <asp:TextBox ID="lang" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style21">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style21">File No</td>
                    <td>
                        <asp:TextBox ID="fileNo" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style21">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style21">URL of Journal</td>
                    <td>
                        <asp:TextBox ID="url" runat="server" TextMode="Url"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style21">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
      </div>
    </div>         
            
    <div class="panel panel-default">
      <div class="panel-heading">
        <h4 class="panel-title">
          <a data-toggle="collapse" data-parent="#accordion" href="#SubDet">Subject Details</a>
        </h4>
      </div>
      <div id="SubDet" class="panel-collapse collapse">
        <div class="panel-body" >
             <table class="nav-justified">
                <tr>
                    <td class="auto-style21">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style21">Subject</td>
                    <td>
                        <asp:TextBox ID="subject" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style21">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style21">Account Head</td>
                    <td>
                        <asp:TextBox ID="acchead" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style21">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style21"><strong>No. of&nbsp; Programs&nbsp; </strong> </td>
                    <td>
                        <asp:TextBox ID="progNo" runat="server" TextMode="Number"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="addProg" runat="server" Text="Add Programs" />

                    </td>
                </tr>
                <tr>
                    <td class="auto-style21">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style21"><asp:Label ID="Label1" runat="server" Text="Label">Program 1 </asp:Label></td>
                    <td>
                        <asp:DropDownList ID="prog1" runat="server" CssClass="auto-style16" Width="351px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style21"><asp:Label ID="Label2" runat="server" Text="Label">Program 2 </asp:Label></td>
                    <td>
                        <asp:DropDownList ID="prog2" runat="server" CssClass="auto-style16" Width="351px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>

                    <td class="auto-style21"><asp:Label ID="Label3" runat="server" Text="Label">Program 3 </asp:Label></td>
                    <td>
                        <asp:DropDownList ID="prog3" runat="server" CssClass="auto-style16" Width="351px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>

                    <td class="auto-style21"><asp:Label ID="Label4" runat="server" Text="Label">Program 4 </asp:Label></td>
                    <td>
                        <asp:DropDownList ID="prog4" runat="server" CssClass="auto-style16" Width="351px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style21"><asp:Label ID="Label5" runat="server" Text="Label">Program 5 </asp:Label></td>
                    <td>
                        <asp:DropDownList ID="prog5" runat="server" CssClass="auto-style16" Width="351px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style21">&nbsp;</td>
                    <td>
                        
                    </td>
                </tr>
                <tr>
                    <td class="auto-style21">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style21"><strong>No. of Department </strong> </td>
                    <td>
                        <asp:TextBox ID=Department runat="server" TextMode="Number"></asp:TextBox>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Departmentadd" runat="server" Text="Add Departments" />

                    </td>
                </tr>
                <tr>
                    <td class="auto-style21">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style21"><asp:Label ID="Label6" runat="server" Text="Label">Department 1 </asp:Label></td>
                    <td>
                        <asp:DropDownList ID="Department1" runat="server" CssClass="auto-style16" Width="351px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style21"><asp:Label ID="Label7" runat="server" Text="Label">Department 2 </asp:Label></td>
                    <td>
                        <asp:DropDownList ID="Department2" runat="server" CssClass="auto-style16" Width="351px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>

                    <td class="auto-style21"><asp:Label ID="Label8" runat="server" Text="Label">Department 3 </asp:Label></td>
                    <td>
                        <asp:DropDownList ID="Department3" runat="server" CssClass="auto-style16" Width="351px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>

                    <td class="auto-style21"><asp:Label ID="Label9" runat="server" Text="Label">Department 4 </asp:Label></td>
                    <td>
                        <asp:DropDownList ID="Department4" runat="server" CssClass="auto-style16" Width="351px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style21"><asp:Label ID="Label10" runat="server" Text="Label">Department 5 </asp:Label></td>
                    <td>
                        <asp:DropDownList ID="Department5" runat="server" CssClass="auto-style16" Width="351px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style21">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
            </table>
        </div>
      </div>
    </div>
           
            


        </div>
        <p>
            <asp:Button ID="save" runat="server" Text="Save to DB" /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:Button ID="clearContents" runat="server" Text="Clear Contents" style="height: 26px" /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="delete" runat="server" Text="Delete" Height="29px" Width="119px" /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="update" runat="server" Text="Update" Height="29px" Width="119px" />
        </p>
    </asp:Content>