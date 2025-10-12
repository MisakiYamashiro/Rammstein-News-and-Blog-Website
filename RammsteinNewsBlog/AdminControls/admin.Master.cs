using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace RammsteinNewsBlog.AdminControls
{
    public partial class admin : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["admin"] != null)
            {
                Users user = (Users)Session["admin"];
                lbl_admin.Text = user.Username;
            }
            else
            {
                Response.Redirect("~/SignControls/SignIn.aspx");
            }
            
        }

        protected void lbtn_logout_Click(object sender, EventArgs e)
        {
            Session["admin"] = null;
            Response.Redirect("~/SignControls/SignIn.aspx");
        }
    }
}