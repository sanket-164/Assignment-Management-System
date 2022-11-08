using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Assignment_Management_System
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie user = new HttpCookie("user");
            user["login"] = TextBox1.Text;
            user.Expires = DateTime.Now.AddHours(8);
            Response.Cookies.Add(user);
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-DDUI81LN\\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True";
            cn.Open();
            try
            {
                String sqli = "SELECT * FROM Users WHERE uname='" + TextBox1.Text + "';";
                SqlCommand cmd = new SqlCommand(sqli, cn);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    if (ds.Tables[0].Rows[0]["pwd"].ToString().Equals(TextBox2.Text))
                    {
                        Response.Redirect("https://localhost:44322/Home.aspx");
                    }
                    else
                    {
                        Label3.Text = "Invalid Password";
                    }
                }
                else
                {
                    Label3.Text = "Invalid Username";
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://localhost:44322/signup.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://localhost:44322/Forgotpwd.aspx");
        }
    }
}