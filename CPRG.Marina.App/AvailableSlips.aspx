<%@ Page Title="View Slips" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AvailableSlips.aspx.cs" Inherits="CPRG.Marina.App.AvailableSlips" %>

<%@ Register Src="~/Controls/DockSelector.ascx" TagPrefix="uc1" TagName="DockSelector" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

  <h3>Select Dock:</h3>
  <uc1:DockSelector runat="server" ID="DockSelector" />

  <br />

  <br />

  <asp:GridView ID="uxSlipGrid" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="uxSlipSource" ForeColor="#333333" GridLines="None" Width="261px">
    <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
    <Columns>
      <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
      <asp:BoundField DataField="Width" HeaderText="Width" SortExpression="Width" />
      <asp:BoundField DataField="Length" HeaderText="Length" SortExpression="Length" />
    </Columns>
    <EditRowStyle BackColor="#999999" />
    <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
    <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
    <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
    <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
    <SortedAscendingCellStyle BackColor="#E9E7E2" />
    <SortedAscendingHeaderStyle BackColor="#506C8C" />
    <SortedDescendingCellStyle BackColor="#FFFDF8" />
    <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
  </asp:GridView>

  <br />

  <br />
  <asp:ObjectDataSource ID="uxSlipSource" 
                        runat="server" 
                        SelectMethod="GetNonleasedSlipsByDock" 
                        TypeName="CPRG214.Marina.Data.MarinaManager" OnSelecting="uxSlipSource_Selecting">
    <SelectParameters>
      <asp:Parameter DefaultValue="" Name="dockID" Type="Int32" />
    </SelectParameters>
  </asp:ObjectDataSource>

</asp:Content>
