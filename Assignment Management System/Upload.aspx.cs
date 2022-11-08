using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace Assignment_Management_System
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String uname = "";
            HttpCookie user = Request.Cookies["user"];
            if (user["login"] != null)
                uname = user["login"].ToString();
            string constr = "Data Source=LAPTOP-DDUI81LN\\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.CommandText = "select Id, Name from " + uname + ";";
                        cmd.Connection = con;
                        con.Open();
                        GridView1.DataSource = cmd.ExecuteReader();
                        GridView1.DataBind();
                        con.Close();
                    }
                }
        }

        protected void Upload(object sender, EventArgs e)
        {
            if (FileUpload1.PostedFile.FileName != "")
            {
                String uname = "";
                HttpCookie user = Request.Cookies["user"];
                if (user["login"] != null)
                    uname = user["login"].ToString();
                try
                {
                    string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
                    string contentType = FileUpload1.PostedFile.ContentType;
                    using (Stream fs = FileUpload1.PostedFile.InputStream)
                    {
                        using (BinaryReader br = new BinaryReader(fs))
                        {
                            byte[] bytes = br.ReadBytes((Int32)fs.Length);
                            string constr = "Data Source=LAPTOP-DDUI81LN\\SQLEXPRESS;Initial Catalog=AMS;Integrated Security=True";
                            using (SqlConnection con = new SqlConnection(constr))
                            {
                                string query = "insert into " + uname + " values (@Name, @ContentType, @Data)";
                                using (SqlCommand cmd = new SqlCommand(query))
                                {
                                    cmd.Connection = con;
                                    cmd.Parameters.AddWithValue("@Name", filename);
                                    cmd.Parameters.AddWithValue("@ContentType", contentType);
                                    cmd.Parameters.AddWithValue("@Data", bytes);
                                    con.Open();
                                    cmd.ExecuteNonQuery();
                                    con.Close();
                                }
                            }
                        }
                    }
                    Response.Redirect(Request.Url.AbsoluteUri);
                }
                catch (Exception ex)
                {
                    Response.Write(ex);
                }
            }
        }
    }
}