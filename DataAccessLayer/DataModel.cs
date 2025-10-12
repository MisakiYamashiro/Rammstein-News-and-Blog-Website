using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DataModel
    {
        SqlConnection con;
        SqlCommand cmd;
        public DataModel()
        {
            con = new SqlConnection(ConnectionStrings.LocalString);
            cmd = con.CreateCommand();
        }

        public Users Login(string username, string password)
        {
            try
            {
                cmd.CommandText = "select COUNT(*) from Users where Username=@username and Password=@password and RoleID=@rid";
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                int rid = 2;
                cmd.Parameters.AddWithValue("@rid", rid);
                con.Open();
                int sayi = Convert.ToInt32(cmd.ExecuteScalar());
                if (sayi != 0)
                {
                    cmd.CommandText = "select U.UserID, R.RoleID, U.Name, U.Username, U.Lastname, U.Email, U.Password, U.DateOfJoin from Users as U join Roles as R on U.RoleID = R.RoleID where Username=@username and Password=@password";
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    SqlDataReader reader = cmd.ExecuteReader();
                    Users users = new Users();
                    while (reader.Read())
                    {
                        users.UserID = reader.GetInt32(0);
                        users.RoleID = reader.GetInt32(1);
                        users.Name = reader.GetString(2);
                        users.Username = reader.GetString(3);
                        users.Lastname = reader.GetString(4);
                        users.Email = reader.GetString(5);
                        users.Password = reader.GetString(6);
                        users.DateOfJoin = reader.GetDateTime(7);
                    }
                    reader.Close();
                    return users;
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
    }
    
}
