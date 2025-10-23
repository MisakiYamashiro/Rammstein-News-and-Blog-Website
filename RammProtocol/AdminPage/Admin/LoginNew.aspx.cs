using DataAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RammProtocol.AdminPage.SignControls
{
    public partial class LoginNew : System.Web.UI.Page
    {
        DataModel data = new DataModel();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_username.Text.Trim()))
            {

                if (!string.IsNullOrEmpty(tb_password.Text))
                {
                    Users user = data.Login(tb_username.Text, tb_password.Text);
                    if (user != null)
                    {
                        
                        if (tb_username.Text != user.Username || tb_password.Text != user.Password)
                        {
                            pnl_yes.Visible = true;
                            lbl_yes.Visible = true;
                            lbl_yes.Text = "Entered Username or Password is False";
                            lbl_yes.BackColor = System.Drawing.Color.Tomato;
                            pnl_yes.BackColor = System.Drawing.Color.Tomato;
                            pnl_yes.BorderColor = System.Drawing.Color.Tomato;
                        }
                        else
                        {
                            Session["Admin"] = user;
                            Response.Redirect("~/AdminPage/Admin/Default.aspx");
                        }
                    }
                    else
                    {
                        pnl_yes.Visible = true;
                        lbl_yes.Visible = true;
                        lbl_yes.Text = "There is a problem.";
                        lbl_yes.BackColor = System.Drawing.Color.Tomato;
                        pnl_yes.BackColor = System.Drawing.Color.Tomato;
                        pnl_yes.BorderColor = System.Drawing.Color.Tomato;
                    }
                    
                    
                }
                else
                {
                    pnl_yes.Visible = true;
                    lbl_yes.Visible = true;
                    lbl_yes.Text = "Password cant be empty.";
                    lbl_yes.BackColor = System.Drawing.Color.Tomato;
                    pnl_yes.BackColor = System.Drawing.Color.Tomato;
                    pnl_yes.BorderColor = System.Drawing.Color.Tomato;
                }
            }
            else
            {
                pnl_yes.Visible = true;
                lbl_yes.Visible = true;
                lbl_yes.Text = "Username cant be empty.";
                lbl_yes.BackColor = System.Drawing.Color.Tomato;
                pnl_yes.BackColor = System.Drawing.Color.Tomato;
                pnl_yes.BorderColor = System.Drawing.Color.Tomato;
            }
        }
    }
}
