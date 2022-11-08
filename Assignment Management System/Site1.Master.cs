using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment_Management_System
{
    public partial class Site1 : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://localhost:44322/Home.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            String uname = "";
            HttpCookie user = Request.Cookies["user"];
            if (user["login"] != null)
                uname = user["login"].ToString();
            Response.Redirect("https://localhost:44322/Profile.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            String uname = "";
            HttpCookie user = Request.Cookies["user"];
            if (user["login"] != null)
                uname = user["login"].ToString(); 
            Response.Redirect("https://localhost:44322/Upload.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            String uname = "";
            HttpCookie user = Request.Cookies["user"];
            if (user["login"] != null)
                uname = user["login"].ToString();
            Response.Redirect("https://localhost:44322/Delete.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://localhost:44322/Login.aspx");
        }
    }
}