<%@ Page Title="" Language="C#" MasterPageFile="~/RammProtocol.Master" AutoEventWireup="true" CodeBehind="LoginUser.aspx.cs" Inherits="RammProtocol.LoginUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Assets/CSS/Master.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="loginBox">
            <asp:Panel ID="pnl_yes" runat="server" CssClass="panel" Visible="false">
                <asp:Label ID="lbl_yes" runat="server" Text="exampleYES" Visible="false"></asp:Label>
            </asp:Panel>
            <h3>Login Page</h3>
            <h4>Please Enter Your Details.</h4>

            <div class="textbox">
                <label style="margin-top: 30px;">Mail</label>
                <br />
                <asp:TextBox ID="tb_mail" runat="server" CssClass="moddedtb"></asp:TextBox>
            </div>

            <div class="textbox">
                <label>Password</label>
                <br />
                <asp:TextBox ID="tb_password" runat="server" TextMode="Password" CssClass="moddedtb"></asp:TextBox>
            </div>
            <div class="buton">
                <asp:Button ID="btn_login" runat="server" Text="Login" OnClick="btn_login_Click"  />
            </div>
        </div>
    </div>
</asp:Content>
