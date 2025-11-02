using DataAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RammProtocol.AdminPage.Admin
{
    public partial class AddCategory : System.Web.UI.Page
    {
        DataModel data = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_save_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_name.Text))
            {
                Category catadd = new Category();
                catadd.Name = txt_name.Text;
                catadd.IsActive = chk_isActive.Checked;
                if (data.AddCategory(catadd))
                {
                    Response.Redirect("CategoryControls.aspx");
                }
                else
                {
                    pnl_no.Visible = true;
                    lbl_no.Text = "There is a problem while adding category.";
                    pnl_yes.Visible = false;
                    lbl_yes.Text = "";
                }
            }
            else
            {
                pnl_no.Visible = true;  
                lbl_no.Text = "Name can't be empty.";
                pnl_yes.Visible = false;
                lbl_yes.Text = "";
            }
            
            

            
        }
    }
}