<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmsearch.aspx.cs" Inherits="mylibrary.frmsearch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            font-size: large;
            color: #008000;
            font-weight: bold;
        }
        .auto-style2 {
            width: 2%;
        }
        .auto-style4 {
            width: 3%;
        }
        .auto-style5 {
            width: 45px;
        }
        .auto-style6 {
            width: 81%;
        }
        .auto-style7 {
            width: 45px;
            height: 23px;
        }
        .auto-style8 {
            width: 81%;
            height: 23px;
        }
        .auto-style9 {
            width: 3%;
            height: 23px;
        }
        .auto-style10 {
            width: 2%;
            height: 23px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table style="width:100%;">
        <tr>
            <td colspan="4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style1">&nbsp; SEARCH BOOKS&nbsp;</span></td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style6">&nbsp;
&nbsp;&nbsp; </td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style6">
                category:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="76px">
                </asp:DropDownList>
                &nbsp;&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style6">sub-category:<asp:DropDownList ID="DropDownList2" runat="server" Height="18px" Width="174px">
                </asp:DropDownList>
&nbsp;&nbsp;
                &nbsp;&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style6">Book:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:DropDownList ID="DropDownList3" runat="server" Height="16px" Width="180px">
                </asp:DropDownList>
            &nbsp;<asp:ImageButton ID="ImageButton15" runat="server" Height="18px" ImageUrl="~/images/search.png" Width="18px" OnClick="ImageButton15_Click" />
&nbsp;&nbsp;<asp:ImageButton ID="ImageButton16" runat="server" Height="18px" ImageUrl="~/images/refreh.jpg" Width="18px" />
&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style6">&nbsp;&nbsp;&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style6">
                <asp:GridView ID="GridView1" runat="server" Width="305px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                </asp:GridView>
            </td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7"></td>
            <td class="auto-style8">
                </td>
            <td class="auto-style9"></td>
            <td class="auto-style10"></td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
        </tr>
    </table>

</asp:Content>
