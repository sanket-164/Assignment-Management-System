using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Assignment_Management_System
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                HyperLink1.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=LAPTOP-DDUI81LN\\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True";
            String sqli = "INSERT INTO Users VALUES('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "');";
            cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand(sqli, cn);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                cn.Close();

                String user = TextBox6.Text;
                String sqli2 = "CREATE TABLE [dbo].[" + user + "]([id][int] IDENTITY(1, 1) NOT NULL,[Name] [varchar](50) NOT NULL,[ContentType] [nvarchar](200) NOT NULL,[Data] [varbinary](max)NOT NULL) ON[PRIMARY] TEXTIMAGE_ON[PRIMARY] ";
                cn.Open();
                try
                {
                    SqlCommand cmd2 = new SqlCommand(sqli2, cn);
                    cmd2.ExecuteNonQuery();
                    cmd2.Dispose();
                    cn.Close();
                    Button1.Visible = false;
                    Label1.Text = "You are Successfully Signed Up";
                    HyperLink1.Visible = true;
                }
                catch (Exception ex)
                {
                    Response.Write(ex);
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex);
            }
        }
    }
}