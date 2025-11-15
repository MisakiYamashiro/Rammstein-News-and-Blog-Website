<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPage/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="UsersAuthor.aspx.cs" Inherits="RammProtocol.AdminPage.Admin.UsersAuthor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .content {
            padding: 0 !important;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="headerusers" ...>
    <div class="hu-right disabled">
        <a href="UsersNormal.aspx">Users Controls</a>
    </div>
    <div class="hu-left activated">
        <a href="UsersAuthor.aspx">Author Controls</a>
    </div>
</div>
    <div style="clear:both"></div>
    <div class="container" style="padding:20px">
        <asp:ListView ID="lv_authors" runat="server" OnItemCommand="lv_authors_ItemCommand">
            <LayoutTemplate>
                <table class="table" cellspacing="0">
                    <tr>
                        <th>ID</th>
                        <th>Name</th>
                        <th>Username</th>
                        <th>Lastname</th>
                        <th>Email</th>
                        <th>Password</th>
                        <th>Date of Register</th>
                        <th>Banned?</th>
                        <th>Settings</th>
                    </tr>
                    <asp:PlaceHolder ID="ItemPlaceHolder" runat="server"></asp:PlaceHolder>
                </table>
            </LayoutTemplate>
            <ItemTemplate>
                <tr>
                    <td><%# Eval("UserID") %></td>
                    <td><%# Eval("Name") %></td>
                    <td><%# Eval("Username") %></td>
                    <td><%# Eval("Lastname") %></td>
                    <td><%# Eval("Email") %></td>
                    <td><%# Eval("Password") %></td>
                    <td><%# Eval("DateOfJoin") %></td>
                    <td><%# Eval("IsBannedStr") %></td>
                    <td><asp:LinkButton ID="lbtn_banUser" runat="server" Text="Ban" CssClass="listbutton" style="background-color:red; color:white" CommandArgument='<%# Eval("UserID") %>'></asp:LinkButton></td>
                </tr>
            </ItemTemplate>
        </asp:ListView>
    </div>
</asp:Content>
