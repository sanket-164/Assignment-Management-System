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
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Panel2.Visible = false;
            }
            else
            {
                Panel1.Visible = true;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
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
                    if (ds.Tables[0].Rows[0]["favfood"].ToString().Equals(TextBox2.Text))
                    {
                        if (ds.Tables[0].Rows[0]["favcolor"].ToString().Equals(TextBox3.Text))
                        {
                            Panel1.Visible = false;
                            Panel2.Visible = true;
                        }
                        else
                        {
                            Label4.Text = "Color is Wrong";
                        }
                    }
                    else
                    {
                        Label4.Text = "Food is Wrong";
                    }
                }
                else
                {
                    Label4.Text = "Invalid Username";
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                Label1.Text = "Exception occured " + ex;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if(CompareValidator1.IsValid == true)
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = "Data Source=LAPTOP-DDUI81LN\\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True";
                cn.Open();
                Panel1.Visible = false;
                try
                {
                    if(TextBox5.Text != "")
                    {
                        String sqli = "UPDATE Users SET pwd='" + TextBox5.Text + "' WHERE uname='" + TextBox1.Text + "';";
                        SqlCommand cmd = new SqlCommand(sqli, cn);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        Label7.Text = "Password has been changed go back to Login page";
                    }
                    else
                    {
                        Label7.Text = "Enter Password";
                    }
                }
                catch (Exception ex)
                {
                    Response.Write(ex);
                }
            }
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://localhost:44322/Login.aspx");
        }
    }
}