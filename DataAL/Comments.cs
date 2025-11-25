using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAL
{
    public class Comments
    {
        public int CommentID { get; set; }
        public int UserID { get; set; }
        public string UserStr { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public int Upvote { get; set; }
        public int Downvote { get; set; }
        public bool IsActive { get; set; }
    }
}
