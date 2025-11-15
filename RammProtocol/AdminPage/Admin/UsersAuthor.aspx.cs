using DataAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RammProtocol.AdminPage.Admin
{
    public partial class UsersAuthor : System.Web.UI.Page
    {
        DataModel data = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lv_authors.DataSource = data.GetUsers();
                lv_authors.DataBind();
                
            }
        }

        protected void lv_authors_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            data.UserChangeBanStatus(id);
            lv_authors.DataSource = data.GetUsers();
            lv_authors.DataBind();
        }
    }
}