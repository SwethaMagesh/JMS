<%@ Page Title="Inward Entry"  MasterPageFile ="~/Site.Master"  Language="vb" AutoEventWireup="false" CodeBehind="InwardEntry.aspx.vb" Inherits="WebApplication2.InwardEntry" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
      <h2>Inward Entry Page</h2>

    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 123px;
        }
    </style>


        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">JCode*</td>
                    <td>
                        <asp:TextBox ID="codeBox" runat="server" AutoPostBack="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Title</td>
                    <td>
                        <asp:TextBox ID="TitleBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Periodicity</td>
                    <td>
                        <asp:TextBox ID="periodicity" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Volume Number*</td>
                    <td>
                        <asp:TextBox ID="VolNoBox" runat="server" TextMode="Number"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Issue Number*</td>
                    <td>
                        <asp:TextBox ID="IssueNoBox" runat="server" TextMode="Number" AutoPostBack="True"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">From Date*</td>
                    <td>
                        <asp:TextBox ID="FromDateBox" runat="server" TextMode="Date"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">To Date*</td>
                    <td>
                        <asp:TextBox ID="ToDateBox" runat="server" TextMode="Date"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Merge Remark</td>
                    <td>
                        <asp:TextBox ID="MergeRemarkBox" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">Received Date*</td>
                    <td>
                        <asp:TextBox ID="issueDate" runat="server" TextMode="Date"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button ID="saveButton" runat="server" Text="Save issue" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="clear" runat="server" Text="Clear contents" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="updateSave" runat="server" Text="Update and Save" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="delete" runat="server" Text="Delete record" />
                    </td>
                </tr>
            </table>
        </div>
     </asp:Content>