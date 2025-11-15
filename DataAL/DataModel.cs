using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAL
{
    public class DataModel
    {
        SqlConnection con;
        SqlCommand cmd;

        public DataModel()
        {
            con = new SqlConnection(ConStrings.LocalString);
            cmd = con.CreateCommand();
        }


        public Users Login(string username, string password)
        {
            try
            {
                cmd.CommandText = "select count(*) from Users where Username=@u and Password=@p and RoleID=2";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);
                con.Open();
                int num = Convert.ToInt32(cmd.ExecuteScalar());
                if (num != 0)
                {
                    Users user = new Users();
                    cmd.CommandText = "select U.UserID,R.RoleID ,R.Name, U.Name, U.Username, U.Lastname,u.Email,u.Password,u.DateOfJoin from Users as U join Roles as R on u.RoleID = R.RoleID where Username=@u and Password=@p";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@u", username);
                    cmd.Parameters.AddWithValue("@p", password);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        user.UserID = reader.GetInt32(0);
                        user.RoleID = reader.GetInt32(1);
                        user.RoleName = reader.GetString(2);
                        user.Name = reader.GetString(3);
                        user.Username = reader.GetString(4);
                        user.Lastname = reader.GetString(5);
                        user.Email = reader.GetString(6);
                        user.Password = reader.GetString(7);
                        user.DateOfJoin = reader.GetDateTime(8);
                    }
                    return user;
                }
                else
                {
                    return null;
                }
            }
            catch { return null; }
            finally { con.Close(); }
        }

        public string CheckMemberCount()
        {
            try
            {
                cmd.CommandText = "select count(*) from Users";
                cmd.Parameters.Clear();
                con.Open();
                int num = Convert.ToInt32(cmd.ExecuteScalar());
                string numStr = Convert.ToString(num);
                return numStr;
            }
            catch
            {
                string hata = "hata";
                return hata;
            }
            finally
            {
                con.Close();
            }


        }
        public string CheckArticleCount()
        {
            try
            {
                cmd.CommandText = "select count(*) from Articles where IsActive=1";
                cmd.Parameters.Clear();
                con.Open();
                int num = Convert.ToInt32(cmd.ExecuteScalar());
                string numStr = Convert.ToString(num);
                return numStr;
            }
            catch
            {
                string hata = "hata";
                return hata;
            }
            finally
            {
                con.Close();
            }


        }
        #region Types
        public List<Types> GetTypes()
        {
            List<Types> types = new List<Types>();
            try
            {
                cmd.CommandText = "select TypeID, Name, IsActive from Types";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Types type = new Types();
                    type.TypeID = reader.GetInt32(0);
                    type.Name = reader.GetString(1);
                    if (type.IsActive)
                    {
                        type.IsActiveStr = "Active";
                    }
                    else
                    {
                        type.IsActiveStr = "Not Active";
                    }
                    types.Add(type);
                }
                return types;

            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region Categories
        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            try
            {
                cmd.CommandText = "select CategoryID, Name, IsActive from Categories";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Category category = new Category();
                    category.CategoryID = reader.GetInt32(0);
                    category.Name = reader.GetString(1);
                    category.IsActive = reader.GetBoolean(2);
                    if (category.IsActive == true)
                    {
                        category.IsActiveStr = "Active";
                    }
                    else
                    {
                        category.IsActiveStr = "Not Active";
                    }
                    categories.Add(category);
                }
                return categories;

            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public Category GetCategoriesWhereID(int id)
        {
            try
            {
                cmd.CommandText = "select CategoryID, Name, IsActive from Categories where CategoryID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Category category = new Category();
                while (reader.Read())
                {

                    category.CategoryID = reader.GetInt32(0);
                    category.Name = reader.GetString(1);
                    category.IsActive = reader.GetBoolean(2);
                    if (category.IsActive == true)
                    {
                        category.IsActiveStr = "Active";
                    }
                    else
                    {
                        category.IsActiveStr = "Not Active";
                    }
                }
                return category;

            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public bool UpdateCategory(Category category)
        {
            try
            {
                cmd.CommandText = "update Categories set Name=@n, IsActive=@ia where CategoryID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@n", category.Name);
                cmd.Parameters.AddWithValue("@ia", category.IsActive);
                cmd.Parameters.AddWithValue("@id", category.CategoryID);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool AddCategory(Category category)
        {
            try
            {
                cmd.CommandText = "insert into Categories (Name, IsActive) values (@n, @ia)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@n", category.Name);
                cmd.Parameters.AddWithValue("@ia", category.IsActive);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        public void DeleteCategory(int catid)
        {
            try
            {
                cmd.CommandText = "delete from Categories where CategoryID=@id";
                cmd.Parameters.Clear();
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
        }
        public void CategoryChangeActivity(int id)
        {
            try
            {
                cmd.CommandText = "update Categories set IsActive= case when IsActive=1 then 0 else 1 end where CategoryID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }

            finally
            {
                con.Close();
            }
        }
        #endregion

        #region Articles

        public void ArticleChangeActivity(int id)
        {
            try
            {
                cmd.CommandText = "update Articles set IsActive= case when IsActive=1 then 0 else 1 end where ArticleID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }

            finally
            {
                con.Close();
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="num">true = returns isactive true false = you understand.</param>
        /// <returns></returns>
        public List<Articles> GetArticles(bool num)
        {
            string query = "select A.ArticleID, T.TypeID, T.Name, C.CategoryID, C.Name, U.UserID, U.Username, A.Title, A.Content, A.Date, A.UpdateDate, A.Upvote, A.Downvote, A.Views, A.Allow_Comments, A.IsActive, A.ImgLocation from Articles as A join Types as T on A.TypeID = T.TypeID join Categories as C on A.CategoryID = C.CategoryID join Users as U on A.AuthorID = U.UserID";
            List<Articles> articles = new List<Articles>();
            try
            {
                if (num == true)
                {
                    cmd.CommandText = query + " where A.IsActive=1 ";
                }
                else if (num == false)
                {
                    cmd.CommandText = query;
                }

                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    Articles article = new Articles();
                    article.ArticleID = r.GetInt32(0);
                    article.TypeID = r.GetInt32(1);
                    article.TypeStr = r.GetString(2);
                    article.CategoryID = r.GetInt32(3);
                    article.CategoryStr = r.GetString(4);
                    article.AuthorID = r.GetInt32(5);
                    article.AuthorNameStr = r.GetString(6);
                    article.Title = r.GetString(7);
                    article.Content = r.GetString(8);
                    article.Date = r.GetDateTime(9).Date;
                    article.ShortDate = r.GetDateTime(9).ToShortDateString();
                    article.UpdateDate = r.GetDateTime(10);
                    article.Upvote = r.GetInt32(11);
                    article.Downvote = r.GetInt32(12);
                    article.Views = r.GetInt32(13);
                    article.AllowComments = r.GetBoolean(14);
                    article.IsActive = r.GetBoolean(15);
                    article.ImgLocation = r.GetString(16);
                    if (article.AllowComments)
                    {
                        article.AllowCommentsStr = "Allowed";
                    }
                    else
                    {
                        article.AllowCommentsStr = "Not Allowed";
                    }
                    if (article.IsActive)
                    {
                        article.IsActiveStr = "Active";
                    }
                    else
                    {
                        article.IsActiveStr = "Not Active";
                    }
                    articles.Add(article);
                }
                return articles;

            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public List<Articles> GetArticles()
        {

            List<Articles> articles = new List<Articles>();
            try
            {
                cmd.CommandText = "select A.ArticleID, T.TypeID, T.Name, C.CategoryID, C.Name, U.UserID, U.Username, A.Title, A.Content, A.Date, A.UpdateDate, A.Upvote, A.Downvote, A.Views, A.Allow_Comments, A.IsActive, A.ImgLocation from Articles as A join Types as T on A.TypeID = T.TypeID join Categories as C on A.CategoryID = C.CategoryID join Users as U on A.AuthorID = U.UserID";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    Articles article = new Articles();
                    article.ArticleID = r.GetInt32(0);
                    article.TypeID = r.GetInt32(1);
                    article.TypeStr = r.GetString(2);
                    article.CategoryID = r.GetInt32(3);
                    article.CategoryStr = r.GetString(4);
                    article.AuthorID = r.GetInt32(5);
                    article.AuthorNameStr = r.GetString(6);
                    article.Title = r.GetString(7);
                    article.Content = r.GetString(8);
                    article.Date = r.GetDateTime(9).Date;
                    article.ShortDate = r.GetDateTime(9).ToShortDateString();
                    article.UpdateDate = r.GetDateTime(10);
                    article.Upvote = r.GetInt32(11);
                    article.Downvote = r.GetInt32(12);
                    article.Views = r.GetInt32(13);
                    article.AllowComments = r.GetBoolean(14);
                    article.IsActive = r.GetBoolean(15);
                    article.ImgLocation = r.GetString(16);
                    if (article.AllowComments)
                    {
                        article.AllowCommentsStr = "Allowed";
                    }
                    else
                    {
                        article.AllowCommentsStr = "Not Allowed";
                    }
                    if (article.IsActive)
                    {
                        article.IsActiveStr = "Active";
                    }
                    else
                    {
                        article.IsActiveStr = "Not Active";
                    }
                    articles.Add(article);
                }
                return articles;

            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public Articles GetArticlesWhereID(int id)
        {
            try
            {
                cmd.CommandText = "select A.ArticleID, T.TypeID, T.Name, C.CategoryID, C.Name, U.UserID, U.Username, A.Title, A.Content, A.Date, A.UpdateDate, A.Upvote, A.Downvote, A.Views, A.Allow_Comments, A.IsActive, A.ImgLocation from Articles as A join Types as T on A.TypeID = T.TypeID join Categories as C on A.CategoryID = C.CategoryID join Users as U on A.AuthorID = U.UserID where ArticleID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader r = cmd.ExecuteReader();
                Articles article = new Articles();

                while (r.Read())
                {

                    article.ArticleID = r.GetInt32(0);
                    article.TypeID = r.GetInt32(1);
                    article.TypeStr = r.GetString(2);
                    article.CategoryID = r.GetInt32(3);
                    article.CategoryStr = r.GetString(4);
                    article.AuthorID = r.GetInt32(5);
                    article.AuthorNameStr = r.GetString(6);
                    article.Title = r.GetString(7);
                    article.Content = r.GetString(8);
                    DateTime date = r.GetDateTime(9);
                    article.Date = date.Date;
                    article.UpdateDate = r.GetDateTime(10);
                    article.Upvote = r.GetInt32(11);
                    article.Downvote = r.GetInt32(12);
                    article.Views = r.GetInt32(13);
                    article.AllowComments = r.GetBoolean(14);
                    article.IsActive = r.GetBoolean(15);
                    article.ImgLocation = r.GetString(16);
                    if (article.AllowComments)
                    {
                        article.AllowCommentsStr = "Allowed";
                    }
                    else
                    {
                        article.AllowCommentsStr = "Not Allowed";
                    }
                    if (article.IsActive)
                    {
                        article.IsActiveStr = "Active";
                    }
                    else
                    {
                        article.IsActiveStr = "Not Active";
                    }
                }
                return article;


            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public bool AddArticle(Articles article)
        {
            try
            {
                cmd.CommandText = "insert into Articles(TypeID,CategoryID,AuthorID,Title,Content,Date,UpdateDate,Upvote,Downvote,Views,Allow_Comments,IsActive,ImgLocation) values(@typeid, @categoryid, @authorid, @title, @content, @date, @updatedate, @upvote, @downvote, @views, @allow_comments, @isactive, @imglocation)";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@typeid", article.TypeID);
                cmd.Parameters.AddWithValue("@categoryid", article.CategoryID);
                cmd.Parameters.AddWithValue("@authorid", article.AuthorID);
                cmd.Parameters.AddWithValue("@title", article.Title);
                cmd.Parameters.AddWithValue("@content", article.Content);
                cmd.Parameters.AddWithValue("@date", article.Date);
                cmd.Parameters.AddWithValue("@updatedate", article.UpdateDate);
                cmd.Parameters.AddWithValue("@upvote", article.Upvote);
                cmd.Parameters.AddWithValue("@downvote", article.Downvote);
                cmd.Parameters.AddWithValue("@views", article.Views);
                cmd.Parameters.AddWithValue("@allow_comments", article.AllowComments);
                if (article.AllowComments)
                {
                    article.AllowCommentsStr = "Active";
                }
                else
                {
                    article.AllowCommentsStr = "Not Active";
                }
                cmd.Parameters.AddWithValue("@isactive", article.IsActive);
                if (article.IsActive)
                {
                    article.IsActiveStr = "Active";
                }
                else
                {
                    article.IsActiveStr = "Not Active";
                }
                cmd.Parameters.AddWithValue("@imglocation", article.ImgLocation);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }

        public bool UpdateArticle(Articles a)
        {
            try
            {

                cmd.CommandText = "update Articles set TypeID=@typeid, CategoryID=@catid, UpdateDate=@ud, Allow_Comments=@ac," +
                    "IsActive=@ia, ImgLocation=@img, Title=@title, Content=@content where ArticleID=@aid";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@aid", a.ArticleID);
                cmd.Parameters.AddWithValue("@typeid", a.TypeID);
                cmd.Parameters.AddWithValue("@catid", a.CategoryID);
                cmd.Parameters.AddWithValue("@ud", a.UpdateDate);
                cmd.Parameters.AddWithValue("@ac", a.AllowComments);
                cmd.Parameters.AddWithValue("@ia", a.IsActive);
                cmd.Parameters.AddWithValue("@img", a.ImgLocation);
                cmd.Parameters.AddWithValue("@title", a.Title);
                cmd.Parameters.AddWithValue("@content", a.Content);
                con.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                con.Close();
            }
        }


       
        #endregion

        #region Users
        public List<Users> GetUsers()
        {
            List<Users> users = new List<Users>();
            try
            {
                cmd.CommandText = "select U.UserID, R.RoleID, R.Name, U.Name, U.Username, U.Lastname, U.Email, U.Password, U.DateOfJoin, U.IsBanned from Users as U join Roles as R on U.RoleID = R.RoleID where R.RoleID=2";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Users user = new Users();
                    user.UserID = reader.GetInt32(0);
                    user.RoleID = reader.GetInt32(1);
                    user.RoleName = reader.GetString(2);
                    user.Name = reader.GetString(3);
                    user.Username = reader.GetString(4);
                    user.Lastname = reader.GetString(5);
                    user.Email = reader.GetString(6);
                    user.Password = reader.GetString(7);
                    user.DateOfJoin = reader.GetDateTime(8);
                    user.IsBanned = reader.GetBoolean(9);
                    if (user.IsBanned == true)
                    {
                        user.IsBannedStr = "Banned";
                    }
                    else
                    {
                        user.IsBannedStr = "Not Banned";
                    }
                    users.Add(user);
                }
                return users;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public List<Users> GetUsersNormal()
        {
            List<Users> users = new List<Users>();
            try
            {
                cmd.CommandText = "select U.UserID, R.RoleID, R.Name, U.Name, U.Username, U.Lastname, U.Email, U.Password, U.DateOfJoin, U.IsBanned from Users as U join Roles as R on U.RoleID = R.RoleID where R.RoleID=1";
                cmd.Parameters.Clear();
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Users user = new Users();
                    user.UserID = reader.GetInt32(0);
                    user.RoleID = reader.GetInt32(1);
                    user.RoleName = reader.GetString(2);
                    user.Name = reader.GetString(3);
                    user.Username = reader.GetString(4);
                    user.Lastname = reader.GetString(5);
                    user.Email = reader.GetString(6);
                    user.Password = reader.GetString(7);
                    user.DateOfJoin = reader.GetDateTime(8);

                    user.IsBanned = reader.GetBoolean(9);
                    if (user.IsBanned == true)
                    {
                        user.IsBannedStr = "Banned";
                    }
                    else
                    {
                        user.IsBannedStr = "Not Banned";
                    }
                    users.Add(user);
                }
                return users;
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public int GetUserArticleCount(int userid)
        {
            try
            {
                cmd.CommandText = "select count(*) from Articles where AuthorID=@uid";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@uid", userid);
                con.Open();
                int num = Convert.ToInt32(cmd.ExecuteScalar());
                return num;
            }
            catch
            {
                return 0;
            }
            finally
            {
                con.Close();
            }
        }

        public int GetUserCommentCount(int userid)
        {
            try
            {
                cmd.CommandText = "select count(*) from Comments where UserID=@uid";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@uid", userid);
                con.Open();
                int num = Convert.ToInt32(cmd.ExecuteScalar());
                return num;
            }
            catch
            {
                return 0;
            }
            finally
            {
                con.Close();
            }
        }

        public void UserChangeBanStatus(int id)
        {
            try
            {
                cmd.CommandText = "update Users set IsBanned= case when IsBanned=1 then 0 else 1 end where UserID=@id";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
            }

            finally
            {
                con.Close();
            }
        }

        public int CheckBan(string mail, string password)
        {
            try
            {
                cmd.CommandText = "select count(*) from Users where Username=@username and IsBanned=1";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@username", mail);
                con.Open();
                int number = Convert.ToInt32(cmd.ExecuteScalar());
                return number;
            }

            finally
            {
                con.Close();
            }
        }

        public Users UserLogin(string mail, string passsword)
        {
            try
            {
                cmd.CommandText = "select Count(*) from Users where Email=@ue and Password=@up";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@ue", mail);
                cmd.Parameters.AddWithValue("@up", passsword);
                con.Open();
                int num = Convert.ToInt32(cmd.ExecuteScalar());
                if (num >= 1)
                {
                    cmd.CommandText = "select U.UserID, R.RoleID, R.Name, U.Name, U.Username, U.Lastname, U.Email, U.Password, U.DateOfJoin, U.IsBanned from Users as U join Roles as R on U.RoleID = R.RoleID where Email=@ue and Password=@up";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@ue", mail);
                    cmd.Parameters.AddWithValue("@up", passsword);
                    Users user = new Users();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                        user.UserID = reader.GetInt32(0);
                        user.RoleID = reader.GetInt32(1);
                        user.RoleName = reader.GetString(2);
                        user.Name = reader.GetString(3);
                        user.Username = reader.GetString(4);
                        user.Lastname = reader.GetString(5);
                        user.Email = reader.GetString(6);
                        user.Password = reader.GetString(7);
                        user.DateOfJoin = reader.GetDateTime(8);
                        user.IsBanned = reader.GetBoolean(9);
                    }
                    return user;

                }
                else
                {
                    return null;
                }
            }
            catch
            {
                return null;
            }
            finally
            {
                con.Close();
            }
        }


        #endregion

        #region Article And Users
        /// <summary>
        /// Checks if the user has viewed the article before
        /// </summary>
        /// <param name="userid">Session User ID</param>
        /// <param name="artid">Clicked Article ID</param>
        /// <returns></returns>
        public bool CheckViewed(int userid, int artid)
        {
            try
            {
                cmd.CommandText = "select count(*) from Viewed_Articles_ByUser where UserID=@uid and ArticleID=@aid";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@uid", userid);
                cmd.Parameters.AddWithValue("@aid", artid);
                con.Open();
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            finally
            {
                con.Close();
            }
        }

        public bool CheckVoted(int userid, int artid)
        {
            try
            {
                cmd.CommandText = "select count(*) from Voted_Articles_ByUser where UserID=@uid and ArticleID=@aid";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@uid", userid);
                cmd.Parameters.AddWithValue("@aid", artid);
                con.Open();
                if (Convert.ToInt32(cmd.ExecuteScalar()) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            finally
            {
                con.Close();
            }
        }
        /// <summary>
        /// Kullanıcının bir makaleye verdiği oyu kontrol eder.
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="artid"></param>
        /// <returns>1: Upvote, 2: Downvote, 3: Oy vermemiş, -1: Hata</returns>
        public int GivenVote(int userid, int artid)
        {
            int voteStatus = 3;
            SqlDataReader r = null; 

            try
            {
                
                cmd.CommandText = "select Upvote, Downvote from Voted_Articles_ByUser where UserID=@uid and ArticleID=@aid";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@uid", userid);
                cmd.Parameters.AddWithValue("@aid", artid);

                con.Open();
                r = cmd.ExecuteReader();

                
                if (r.Read())
                {
                    bool hasUpvoted = r.GetBoolean(0);
                    bool hasDownvoted = r.GetBoolean(1);

                    if (hasUpvoted)
                    {
                        voteStatus = 1; 
                    }
                    else if (hasDownvoted)
                    {
                        voteStatus = 2; 
                    }
                    
                }
                
            }
            catch 
            {
                voteStatus = -1; 
            }
            finally
            {
                
                if (r != null && !r.IsClosed)
                {
                    r.Close();
                }

                
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }

            return voteStatus;
        }

        public void HandleVote(int userid, int artid, bool isUpvoteClick)
        {
            int existingVote = GivenVote(userid, artid);

            string sqlQuery = "";

            if (isUpvoteClick)
            {
                if (existingVote == 1)
                {
                    sqlQuery = @"
                DELETE FROM Voted_Articles_ByUser WHERE UserID=@uid AND ArticleID=@aid;
                UPDATE Articles SET Upvote = Upvote - 1 WHERE ArticleID = @aid;";
                }
                else if (existingVote == 2)
                {
                    sqlQuery = @"
                UPDATE Voted_Articles_ByUser SET Upvote = 1, Downvote = 0 WHERE UserID=@uid AND ArticleID=@aid;
                UPDATE Articles SET Upvote = Upvote + 1, Downvote = Downvote - 1 WHERE ArticleID = @aid;";
                }
                else
                {
                    sqlQuery = @"
                INSERT INTO Voted_Articles_ByUser (UserID, ArticleID, Upvote, Downvote) VALUES (@uid, @aid, 1, 0);
                UPDATE Articles SET Upvote = Upvote + 1 WHERE ArticleID = @aid;";
                }
            }
            else
            {
                if (existingVote == 1)
                {
                    sqlQuery = @"
                UPDATE Voted_Articles_ByUser SET Upvote = 0, Downvote = 1 WHERE UserID=@uid AND ArticleID=@aid;
                UPDATE Articles SET Upvote = Upvote - 1, Downvote = Downvote + 1 WHERE ArticleID = @aid;";
                }
                else if (existingVote == 2)
                {
                    sqlQuery = @"
                DELETE FROM Voted_Articles_ByUser WHERE UserID=@uid AND ArticleID=@aid;
                UPDATE Articles SET Downvote = Downvote - 1 WHERE ArticleID = @aid;";
                }
                else
                {
                    sqlQuery = @"
                INSERT INTO Voted_Articles_ByUser (UserID, ArticleID, Upvote, Downvote) VALUES (@uid, @aid, 0, 1);
                UPDATE Articles SET Downvote = Downvote + 1 WHERE ArticleID = @aid;";
                }
            }

            if (string.IsNullOrEmpty(sqlQuery)) return;

            cmd.CommandText = "BEGIN TRANSACTION; " + sqlQuery + " COMMIT TRANSACTION;";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@uid", userid);
            cmd.Parameters.AddWithValue("@aid", artid);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

        public void AddViewed(int userid, int artid)
        {
            try
            {
                cmd.CommandText = @"
            BEGIN TRANSACTION;
            INSERT INTO Viewed_Articles_ByUser (UserID, ArticleID) VALUES (@uid, @aid);
            UPDATE Articles SET Views = Views + 1 WHERE ArticleID = @aid;
            COMMIT TRANSACTION;";

                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@uid", userid);
                cmd.Parameters.AddWithValue("@aid", artid);

                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }

    #endregion
}

