<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LeaseSlips.aspx.cs" Inherits="CPRG.Marina.App.Slips" %>
<%@ Register src="../Controls/DockSelector.ascx" tagname="DockSelector" tagprefix="uc2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Select Dock:</h3> 
    <uc2:DockSelector ID="DockSelector" runat="server" AllowPostBack="True" />
<br />
  <br />
  <table>
    <tr>
      <td style="width: 181px">Water Services:</td>
      <td style="width: 133px">
        <asp:Label ID="uxWater" runat="server" Text="Label"></asp:Label>
      </td>
    </tr>
    <tr>
      <td style="width: 181px">Electric Services:</td>
      <td style="width: 133px">
        <asp:Label ID="uxElectric" runat="server" Text="Label"></asp:Label>
      </td>
    </tr>
    <tr>
      <td style="width: 181px">Available Slips:</td>
      <td style="width: 133px">
        <asp:Label ID="uxSlipCount" runat="server" Text="Label"></asp:Label>
      </td>
    </tr>
  </table>
  <br />
  <p>  Select Slip: <asp:DropDownList ID="uxSlips" runat="server" Width="302px">  </asp:DropDownList></p>


  <br />
</asp:Content>
