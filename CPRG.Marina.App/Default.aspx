<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CPRG.Marina.App._Default" %>

<%@ Register Src="~/Controls/DockSelector.ascx" TagPrefix="uc1" TagName="DockSelector" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron" id="hero-section">
        <h1>INLAND MARINA</h1>
        <p class="lead">Your premier Inland Lake boating destination!</p>
        <p>
          <a href="/registration" runat="server" id="uxPrimary" class="btn btn-primary btn-lg">Register now! &raquo;</a>
          <a href="/AvailableSlips" runat="server" id="uxSecondary" class="btn btn-secondary btn-lg">View All Slips! &raquo;</a>
        </p>
    </div>

    <div class="container">
      <div class="row">
        <div class="col text-center text-justify text-wrap center">
          <p>Welcome to Inland Marina located on the south shore Inland Lake, just a small commute from
             major centers in the south west. </p>
          <p>Inland Marina was established in the 1967 shortly after Inland Lake was created as a result of
              the South West damn. From its humble beginnings, it has grown to be the largest marina on
              Inland Lake. Due to the warm climate that extends year round, Inland Lake has become a
              popular tourist destination in the south west. Boat owners from California, Arizona, Nevada,
              and Utah are attracted to the area. Inland Marina has 90 slips ranging in size from 16 to 32 feet
              in length. Dock services include electrical and fresh water. </p>
        </div>
      </div>
    </div>

</asp:Content>
