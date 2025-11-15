using DataAL;
using System;
using System.Web.UI;

namespace RammProtocol
{
    public partial class ViewArticle : System.Web.UI.Page
    {
        DataModel data = new DataModel();

        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["Article"]);
            Articles article = data.GetArticlesWhereID(id);
            if (!IsPostBack)
            {
                article_lbl_downvote_count.Text = article.Downvote.ToString();
                article_lbl_upvote_count.Text = article.Upvote.ToString();
                article_lbl_date.Text = article.Date.ToString();
                article_lbl_view.Text = article.Views.ToString();
                article_lbl_author.Text = article.AuthorNameStr;
                article_lbl_category.Text = article.CategoryStr;
                lbl_title.Text = article.Title;
                lbl_content.Text = article.Content;
                img_articleimg.ImageUrl = "Assets/Imgs/ArticleImgs/" + article.ImgLocation;

                if (Session["User"] == null)
                {

                }
                else
                {
                    Users user = (Users)Session["User"];
                    int userID = user.UserID;
                    if (data.CheckViewed(userID, id) == true)
                    {

                    }
                    else if (data.CheckViewed(userID, id) == false)
                    {
                        data.AddViewed(userID, id);
                    }
                }

            }
        }

        protected void article_imgbtn_upvote_Click(object sender, ImageClickEventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["Article"]);
            if (Session["User"] == null)
            {
                Response.Redirect("LoginUser.aspx");
                return;
            }
            else
            {
                Users ActiveUser = (Users)Session["User"];
                int userid = ActiveUser.UserID;
                data.HandleVote(userid, id, true);
            }
            Articles article = data.GetArticlesWhereID(id);
            article_lbl_downvote_count.Text = article.Downvote.ToString();
            article_lbl_upvote_count.Text = article.Upvote.ToString();
        }

        protected void article_imgbtn_downvote_Click(object sender, ImageClickEventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["Article"]);
            if (Session["User"] == null)
            {
                Response.Redirect("LoginUser.aspx");
                return;
            }
            else
            {
                Users ActiveUser = (Users)Session["User"];
                int userid = ActiveUser.UserID;
                data.HandleVote(userid, id, false);
            }
            Articles article = data.GetArticlesWhereID(id);
            article_lbl_downvote_count.Text = article.Downvote.ToString();
            article_lbl_upvote_count.Text = article.Upvote.ToString();
        }



    }
}