<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmadminnews.aspx.cs" Inherits="mylibrary.Admin.frmadminnews" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" ShowFooter="True" OnRowCancelingEdit="GridView1_RowCancelingEdit" OnRowCommand="GridView1_RowCommand" OnRowDeleting="GridView1_RowDeleting" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                    <Columns>
                        <asp:TemplateField HeaderText="News ID">
                            <ItemTemplate><asp:Label ID="Label1" runat="server" Text='<%#Eval("id") %>'></asp:Label></ItemTemplate>
                            <EditItemTemplate><asp:TextBox ID="TextBox1" runat="server" Text='<%#Eval("id") %>'></asp:TextBox></EditItemTemplate>
                            <FooterTemplate><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></FooterTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="News">
                            <ItemTemplate><asp:Label ID="Label2" runat="server" Text='<%#Eval("update") %>'></asp:Label></ItemTemplate>
                            <EditItemTemplate><asp:TextBox ID="TextBox3" runat="server" Text='<%#Eval("update") %>'></asp:TextBox></EditItemTemplate>
                            <FooterTemplate><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></FooterTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Select">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CommandName ="edit">edit</asp:LinkButton>
                                <asp:LinkButton ID="LinkButton2" runat="server" CommandName="remove">remove</asp:LinkButton>
                            </ItemTemplate>
                            <EditItemTemplate>
                                 <asp:LinkButton ID="LinkButton3" runat="server" CommandName="update">update</asp:LinkButton>
                                <asp:LinkButton ID="LinkButton4" runat="server" CommandName="cancel">cancel</asp:LinkButton>
                            </EditItemTemplate>
                            <FooterTemplate><asp:LinkButton ID="LinkButton5" runat="server" CommandName="add">add</asp:LinkButton></FooterTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
