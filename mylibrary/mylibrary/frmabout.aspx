<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmabout.aspx.cs" Inherits="mylibrary.frmabout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" GridLines="Horizontal" RepeatColumns="3" OnSelectedIndexChanged="DataList1_SelectedIndexChanged" ForeColor="Black">
        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
        <SelectedItemStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
     <ItemTemplate>
            Campus: <b><%#Eval("campus") %></b><br />
            Address: <%#Eval("address") %><br />
            Contact: <%#Eval("contact") %><br />
            Email: <%#Eval("email") %><br />
            Established in: <%#Eval("year") %><br /><br />
        </ItemTemplate>
    </asp:DataList>
&nbsp;
</asp:Content>
