<%@ Page Title="" Language="C#" MasterPageFile="~/RammProtocol.Master" AutoEventWireup="true" CodeBehind="ViewArticle.aspx.cs" Inherits="RammProtocol.ViewArticle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="article-description">
            <div class="arleft">
                <div class="vote-button-controls">
                    <asp:ImageButton ID="article_imgbtn_upvote" runat="server" ImageUrl="Assets/Imgs/upvote.svg" OnClick="article_imgbtn_upvote_Click" CommandName="Upvote" />

                    <asp:Label ID="article_lbl_upvote_count" runat="server" Text=''></asp:Label>

                    <asp:ImageButton ID="article_imgbtn_downvote" runat="server" ImageUrl="Assets/Imgs/downvote.svg" OnClick="article_imgbtn_downvote_Click" CommandName="Downvote" />

                    <asp:Label ID="article_lbl_downvote_count" runat="server" Text=''></asp:Label>
                </div>

            </div>
            <div class="arright">
                <div class="info-group">
                    <img src="Assets/Imgs/View.svg" alt="Views = " />
                    <asp:Label ID="article_lbl_view" runat="server" Text='ASDASD'></asp:Label>
                </div>
                <div class="info-group">
                    <img src="Assets/Imgs/CalendarDate.svg" alt="Date = " />
                    <asp:Label ID="article_lbl_date" runat="server" Text=''></asp:Label>
                </div>

                <div class="info-group">
                    <img src="Assets/Imgs/UserOutlined.svg" alt="Author = " />
                    <asp:Label ID="article_lbl_author" runat="server" Text=''></asp:Label>
                </div>

                <div class="info-group">
                    <img src="Assets/Imgs/List.svg" alt="Category = " />
                    <asp:Label ID="article_lbl_category" runat="server" Text=''></asp:Label>
                </div>
            </div>


            <div style="clear: both"></div>
        </div>
        <br />
        <div class="view-article-bottomline"></div>
        <br />
        <asp:Label ID="lbl_title" runat="server" Text="sdfgfsdgsfjgfopsjfgopsjfosjf" CssClass="viewArticle-title"></asp:Label>
        <br />
        <br />
        <asp:Image ID="img_articleimg" runat="server" CssClass="viewArticle-img"/>
        <br />
        <br />
        <asp:Label ID="lbl_content" runat="server" Text="adjaspdaodhadahd" CssClass="viewArticle-content"></asp:Label>
    </div>
</asp:Content>
