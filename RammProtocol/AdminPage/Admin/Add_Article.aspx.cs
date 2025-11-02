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
    public partial class Add_Article : System.Web.UI.Page
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
            }
        }



        protected void btn_addarticle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_Title.Text))
            {
                if (!string.IsNullOrEmpty(tb_Content.Text))
                {
                    Articles article = new Articles();
                    article.TypeID = Convert.ToInt32(ddl_Types.SelectedValue);
                    article.CategoryID = Convert.ToInt32(ddl_Categories.SelectedValue);
                    if (cb_AllowComments.Checked)
                    {
                        article.AllowComments = true;
                        article.AllowCommentsStr = "Allowed";
                    }
                    else
                    {
                        article.AllowComments = false;
                        article.AllowCommentsStr = "Not Allowed";
                    }
                    if (cb_Active.Checked)
                    {
                        article.IsActive = true;
                        article.IsActiveStr = "Active";
                    }
                    else
                    {
                        article.IsActive = false;
                        article.IsActiveStr = "Not Active";
                    }
                    article.AuthorID = ((Users)Session["Admin"]).UserID;
                    article.AuthorNameStr = ((Users)Session["Admin"]).Username;
                    article.Title = tb_Title.Text;
                    article.Content = tb_Content.Text;
                    article.Date = DateTime.Now;
                    article.UpdateDate = DateTime.Now;
                    if (fu_img.HasFile)
                    {
                        FileInfo file = new FileInfo(fu_img.FileName);
                        string ext = file.Extension;
                        if (ext == ".jpg" || ext == ".jpeg" || ext == ".png")
                        {
                            string filename = Convert.ToString(Guid.NewGuid());
                            string fullname = filename + ext;
                            article.ImgLocation = fullname;
                            fu_img.SaveAs(Server.MapPath("Assets/ArticleImgs/" + fullname));
                            if (data.AddArticle(article))
                            {
                                Response.Redirect("ArticleControls.aspx");
                            }
                            else
                            {
                                pnl_no.Visible = true;
                                lbl_no.Visible = true;
                                lbl_no.Text = "There was a problem while adding the article.";
                            }
                        }
                        else
                        {
                            pnl_no.Visible = true;
                            lbl_no.Visible = true;
                            lbl_no.Text = "Only .jpg, .jpeg and .png files are allowed.";

                        }


                    }
                    else
                    {
                        pnl_no.Visible = true;
                        lbl_no.Visible = true;
                        lbl_no.Text = "Please upload an image file.";
                    }
                }
            }
        }
    }
}