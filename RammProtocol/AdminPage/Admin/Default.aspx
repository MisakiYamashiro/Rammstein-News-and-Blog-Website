<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPage/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RammProtocol.AdminPage.Admin.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="dashboard">
            <div class="member-count-imgsvg">
                <img src="Assets/Img/members.svg" alt="Alternate Text" />
                <asp:Label ID="lbl_membercountText" runat="server" Text="Member Count = "></asp:Label>
                <br />
                <asp:Label ID="lbl_membercount" runat="server" Text="1231" CssClass="mc"></asp:Label>
            </div>
            <div class="member-count-imgsvg">
                <img src="Assets/Img/newspaper.svg" alt="Alternate Text" />
                <asp:Label ID="lbl_articlecountText" runat="server" Text="Article Count = "></asp:Label>
                <br />
                <asp:Label ID="lbl_articlecount" runat="server" Text="1231" CssClass="mc"></asp:Label>
            </div>
        </div>
    </div>
</asp:Content>
