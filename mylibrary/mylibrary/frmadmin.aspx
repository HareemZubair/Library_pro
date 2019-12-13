<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmadmin.aspx.cs" Inherits="mylibrary.frmadmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
&nbsp;<asp:Login ID="Login1" runat="server" OnAuthenticate="Login1_Authenticate1">
    </asp:Login>
&nbsp;
</asp:Content>
