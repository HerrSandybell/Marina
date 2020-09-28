<%@ Page Title="Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="CPRG.Marina.App.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

  <h3>Login</h3>
    <div class="col-md-4">
        <table class="table">
            <tr>
                <td style="width:150px">First Name:</td>
                <td>
                    <asp:TextBox ID="uxFirstname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Last Name:</td>
                <td>
                    <asp:TextBox ID="uxLastName" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="uxAuthenticate" runat="server" Text="Sign In" OnClick="uxAuthenticate_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="uxMessage" ForeColor="Red" runat="server" Text=""></asp:Label>
                </td>
            </tr>
        </table>
    </div>

</asp:Content>
