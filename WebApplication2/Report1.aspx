<%@ Page Title="Report Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Report1.aspx.vb" Inherits="WebApplication2.Report1" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
  
        <div style="height: 117px">
            <table style="height: 80px;" class="nav-justified">
                <tr>
                    <td style="width: 299px" class="modal-sm">
                        Show :&nbsp;
                        <asp:DropDownList ID="List1" runat="server">
                            <asp:ListItem Value="0">Count</asp:ListItem>
                            <asp:ListItem Value="1">List</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td style="width: 299px" class="modal-sm">
                        Of :&nbsp;<asp:DropDownList ID="List2" runat="server" AutoPostBack="True">
                            <asp:ListItem Value="0">Publishers</asp:ListItem>
                            <asp:ListItem Value="1">Journals</asp:ListItem>
                            <asp:ListItem Value="2">Subscriptions</asp:ListItem>
                            <asp:ListItem Value="3">Issues</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td style="width: 302px">
                        Group by :&nbsp;<asp:DropDownList ID="Groupby" runat="server" AutoPostBack="True">
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
                </table>
        </div>


    <div class="panel-group" id="accordion">
    <div class="panel panel-default">
      <div class="panel-heading">
        <h4 class="panel-title">
          <a data-toggle="collapse" data-parent="#accordion" href="#Journal">Journals</a>
        </h4>
      </div>
      <div id="Journal" class="panel-collapse collapse in">
        <div class="panel-body" >
             <asp:GridView ID="Journals" runat="server">
            </asp:GridView>
        </div>
      </div>
    </div>    

    <div class="panel panel-default">
      <div class="panel-heading">
        <h4 class="panel-title">
          <a data-toggle="collapse" data-parent="#accordion" href="#Publisher">Publishers</a>
        </h4>
      </div>
      <div id="Publisher" class="panel-collapse collapse">
        <div class="panel-body">
             <asp:GridView ID="Publishers" runat="server" >
            </asp:GridView>
        </div>
      </div>
    </div>
         
     <div class="panel panel-default">
      <div class="panel-heading">
        <h4 class="panel-title">
          <a data-toggle="collapse" data-parent="#accordion" href="#JournalPublisher">Journals (based on Publishers)</a>
        </h4>
      </div>
      <div id="JournalPublisher" class="panel-collapse collapse">
        <div class="panel-body"">
             <asp:GridView ID="jpubl" runat="server" >
            </asp:GridView>
        </div>
      </div>
    </div>

    <div class="panel panel-default">
      <div class="panel-heading">
        <h4 class="panel-title">
          <a data-toggle="collapse" data-parent="#accordion" href="#JournalPeriodicity">Journals (based on Periodicity)</a>
        </h4>
      </div>
      <div id="JournalPeriodicity" class="panel-collapse collapse">
        <div class="panel-body" >
             <asp:GridView ID="periodicityl" runat="server" >
            </asp:GridView>
        </div>
      </div>
    </div>

    
    <div class="panel panel-default">
      <div class="panel-heading">
        <h4 class="panel-title">
          <a data-toggle="collapse" data-parent="#accordion" href="#JournalDept">Journals (based on Departments)</a>
        </h4>
      </div>
      <div id="JournalDept" class="panel-collapse collapse">
        <div class="panel-body">
             <asp:GridView ID="jdeptl" runat="server">
            </asp:GridView>
        </div>
      </div>
    </div>
     

    <div class="panel panel-default">
      <div class="panel-heading">
        <h4 class="panel-title">
          <a data-toggle="collapse" data-parent="#accordion" href="#JournalProgram">Journals (based on Programs)</a>
        </h4>
      </div>
      <div id="JournalProgram" class="panel-collapse collapse ">
        <div class="panel-body">
            <asp:GridView ID="jprogl" runat="server"  >
            </asp:GridView>
        </div>
      </div>
    </div>
        
    <div class="panel panel-default">
      <div class="panel-heading">
        <h4 class="panel-title">
          <a data-toggle="collapse" data-parent="#accordion" href="#VolumesIssues">Volumes and Issues</a>
        </h4>
      </div>
      <div id="VolumesIssues" class="panel-collapse collapse ">
        <div class="panel-body">
            <asp:GridView ID="issuesl" runat="server"  >
            </asp:GridView>
        </div>
      </div>
    </div>

        
    <div class="panel panel-default">
      <div class="panel-heading">
        <h4 class="panel-title">
          <a data-toggle="collapse" data-parent="#accordion" href="#Subscription">Subscriptions</a>
        </h4>
      </div>
      <div id="Subscription" class="panel-collapse collapse ">
        <div class="panel-body">
            <h4>Expired Subscriptions</h4>
            <asp:GridView ID="subdis" runat="server"  >
            </asp:GridView>
            <br/>
            <h4>Subscriptions about to Expire</h4>
            <asp:GridView ID="subapp" runat="server"  >
            </asp:GridView>
            <br/>
            <h4>Subscriptions</h4>
            <asp:GridView ID="subavl" runat="server"  >
            </asp:GridView>
            <br/>
        </div>
      </div>
    </div>

    </div>     
</asp:Content>