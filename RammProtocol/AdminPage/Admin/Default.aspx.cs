using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAL;

namespace RammProtocol.AdminPage.Admin
{
    public partial class Default : System.Web.UI.Page
    {
        DataModel data = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_membercount.Text = data.CheckMemberCount();
            lbl_articlecount.Text = data.CheckArticleCount();
        }
    }
}