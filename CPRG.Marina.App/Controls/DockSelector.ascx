<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DockSelector.ascx.cs" Inherits="CPRG.Marina.App.Controls.DockSelector" %>

<asp:DropDownList ID="uxDocks" AutoPostBack="True" runat="server" Height="50px" OnSelectedIndexChanged="uxDocks_SelectedIndexChanged" Width="225px" OnTextChanged="uxDocks_SelectedIndexChanged"></asp:DropDownList>