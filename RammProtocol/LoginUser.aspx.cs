using DataAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RammProtocol
{
    public partial class LoginUser : System.Web.UI.Page
    {
        DataModel data = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_mail.Text))
            {
                if (!string.IsNullOrEmpty(tb_password.Text))
                {
                    Users user = data.UserLogin(tb_mail.Text, tb_password.Text);
                    Session["User"] = user; 
                    Response.Redirect("Default.aspx");
                }
                else
                {
                    pnl_yes.Visible = true;
                    lbl_yes.Text = "Password can't be empty.";
                }
            }
            else
            {
                pnl_yes.Visible = true;
                lbl_yes.Text = "Email can't be empty.";
            }
        }
    }
}