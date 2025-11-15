using DataAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RammProtocol
{
    public partial class RammProtocol : System.Web.UI.MasterPage
    {
        DataModel data = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["User"] != null)
                {
                    rp_lbtn_signin.Visible = false;
                    rp_lbtn_signup.Visible = false;
                    rp_lbl_username.Visible = true;
                    rp_lbtn_logout.Visible = true;
                    Users user = (Users)Session["User"];
                    rp_lbl_username.Text = user.Username;
                }
                else
                {
                    rp_lbtn_signin.Visible = true;
                    rp_lbtn_signup.Visible = true;
                    rp_lbl_username.Visible = false;
                    rp_lbtn_logout.Visible = false;
                }
            }
            
        }
        protected void btn_silent_Click(object sender, EventArgs e)
        {

        }


        protected void rp_lbtn_logout_Click(object sender, EventArgs e)
        {
            Session["User"] = null;
            Response.Redirect("Default.aspx");
        }

        protected void rp_lbtn_signin_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginUser.aspx");
        }

        protected void rp_lbtn_signup_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegisterUser.aspx");
        }
    }
}