<%@ Page Title="" Language="C#" MasterPageFile="~/RammProtocol.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RammProtocol.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <asp:Repeater ID="rp_articles" runat="server" OnItemCommand="rp_articles_ItemCommand" OnItemDataBound="rp_articles_ItemDataBound">
            <ItemTemplate>
                <article class="article">
                    <div class="article-img-col">
                        <img src='Assets/Imgs/ArticleImgs/<%# Eval("ImgLocation") %>' class="article-img" alt="Article Image" />
                    </div>
                    <div class="article-content-col">
                        <%--<div class="border-above-article"></div>--%>
                        <div class="article-description">
                            <div class="arleft">
                                <div class="vote-button-controls">
                                    <asp:ImageButton ID="article_imgbtn_upvote" runat="server" ImageUrl="Assets/Imgs/upvote.svg" OnClick="article_imgbtn_upvote_Click" CommandArgument='<%# Eval("ArticleID") %>' CommandName="Upvote" />
                                    <asp:Label ID="article_lbl_upvote_count" runat="server" Text='<%# Eval("Upvote") %>'></asp:Label>
                                    <asp:ImageButton ID="article_imgbtn_downvote" runat="server" ImageUrl="Assets/Imgs/downvote.svg" OnClick="article_imgbtn_downvote_Click" CommandArgument='<%# Eval("ArticleID") %>' CommandName="Downvote" />
                                    <asp:Label ID="article_lbl_downvote_count" runat="server" Text='<%# Eval("Downvote") %>'></asp:Label>
                                </div>

                            </div>
                            <div class="arright">
                                <div class="info-group">
                                    <img src="Assets/Imgs/CalendarDate.svg" alt="Date = " />
                                    <asp:Label ID="article_lbl_date" runat="server" Text='<%# TruncateContent1(Eval("Date"), 10)%>'></asp:Label>
                                </div>

                                <div class="info-group">
                                    <img src="Assets/Imgs/UserOutlined.svg" alt="Author = " />
                                    <asp:Label ID="article_lbl_author" runat="server" Text='<%# Eval("AuthorNameStr")%>'></asp:Label>
                                </div>

                                <div class="info-group">
                                    <img src="Assets/Imgs/List.svg" alt="Category = " />
                                    <asp:Label ID="article_lbl_category" runat="server" Text='<%# Eval("CategoryStr") %>'></asp:Label>
                                </div>
                            </div>
                            <div style="clear: both"></div>
                        </div>
                        <div class="border-above-article"></div>
                        <a href="ViewArticle.aspx?Article=<%# Eval("ArticleID") %>" class="hoi4gng"><%# Eval("Title") %></a>

                        <p><%# TruncateContent(Eval("Content"), 300) %></p>
                    </div>
                </article>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
