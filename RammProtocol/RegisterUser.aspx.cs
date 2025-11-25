using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAL;

namespace RammProtocol
{
    public partial class RegisterUser : System.Web.UI.Page
    {
        DataModel data = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {

        }

        protected void btn_register_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_name.Text))
            {
                if (!string.IsNullOrEmpty(tb_username.Text))
                {
                    if (!string.IsNullOrEmpty(tb_lastname.Text))
                    {
                        if (!string.IsNullOrEmpty(tb_mail.Text))
                        {
                            if (!string.IsNullOrEmpty(tb_password.Text))
                            {
                                if (!string.IsNullOrEmpty(tb_passwordagain.Text))
                                {
                                    if (tb_passwordagain.Text == tb_password.Text)
                                    {

                                        Users user = new Users();
                                        user.RoleID = 1;
                                        user.Name = tb_name.Text;
                                        user.Username = tb_username.Text;
                                        user.Lastname = tb_lastname.Text;
                                        user.Email = tb_mail.Text;
                                        user.Password = tb_password.Text;
                                        user.DateOfJoin = DateTime.Now;
                                        user.IsBanned = false;
                                        data.UserRegister(user);
                                        lbl_yes.Visible = true;
                                        pnl_yes.Visible = true;
                                        lbl_yes.Text = "You can login now!";
                                    }
                                    else
                                    {
                                        pnl_yes.Visible = true;
                                        lbl_yes.Visible = true;
                                        lbl_yes.Text = "Passwords doesnt match";
                                    }
                                }
                                else
                                {
                                    
                                    pnl_yes.Visible = true;
                                    lbl_yes.Visible = true;
                                    lbl_yes.Text = "Password Again cant be empty.";
                                }
                            }
                            else
                            {
                                pnl_yes.Visible = true;
                                lbl_yes.Visible = true;
                                lbl_yes.Text = "Password cant be empty.";
                            }
                        }
                        else
                        {
                            pnl_yes.Visible = true;
                            lbl_yes.Visible = true;
                            lbl_yes.Text = "Email cant be empty.";
                        }
                    }
                    else
                    {
                        pnl_yes.Visible = true;
                        lbl_yes.Visible = true;
                        lbl_yes.Text = "Lastname cant be empty.";
                    }
                }
                else
                {
                    pnl_yes.Visible = true;
                    lbl_yes.Visible = true;
                    lbl_yes.Text = "Username cant be empty.";
                }
            }
            else
            {
                pnl_yes.Visible = true;
                lbl_yes.Visible = true;
                lbl_yes.Text = "Name cant be empty.";
            }
        }
    }
}