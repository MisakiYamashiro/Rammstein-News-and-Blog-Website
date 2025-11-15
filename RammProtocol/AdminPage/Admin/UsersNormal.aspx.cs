using DataAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RammProtocol.AdminPage.Admin
{
    public partial class UsersNormal : System.Web.UI.Page
    {
        DataModel data = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lv_users.DataSource = data.GetUsersNormal();
                lv_users.DataBind();
            }
        }

       
        protected void lv_users_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            data.UserChangeBanStatus(id);
            lv_users.DataSource = data.GetUsersNormal();
            lv_users.DataBind();
        }
    }
}