<%@ Page Title="Registration" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="CPRG.Marina.App.Registration" %>

<%@ Register Src="~/Controls/Registration.ascx" TagPrefix="uc1" TagName="Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  <h3>Registration</h3>
  <uc1:Registration runat="server" ID="uxRegistration" />
</asp:Content>
