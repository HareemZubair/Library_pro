<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmviewfeedback.aspx.cs" Inherits="mylibrary.frmviewfeedback" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server" CellPadding="4" ForeColor="#333333" OnSelectedIndexChanged="DataList1_SelectedIndexChanged">
        <AlternatingItemStyle BackColor="White" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <ItemStyle BackColor="#E3EAEB" />
        <SelectedItemStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <ItemTemplate>
                        <%#Eval("uname") %><br />
                        <%#Eval("date") %><br />
                        <b><i><%#Eval("uemail") %></i></b><br />
                        <%#Eval("ucountry") %><br />
                        <%#Eval("comment") %><br />
                        <hr />
                    </ItemTemplate>
    </asp:DataList>
</asp:Content>
