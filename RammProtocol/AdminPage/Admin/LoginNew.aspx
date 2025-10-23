<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginNew.aspx.cs" Inherits="RammProtocol.AdminPage.SignControls.LoginNew" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>RammProtocol Admin Login</title>
    <link href="Assets/CSS\LoginNew.css" rel="stylesheet" />
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Inter:ital,opsz,wght@0,14..32,100..900;1,14..32,100..900&family=SUSE+Mono:ital,wght@0,100..800;1,100..800&display=swap" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">

        <div class="page-container">
            <div class="left">
                <img src="Assets/Img/004.jpg" />
            </div>
            <div class="right">
                <div class="login">
                    <div class="baslik">
                        <asp:Panel ID="pnl_yes" runat="server"  CssClass="panel" Visible="false" >
                            <asp:Label ID="lbl_yes" runat="server" Text="exampleNO" Visible="false" ></asp:Label>
                        </asp:Panel>
                        <h3>Welcome Back!</h3>
                        <h4>Please Enter Your Details.</h4>
                    </div>

                    <div class="InputBox">
                        <label>Username</label>
                        <br />
                        <asp:TextBox ID="tb_username" runat="server" placeholder="Email" Text="misakidev"></asp:TextBox>
                    </div>
                    <div class="InputBox">
                        <label>Password</label>
                        <br />
                        <asp:TextBox ID="tb_password" runat="server" placeholder="Password" Text="1234"></asp:TextBox>
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
