using DataAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RammProtocol
{
    public partial class ArticleControls : System.Web.UI.Page
    {
        DataModel data = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lv_Articles.DataSource = data.GetArticles();
                lv_Articles.DataBind();
            }
            

        }

        protected void btn_AddCategoryRedirect_Click(object sender, EventArgs e)
        {
            Response.Redirect("Add_Article.aspx");
        }

        protected void lv_Articles_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            data.ArticleChangeActivity(id);
            lv_Articles.DataSource = data.GetArticles();
            lv_Articles.DataBind();

        }
    }
}