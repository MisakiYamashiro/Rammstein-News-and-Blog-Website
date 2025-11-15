using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAL
{
    public class VOAbyUser
    {
        public int ArticleID { get; set; }
        public int UserID { get; set; }
        public bool Upvote { get; set; }
        public bool Downvote { get; set; }
    }
}
