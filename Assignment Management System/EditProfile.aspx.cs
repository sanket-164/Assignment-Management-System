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
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            String uname = "";
            HttpCookie user = Request.Cookies["user"];
            if (user["login"] != null)
                uname = user["login"].ToString();
            String sqli = "";
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-DDUI81LN\\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True";
            cn.Open();
            try
            {
                if (TextBox1.Text != "")
                {
                    sqli = "UPDATE Users SET fname='" + TextBox1.Text + "' WHERE uname='"+uname+"';";
                    SqlCommand tcmd = new SqlCommand(sqli, cn);
                    tcmd.ExecuteNonQuery();
                    tcmd.Dispose();
                }
                if (TextBox2.Text != "")
                {
                    Response.Write("Ok");
                    sqli = "UPDATE Users SET lname='" + TextBox2.Text + "' WHERE uname='" + uname + "';";
                    SqlCommand tcmd = new SqlCommand(sqli, cn);
                    tcmd.ExecuteNonQuery();
                    tcmd.Dispose();
                }
                if (TextBox3.Text != "")
                {
                    sqli = "UPDATE Users SET email='" + TextBox3.Text + "' WHERE uname='" + uname + "';";
                    SqlCommand tcmd = new SqlCommand(sqli, cn);
                    tcmd.ExecuteNonQuery();
                    tcmd.Dispose();
                }
                if (TextBox4.Text != "")
                {
                    sqli = "UPDATE Users SET phone='" + TextBox4.Text + "' WHERE uname='" + uname + "';";
                    SqlCommand tcmd = new SqlCommand(sqli, cn);
                    tcmd.ExecuteNonQuery();
                    tcmd.Dispose();
                }
                if (TextBox6.Text != "")
                {
                    sqli = "UPDATE Users SET bday='" + TextBox6.Text + "' WHERE uname='" + uname + "';";
                    SqlCommand tcmd = new SqlCommand(sqli, cn);
                    tcmd.ExecuteNonQuery();
                    tcmd.Dispose();
                }
                if (TextBox7.Text != "")
                {
                    sqli = "UPDATE Users SET favfood='" + TextBox7.Text + "' WHERE uname='" + uname + "';";
                    SqlCommand tcmd = new SqlCommand(sqli, cn);
                    tcmd.ExecuteNonQuery();
                    tcmd.Dispose();
                }
                if (TextBox8.Text != "")
                {
                    sqli = "UPDATE Users SET favcolor='" + TextBox8.Text + "' WHERE uname='" + uname + "';";
                    SqlCommand tcmd = new SqlCommand(sqli, cn);
                    tcmd.ExecuteNonQuery();
                    tcmd.Dispose();
                }
                cn.Close();
                Response.Redirect("~/Profile.aspx");
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            String uname = "";
            HttpCookie user = Request.Cookies["user"];
            if (user["login"] != null)
                uname = user["login"].ToString();
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-DDUI81LN\\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True";
            cn.Open();
            String sqli = "SELECT * FROM Users WHERE uname='" + uname + "';";
            SqlCommand cmd = new SqlCommand(sqli, cn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count == 1)
            {
                TextBox1.Text = ds.Tables[0].Rows[0]["fname"].ToString();
                TextBox2.Text = ds.Tables[0].Rows[0]["lname"].ToString();
                TextBox3.Text = ds.Tables[0].Rows[0]["email"].ToString();
                TextBox4.Text = ds.Tables[0].Rows[0]["phone"].ToString();
                TextBox6.Text = ds.Tables[0].Rows[0]["bday"].ToString();
                TextBox7.Text = ds.Tables[0].Rows[0]["favfood"].ToString();
                TextBox8.Text = ds.Tables[0].Rows[0]["favcolor"].ToString();
                cmd.Dispose();
            }
            cn.Close();
        }
    }
}