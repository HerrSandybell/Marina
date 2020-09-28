<%@ Page Title="Update Customer Information" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UpdateCustomer.aspx.cs" Inherits="CPRG.Marina.App.Secure.UpdateCustomer" %>

<%@ Register Src="~/Controls/Registration.ascx" TagPrefix="uc1" TagName="Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  <h3>Profile Information</h3>
  <uc1:Registration runat="server" ID="uxRegistration" />
</asp:Content>
