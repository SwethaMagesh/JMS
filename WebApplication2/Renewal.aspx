<%@ Page Title="Renewal Page"  Language="vb" AutoEventWireup="false" CodeBehind="Renewal.aspx.vb" Inherits="WebApplication2.WebForm4"  MasterPageFile="~/Site.Master" %>

<asp:Content ContentPlaceHolderID="MainContent" ID="BodyContext" runat="server">
    <style type="text/css">
    .center_button
    {
        text-align:center;
        align-self:center;
    }
    </style>

         <h2><%: Title %></h2>

        <div class="center_button">
        </div>
   <div class="panel panel-default">
      <div class="panel-heading">
        <h4 class="panel-title">
          <a data-toggle="collapse" data-parent="#accordion" href="#SubscriptionExpired">Expired Subscriptions</a>
        </h4>
      </div>
      <div id="SubscriptionExpired" class="panel-collapse collapse ">
        <div class="panel-body">
            <asp:GridView ID="subdis" runat="server"  >
            </asp:GridView>
            
            <br/>
        </div>
      </div>
    </div>
   

<div class="panel panel-default">
      <div class="panel-heading">
        <h4 class="panel-title">
          <a data-toggle="collapse" data-parent="#accordion" href="#SubscriptionApp">Subscriptions about to Expire</a>
        </h4>
      </div>
      <div id="SubscriptionApp" class="panel-collapse collapse ">
        <div class="panel-body">
             <asp:GridView ID="subapp" runat="server"  >
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
            <asp:GridView ID="subavl" runat="server"  >
            </asp:GridView>
        </div>
      </div>
    </div>

     </asp:Content>