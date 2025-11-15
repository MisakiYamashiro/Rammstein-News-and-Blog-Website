using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAL
{
    public class Articles
    {
        public int ArticleID { get; set; }
        public int TypeID { get; set; }
        public string TypeStr { get; set; }
        public int CategoryID { get; set; }
        public string CategoryStr { get; set; }
        public int AuthorID { get; set; }
        public string AuthorNameStr { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public string ShortDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public int Upvote { get; set; }
        public int Downvote { get; set; }
        public int Views { get; set; }
        public bool AllowComments { get; set; }
        public string AllowCommentsStr { get; set; }
        public bool IsActive { get; set; }
        public string IsActiveStr { get; set; }
        public string ImgLocation { get; set; }


















    }
}
