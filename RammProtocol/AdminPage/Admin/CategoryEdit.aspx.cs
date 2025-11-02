using DataAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RammProtocol.AdminPage.Admin
{
    public partial class CategoryEdit : System.Web.UI.Page
    {
        DataModel data = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString.Count != 0)
            {
                if (!IsPostBack)
                {
                    LoadCategoryData();
                }
            }
            else
            {
                Response.Redirect("CategoryControls.aspx");
            }
        }
        private void LoadCategoryData()
        {
            int id = Convert.ToInt32(Request.QueryString["CategoryID"]);
            Category cat = data.GetCategoriesWhereID(id);
            lbl_categoryID.Text = "Category ID: " + cat.CategoryID.ToString();
            txt_name.Text = cat.Name;
            if (cat.IsActive == true)
            {
                lbl_status.Text = "Status: Active";
                chk_isActive.Checked = true;
            }
            else
            {
                lbl_status.Text = "Status: Not Active";
                chk_isActive.Checked = false;
            }


        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_name.Text))
            {
                Category catnew = new Category();
                catnew.IsActive = chk_isActive.Checked;
                catnew.Name = txt_name.Text;
                catnew.CategoryID = Convert.ToInt32(Request.QueryString["CategoryID"]);
                data.UpdateCategory(catnew);
                Response.Redirect("CategoryControls.aspx");
            }
            else
            {
                pnl_no.Visible = true;
                pnl_yes.Visible = false;
                lbl_no.Text = "Name can't be empty.";
            }
        }
    }
}