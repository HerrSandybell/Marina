<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Registration.ascx.cs" Inherits="CPRG.Marina.App.Controls.Registration1" %>

<table class="table">
  <tr>
    <td style="width:150px">First Name</td>
    <td>
      <asp:TextBox ID="uxFirstName" runat="server"></asp:TextBox>
    </td>
  </tr>
  <tr>
    <td>Last Name:</td>
    <td>
      <asp:TextBox ID="uxLastName" runat="server"></asp:TextBox>
    </td>
  </tr>
  <tr>
    <td>City:</td>
    <td>
      <asp:TextBox ID="uxCity" runat="server"></asp:TextBox>
    </td>
  </tr>
  <tr>
    <td>Phone Number:</td>
    <td>
      <asp:TextBox ID="uxPhone" runat="server"></asp:TextBox>
    </td>
  </tr>
  <tr>
    <td colspan="2">
      <asp:Button ID="uxSubmit" runat="server" Text="Register" OnClick="uxSubmit_Click" />
    </td>
  </tr>
</table>