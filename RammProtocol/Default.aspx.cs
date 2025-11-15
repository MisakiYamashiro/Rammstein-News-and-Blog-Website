
using DataAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RammProtocol
{
    public partial class Default : System.Web.UI.Page
    {
        DataModel data = new DataModel();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                rp_articles.DataSource = data.GetArticles(true);
                rp_articles.DataBind();
            }


        }

        public string TruncateContent(object content, int maxLength = 300)
        {
            if (content == null) return string.Empty;
            string str = content.ToString();
            if (str.Length <= maxLength) return str;
            return str.Substring(0, maxLength) + "..."; ;
        }
        public string TruncateContent1(object content, int maxLength = 300)
        {
            if (content == null) return string.Empty;
            string str = content.ToString();
            if (str.Length <= maxLength) return str;
            return str.Substring(0, maxLength) + "."; ;
        }
        protected void article_lbtn_hoi4gng_Click(object sender, EventArgs e)
        {

        }

        protected void article_imgbtn_upvote_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void article_imgbtn_downvote_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void rp_articles_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (Session["User"] == null)
            {
                Response.Redirect("LoginUser.aspx");
                return;
            }
            else
            {
                int artid = Convert.ToInt32(e.CommandArgument);

                Users ActiveUser = (Users)Session["User"];
                int userid = ActiveUser.UserID;

                if (e.CommandName == "Upvote")
                {
                    data.HandleVote(userid, artid, true);
                }
                else if (e.CommandName == "Downvote")
                {
                    data.HandleVote(userid, artid, false);
                }

                rp_articles.DataSource = data.GetArticles(true);
                rp_articles.DataBind();
            }
        }

        protected void rp_articles_ItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                if (Session["User"] == null)
                {
                    return;
                }

                Users activeUser = (Users)Session["User"];
                int userid = activeUser.UserID;

                ImageButton btnUpvote = (ImageButton)e.Item.FindControl("article_imgbtn_upvote");
                int artid = Convert.ToInt32(btnUpvote.CommandArgument);

                int voteStatus = data.GivenVote(userid, artid);

                if (voteStatus == 1)
                {
                    btnUpvote.ImageUrl = "Assets/Imgs/upvotesari.svg";
                }
                else if (voteStatus == 2)
                {
                    ImageButton btnDownvote = (ImageButton)e.Item.FindControl("article_imgbtn_downvote");
                    btnDownvote.ImageUrl = "Assets/Imgs/downvotesari.svg";
                }
            }
        }
    }
}