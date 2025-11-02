<%@ Page Title="" Language="C#" MasterPageFile="~/AdminPage/Admin/Admin.Master" AutoEventWireup="true" CodeBehind="Add_Article.aspx.cs" Inherits="RammProtocol.Add_Article" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="left">
            <asp:Panel ID="pnl_yes" runat="server" CssClass="panel" Visible="false">
                <asp:Label ID="lbl_yes" runat="server" Text="Changes saved successfully!" CssClass="label"></asp:Label>
            </asp:Panel>
            <asp:Panel ID="pnl_no" runat="server" CssClass="panel no" Visible="false">
                <asp:Label ID="lbl_no" runat="server" Text="sdsrtsrgfdgfdhf" CssClass="label"></asp:Label>
            </asp:Panel>
            <h1>Add Article.</h1>
            <br />
            <div class="control-bar">
                <label>Select a Type</label>
                <br />
                <asp:DropDownList ID="ddl_Types" runat="server"></asp:DropDownList>
            </div>
            <div class="control-bar">
                <br />
                <label>Select a Category</label>
                <br />
                <asp:DropDownList ID="ddl_Categories" runat="server"></asp:DropDownList>
            </div>

            <div class="control-bar">
                <br />
                <asp:CheckBox ID="cb_AllowComments" runat="server" CssClass="checkbox" />
                <label>Allow Comments?</label>
            </div>
            <br />
            <div class="control-bar">
                <asp:CheckBox ID="cb_Active" runat="server" CssClass="checkbox" />
                <label>Publish Now?</label>
            </div>
            <div class="buttons">
                <asp:Button ID="btn_addarticle" runat="server" Text="Add Article" OnClick="btn_addarticle_Click"/>
            </div>
        </div>
        <div class="right">
            <div class="control-bar">
                <label>Article Image</label>
                <br />
                <asp:FileUpload ID="fu_img" runat="server" CssClass="textbox" />
            </div>
            <div class="control-bar">
                <br />
                <label>Title</label>
                <br />
                <asp:TextBox ID="tb_Title" runat="server" Text="" Style="width: 480px" CssClass="textbox"></asp:TextBox>
            </div>


            <div class="control-bar">
                <br />
                <label>Content</label>
                <br />
                <asp:TextBox ID="tb_Content" runat="server" Text="" TextMode="MultiLine" Style="width: 480px; height: 400px;"></asp:TextBox>
            </div>
        </div>
        <div class="imgArea">
            <asp:Image ID="img_picture" runat="server" Style="width: 420px" />
        </div>
    </div>



</asp:Content>
