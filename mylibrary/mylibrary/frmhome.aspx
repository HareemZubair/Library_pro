<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmhome.aspx.cs" Inherits="mylibrary.frmhome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 
&nbsp;<asp:DataList ID="DataList1" runat="server" CellPadding="4" Height="100px" RepeatColumns="2" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" GridLines="Horizontal" ForeColor="Black">
        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
       <ItemTemplate>
           <h2><%#Eval("heading") %></h2>
           <asp:Image ID="Image1" runat="server" ImageUrl='<%#Eval("picture") %>' Height="100px" Width="200px" /><br />
           <%#Eval("detail") %>  
       </ItemTemplate> 
        <SelectedItemStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
</asp:DataList>
&nbsp;
</asp:Content>
