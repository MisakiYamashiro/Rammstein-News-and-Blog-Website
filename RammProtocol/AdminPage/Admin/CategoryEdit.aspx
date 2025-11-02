<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPage/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="CategoryEdit.aspx.cs" Inherits="RammProtocol.AdminPage.Admin.CategoryEdit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Edit Category</h1>
    <br />
    <br />
    <asp:Panel ID="pnl_yes" runat="server" CssClass="panel" Visible="false">
        <asp:Label ID="lbl_yes" runat="server" Text="Changes saved successfully!" CssClass="label"></asp:Label>
    </asp:Panel>
    <asp:Panel ID="pnl_no" runat="server" CssClass="panel no" Visible="false">
        <asp:Label ID="lbl_no" runat="server" Text="sdsrtsrgfdgfdhf" CssClass="label"></asp:Label>
    </asp:Panel>
    <div class="container">
        <asp:Label ID="lbl_status" runat="server" Text="" CssClass="label"></asp:Label>
        <br />
        <asp:Label ID="lbl_categoryID" runat="server" Text="Category ID: " CssClass="label"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lbl_name" runat="server" Text="Name: " CssClass="label"></asp:Label>
        <asp:TextBox ID="txt_name" runat="server" CssClass="textbox"></asp:TextBox>
        <br />
        <br />
        <asp:CheckBox ID="chk_isActive" runat="server" Text="Is Active" CssClass="checkbox label" />
        <br />
        <br />
        <br />
        <div class="buttons">
            <asp:Button ID="btn_save" runat="server" Text="Save Changes" OnClick="btn_save_Click" />
        </div>
        
    </div>
</asp:Content>
