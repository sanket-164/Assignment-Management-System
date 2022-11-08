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
    public partial class WebForm5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String uname = "";
            HttpCookie user = Request.Cookies["user"];
            if (user["login"] != null)
                uname = user["login"].ToString();
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-DDUI81LN\\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True";
            cn.Open();
            try
            {
                String sqli = "SELECT * FROM Users WHERE uname='"+uname+"';";
                SqlCommand cmd = new SqlCommand(sqli, cn);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count == 1)
                {
                    Label10.Text = ds.Tables[0].Rows[0]["fname"].ToString();
                    Label11.Text = ds.Tables[0].Rows[0]["lname"].ToString();
                    Label12.Text = ds.Tables[0].Rows[0]["email"].ToString();
                    Label13.Text = ds.Tables[0].Rows[0]["phone"].ToString();
                    Label14.Text = ds.Tables[0].Rows[0]["uname"].ToString();
                    String bday = ds.Tables[0].Rows[0]["bday"].ToString();
                    Label16.Text = bday.Substring(0,10);
                    Label17.Text = ds.Tables[0].Rows[0]["favfood"].ToString();
                    Label18.Text = ds.Tables[0].Rows[0]["favcolor"].ToString();
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            String uname = "";
            HttpCookie user = Request.Cookies["user"];
            if (user["login"] != null)
                uname = user["login"].ToString();
            Response.Redirect("https://localhost:44322/EditProfile.aspx");
        }
    }
}