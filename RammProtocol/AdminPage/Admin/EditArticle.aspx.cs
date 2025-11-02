using DataAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RammProtocol
{
    public partial class EditArticle : System.Web.UI.Page
    {
        DataModel data = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddl_Types.DataSource = data.GetTypes();
                ddl_Types.DataTextField = "Name";
                ddl_Types.DataValueField = "TypeID";
                ddl_Types.DataBind();

                ddl_Categories.DataSource = data.GetCategories();
                ddl_Categories.DataTextField = "Name";
                ddl_Categories.DataValueField = "CategoryID";
                ddl_Categories.DataBind();
                Doldur();
            }
        }
        private void Doldur()
        {
            if (Request.QueryString.Count != 0)
            {
                Articles a = data.GetArticlesWhereID(Convert.ToInt32(Request.QueryString["ArticleID"]));
                ddl_Types.SelectedValue = a.TypeID.ToString();
                ddl_Categories.SelectedValue = a.CategoryID.ToString();
                cb_AllowComments.Checked = a.AllowComments;
                cb_Active.Checked = a.IsActive;
                tb_Title.Text = a.Title;
                tb_Content.Text = a.Content;
                img_picture.ImageUrl = "Assets/ArticleImgs/" + a.ImgLocation;

            }
            else
            {
                Response.Redirect("ArticleControls.aspx");
            }
        }
        protected void btn_saveArticle_Click(object sender, EventArgs e)
        {
            Articles ab = data.GetArticlesWhereID(Convert.ToInt32(Request.QueryString["ArticleID"]));
            ab.ArticleID = Convert.ToInt32(Request.QueryString["ArticleID"]);
            ab.TypeID = Convert.ToInt32(ddl_Types.SelectedValue);
            ab.CategoryID = Convert.ToInt32(ddl_Categories.SelectedValue);
            if (Session["AdminID"] != null)
            {
                ab.AuthorID = Convert.ToInt32(Session["AdminID"]);
            }
            if (tb_Title.Text != null)
            {
                ab.Title = tb_Title.Text;
            }
            else
            {
                No();   
                lbl_no.Text = "Title field cannot be empty.";
            }
            if (tb_Content.Text != null)
            {
                ab.Content = tb_Content.Text;
            }
            else
            {
                No();
                lbl_no.Text = "Content field cannot be empty.";
            }
            ab.UpdateDate = DateTime.Now;
            ab.AllowComments = cb_AllowComments.Checked;
            ab.IsActive = cb_Active.Checked;
            if (fu_img.HasFile)
            {
                FileInfo file = new FileInfo(fu_img.FileName);
                string guidname = Guid.NewGuid().ToString();
                string ex = file.Extension;
                if (ex == ".jpg" || ex == ".jpeg" || ex == ".png")
                {
                    ab.ImgLocation = guidname;
                    fu_img.SaveAs(Server.MapPath("Assets/ArticleImgs/" + guidname));
                }
                else
                {
                    pnl_no.Visible = true;
                    lbl_no.Visible = true;
                    pnl_yes.Visible = false;
                    lbl_no.Text = "File format is invalid. You can only upload .jpg .jpeg .png files.";
                }
            }
            if (data.UpdateArticle(ab))
            {
                Yes();
                 lbl_yes.Text = "Article Edited!";
                Response.Redirect("ArticleControls.aspx");
                
            }
            else
            {
                No();
                lbl_no.Text = "There is a problem while editing article.";  
            }
        }

        private void Yes()
        {
            pnl_yes.Visible = true;
            lbl_no.Visible = false;
            pnl_no.Visible = false;
            lbl_yes.Visible = true;
        }
        private void No()
        {
            pnl_yes.Visible = false;
            lbl_no.Visible = true;
            pnl_no.Visible = true;
            lbl_yes.Visible = false;
        }
    }
}
