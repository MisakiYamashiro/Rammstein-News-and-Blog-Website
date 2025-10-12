using System;
using System.Web.UI.WebControls;
using DataAccessLayer;
namespace RammsteinNewsBlog.SignControls
{
    public partial class SignIn : System.Web.UI.Page
    {
        DataModel dm = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void cb_showpassword_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_username.Text))
            {
                if (!string.IsNullOrEmpty(Convert.ToString(tb_password.Text)))
                {
                    Users user = dm.Login(tb_username.Text, tb_password.Text);
                    if (user != null)
                    {
                        Session["admin"] = user;
                        Response.Redirect("~/AdminControls/Defualt.aspx");
                    }
                    else
                    {
                        lbl_message.Visible = true;
                        lbl_message.Text = "Invalid username or password.";
                    }
                }
                else
                {
                    lbl_message.Visible = true;
                    lbl_message.Text = "Password cannot be empty.";
                }
            }
            else
            {
                lbl_message.Visible = true;
                lbl_message.Text = "Username cannot be empty.";
            }
        }
    }
}