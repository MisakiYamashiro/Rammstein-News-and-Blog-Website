<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignIn.aspx.cs" Inherits="RammsteinNewsBlog.SignControls.SignIn" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <link href="Assets\CSS\SignIn.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="tasiyici">
                <div class="login">
                    <div class="baslik">
                        <h1>Login Page</h1>
                        <h4>Please enter your details.</h4>
                    </div>
                    <div class="satir">
                        <label class="etiket">Username</label>
                        <asp:TextBox ID="tb_username" runat="server" CssClass="input" Text="misakidev" ></asp:TextBox>
                    </div>
                    <div class="satir">
                        <label class="etiket">Password</label>
                        <asp:TextBox ID="tb_password" runat="server" CssClass="input" Text="1234"></asp:TextBox>
                    </div>
                    <div class="buton">
                        <asp:Button ID="btn_login" runat="server" Text="Login" CssClass="aspbutton" OnClick="btn_login_Click"/>
                    </div>
                    <div class="hatamesaj">
                        <asp:Label ID="lbl_message" runat="server" CssClass="hatamesaj" Visible="false"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
