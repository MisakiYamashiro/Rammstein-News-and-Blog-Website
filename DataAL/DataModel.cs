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


    }
}
