<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="RammProtocol.AdminPage.SignControls.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSS\Login.css" rel="stylesheet" />
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Inter:ital,opsz,wght@0,14..32,100..900;1,14..32,100..900&family=SUSE+Mono:ital,wght@0,100..800;1,100..800&display=swap" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="tasiyici">
                <div class="loginBox">
                    <asp:Panel ID="pnl_yes" runat="server" CssClass="panel" Visible="false">
                        <asp:Label ID="lbl_yes" runat="server" Text="exampleYES" Visible="false" ></asp:Label>
                    </asp:Panel>
                    <h3>Login Page</h3>
                    <h4>Please Enter Your Details.</h4>

                    <div class="textbox">
                        <label style="margin-top: 30px;">Mail</label>
                        <br />
                        <asp:TextBox ID="tb_mail" runat="server"></asp:TextBox>
                    </div>

                    <div class="textbox">
                        <label>Password</label>
                        <br />
                        <asp:TextBox ID="tb_password" runat="server" TextMode="Password"></asp:TextBox>
                    </div>
                    <div class="buton">
                        <asp:Button ID="btn_login" runat="server" Text="Login" OnClick="btn_login_Click" />
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
