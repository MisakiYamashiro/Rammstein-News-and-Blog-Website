using DataAL;
using RammProtocol.AdminPage.SignControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RammProtocol.AdminPage.Admin
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Admin"] != null)
            {
                Users u = (Users)Session["Admin"];
                lbl_admin.Text = u.Username;
            }
            else
            {
                Response.Redirect("LoginNew.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }
        }

        protected void lbtn_cikisyap_Click(object sender, EventArgs e)
        {
            Session["Admin"] = null;
            Response.Redirect("LoginNew.aspx", false);
            Context.ApplicationInstance.CompleteRequest();
        }

        protected void btn_articlecontrols_Click(object sender, EventArgs e)
        {

        }

        protected void btn_typecontrols_Click(object sender, EventArgs e)
        {

        }

        protected void btn_categorycontrols_Click(object sender, EventArgs e)
        {

        }

        protected void btn_usercontrols_Click(object sender, EventArgs e)
        {

        }

        protected void btn_commentscontrols_Click(object sender, EventArgs e)
        {

        }
    }
}