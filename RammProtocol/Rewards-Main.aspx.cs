using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RammProtocol
{
    public partial class Rewards_Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void imgbtn_cert_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("certifications.aspx");
        }

        protected void imgbtn_award_Click(object sender, ImageClickEventArgs e)
        {

        }
    }
}