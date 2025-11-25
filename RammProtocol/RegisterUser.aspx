<%@ Page Title="" Language="C#" MasterPageFile="~/RammProtocol.Master" AutoEventWireup="true" CodeBehind="RegisterUser.aspx.cs" Inherits="RammProtocol.RegisterUser" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="loginBox">
            <asp:Panel ID="pnl_yes" runat="server" CssClass="panel" Visible="false">
                <asp:Label ID="lbl_yes" runat="server" Text="exampleYES" Visible="false"></asp:Label>
            </asp:Panel>
            
            <h3>Register Page</h3>
            <h4>Please Enter Your Details.</h4>
            <div class="southside">
                <div class="textbox">
                    <label style="margin-top: 30px;">Name</label>
                    <br />
                    <asp:TextBox ID="tb_name" runat="server" CssClass="moddedtb"></asp:TextBox>
                </div>
                <div class="textbox">
                    <label style="margin-top: 30px;">Username</label>
                    <br />
                    <asp:TextBox ID="tb_username" runat="server" CssClass="moddedtb"></asp:TextBox>
                </div>
                <div class="textbox">
                    <label style="margin-top: 30px;">Lastname</label>
                    <br />
                    <asp:TextBox ID="tb_lastname" runat="server" CssClass="moddedtb"></asp:TextBox>
                </div>
            </div>
            <div class="westside">
                <div class="textbox">
                    <label style="margin-top: 30px;">Mail</label>
                    <br />
                    <asp:TextBox ID="tb_mail" runat="server" CssClass="moddedtb"></asp:TextBox>
                </div>
                <div class="textbox">
                    <label style="margin-top: 30px;">Password</label>
                    <br />
                    <asp:TextBox ID="tb_password" runat="server" CssClass="moddedtb" TextMode="Password"></asp:TextBox>
                </div>
                <div class="textbox">
                    <label style="margin-top: 30px;">Password Again</label>
                    <br />
                    <asp:TextBox ID="tb_passwordagain" runat="server" CssClass="moddedtb" TextMode="Password"></asp:TextBox>
                </div>

            </div>
            <div class="buton">
                <asp:Button ID="btn_register" runat="server" Text="Register" OnClick="btn_register_Click"/>
            </div>

        </div>
    </div>
</asp:Content>
