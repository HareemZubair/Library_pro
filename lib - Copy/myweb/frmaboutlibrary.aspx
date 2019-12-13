<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmaboutlibrary.aspx.cs" Inherits="myweb.frmaboutlibrary" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">  
        <asp:DataList ID="DataList1" runat="server" BackColor="White" BorderColor="#999999" BorderWidth="1px" CellPadding="3" Width="679px" ForeColor="Black" BorderStyle="Solid" GridLines="Vertical">
            <AlternatingItemStyle BackColor="#CCCCCC" />
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
           <ItemTemplate>
            Campus: <%#Eval("campus") %><br />
            Contact: <%#Eval("contact") %>
            Email: <%#Eval("email") %><br />
            Established in: <%#Eval("year") %>
            Address: <%#Eval("address") %>
            Timings: <%#Eval("timings") %>
            
        </ItemTemplate>
            <SelectedItemStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        </asp:DataList>
</asp:Content>
