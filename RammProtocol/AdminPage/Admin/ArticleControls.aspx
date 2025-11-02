<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPage/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="ArticleControls.aspx.cs" Inherits="RammProtocol.ArticleControls" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <asp:ListView ID="lv_Articles" runat="server" OnItemCommand="lv_Articles_ItemCommand">
            <LayoutTemplate>
                <table class="table" cellspacing="0">
                    <tr>
                        <th>Image</th>
                        <th>ID</th>
                        <th>Type</th>
                        <th>Category</th>
                        <th>Author</th>
                        <th>Title</th>
                        <th>Publish Date</th>
                        <th>Views</th>
                        <th>Comments?</th>
                        <th>Is Active</th>
                        <th>Controls</th>
                    </tr>
                    <asp:PlaceHolder ID="ItemPlaceHolder" runat="server"></asp:PlaceHolder>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                    <td>
                        <img src='Assets/ArticleImgs/<%# Eval("ImgLocation") %>' width="80" />
                    </td>
                    <td><%# Eval("ArticleID") %></td>
                    <td><%# Eval("TypeStr") %></td>
                    <td><%# Eval("CategoryStr") %></td>
                    <td><%# Eval("AuthorNameStr") %></td>
                    <td><%# Eval("Title") %></td>
                    <td><%# Eval("Date") %></td>
                    <td><%# Eval("Views") %></td>
                    <td><%# Eval("AllowComments") %></td>
                    <td><%# Eval("IsActive") %></td>

                    <td>
                        <asp:LinkButton ID="lbtn_ChangeActive" runat="server" CssClass="listbutton" CommandArgument='<%# Eval("ArticleID") %>'>Change Active</asp:LinkButton>
                        <br />
                        <a href='EditArticle.aspx?ArticleID=<%# Eval("ArticleID") %>' class="listbutton edit">Edit Article</a>

                    </td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
        <div class="buttons addButton">
            <asp:Button ID="btn_AddCategoryRedirect" runat="server" OnClick="btn_AddCategoryRedirect_Click" CssClass="" Text="Add a New Article" />
        </div>
    </div>
</asp:Content>
