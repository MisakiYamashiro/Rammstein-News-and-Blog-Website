<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPage/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="CategoryControls.aspx.cs" Inherits="RammProtocol.AdminPage.Admin.CategoryControls" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <asp:ListView ID="lv_categories" runat="server" DataKeyNames="CategoryID" OnItemCommand="lv_categories_ItemCommand" >
            <LayoutTemplate>
                <table class="table" cellspacing="0">
                    <tr>
                        <th>Category ID</th>
                        <th>Name</th>
                        <th>Active?</th>
                        <th>Settings</th>
                    </tr>
                    <asp:PlaceHolder ID="ItemPlaceHolder" runat="server"></asp:PlaceHolder>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Eval("CategoryID") %></td>
                    <td><%# Eval("Name") %></td>
                    <td><%# Eval("IsActiveStr") %></td>
                    <td>
                        <asp:LinkButton ID="lbtn_ChangeActive" runat="server" CssClass="listbutton"  CommandArgument='<%# Eval("CategoryID") %>'>Change Active</asp:LinkButton>
                        <br />
                        <a href='CategoryEdit.aspx?CategoryID=<%# Eval("CategoryID") %>' class="listbutton edit">Edit Category</a>
            </ItemTemplate>
        </asp:ListView>
        <div class="buttons addButton">
            <asp:Button ID="btn_AddCategoryRedirect" runat="server" OnClick="btn_AddCategoryRedirect_Click" CssClass="" Text="Add a New Category"/>
        </div>
    </div>

</asp:Content>
