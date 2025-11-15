using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAL
{
    public class Users
    {
        public int UserID { get; set; }
        public int RoleID { get; set; }
        public int ArticleCount { get; set; }   
        public int CommentCount { get; set; }
        public string RoleName { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime DateOfJoin { get; set; }
        public bool IsBanned { get; set; }
        public string IsBannedStr { get; set; }
    }
}
