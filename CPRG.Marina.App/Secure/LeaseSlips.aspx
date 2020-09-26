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


    <asp:Button ID="uxLease" runat="server" Text="Lease Slip" OnClick="uxLease_Click" />
    <br />
      <br />
  <h3>Your Leased Slips</h3>
    <asp:GridView ID="uxLeaseGrid" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="uxLeaseSource" ForeColor="#333333" GridLines="None" Width="205px">
      <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
      <Columns>
        <asp:BoundField DataField="LeaseID" HeaderText="LeaseID" SortExpression="LeaseID" />
        <asp:BoundField DataField="SlipID" HeaderText="SlipID" SortExpression="SlipID" />
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
    <asp:Label ID="uxMessage" runat="server"></asp:Label>
    <br />
    <asp:ObjectDataSource ID="uxLeaseSource" runat="server" OnSelecting="uxLeaseSource_Selecting" SelectMethod="GetLeasesByCustomer" TypeName="CPRG214.Marina.Data.MarinaManager">
      <SelectParameters>
        <asp:Parameter Name="custID" Type="Int32" />
      </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>
