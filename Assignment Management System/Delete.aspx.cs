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
    public partial class WebForm9 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-DDUI81LN\\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True");

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                Loaddata();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String uname = "";
            HttpCookie user = Request.Cookies["user"];
            if (user["login"] != null)
                uname = user["login"].ToString();
            String name = "";
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                CheckBox chkselect = (CheckBox)GridView1.Rows[i].FindControl("chkselect");
                if (chkselect.Checked == true)
                {
                    // Label1.Text = GridView1.Rows[i].Cells[0].Text;
                    name = GridView1.Rows[i].Cells[1].Text;
                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM " + uname + " WHERE Name='" + name + "'", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            Loaddata();
        }

        void Loaddata()
        {
            String uname = "";
            HttpCookie user = Request.Cookies["user"];
            if (user["login"] != null)
                uname = user["login"].ToString();
            SqlCommand cmd = new SqlCommand("SELECT Name,ContentType FROM "+uname+";", con); 
            SqlDataAdapter d = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            d.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Chkselectall_CheckedChanged(object sender, EventArgs e)
        {
            bool isselct = ((CheckBox)GridView1.HeaderRow.FindControl("chkselectall")).Checked;
            for (int i = 0; i < GridView1.Rows.Count; i++)
            {
                if (isselct == true)
                {
                    ((CheckBox)GridView1.Rows[i].FindControl("chkselect")).Checked = true;
                }
                else if (isselct == false)
                {
                    ((CheckBox)GridView1.Rows[i].FindControl("chkselect")).Checked = false;
                }
            }
        }
    }
}