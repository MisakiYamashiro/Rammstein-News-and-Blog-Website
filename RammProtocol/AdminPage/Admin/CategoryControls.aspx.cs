using DataAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RammProtocol.AdminPage.Admin
{
    public partial class CategoryControls : System.Web.UI.Page
    {
        DataModel data = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lv_categories.DataSource = data.GetCategories();
                lv_categories.DataBind();
                
            }
        }

        

        protected void lv_categories_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            int id = Convert.ToInt32(e.CommandArgument);
            
                data.CategoryChangeActivity(id);
            
            List();


        }
        private void List()
        {
            lv_categories.DataSource = data.GetCategories();
            lv_categories.DataBind();

        }
        private void Delete()
        {
            
        }

        

        protected void btn_AddCategoryRedirect_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddCategory.aspx");
        }
    }
}