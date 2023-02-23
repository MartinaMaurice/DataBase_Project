using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Security.Cryptography;

namespace Milestone
{
    public partial class ViewBachelorProject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProfile.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GIU_Project"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String Ptype = type.Text;
            int Uid = Int16.Parse(id.Text);
           
            SqlCommand ViewBachelorProjects = new SqlCommand("ViewBachelorProjects", conn);
            ViewBachelorProjects.CommandType = CommandType.StoredProcedure;
            
            ViewBachelorProjects.Parameters.Add(new SqlParameter("@ProjectType", Ptype));
            ViewBachelorProjects.Parameters.Add(new SqlParameter("@User_id", Uid));



            conn.Open();
            ViewBachelorProjects.ExecuteNonQuery();

            if (Ptype == "Academic")
            {
                string sqlquery = "select * from [dbo].[Academic]";
                SqlCommand sulcomm = new SqlCommand(sqlquery, conn);

                SqlDataAdapter sda = new SqlDataAdapter(sulcomm);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                StringBuilder sb = new StringBuilder();
                sb.Append("<center>");
                sb.Append("<tr>Academic Table</tr>");
                sb.Append("“<tr/>");
                sb.Append("<table border=1>");
                sb.Append("<tr>");
                foreach (DataColumn dc in dt.Columns)
                {
                    sb.Append("<th>");
                    sb.Append(dc.ColumnName.ToUpper());
                    sb.Append("</th>");

                }
                sb.Append("</tr>");

                foreach (DataRow dr in dt.Rows)
                {
                    sb.Append("</tr>");
                    foreach (DataColumn dc in dt.Columns)
                    {

                        sb.Append("“<th>");
                        sb.Append(dr[dc.ColumnName].ToString());
                        sb.Append("</th>");

                    }
                    sb.Append("</tr>");
                }
                sb.Append("</table>");
                sb.Append("</center>");
                Panel1.Controls.Add(new Label { Text = sb.ToString() });
                conn.Close();
            }
            else if(Ptype == "Industrial")
            {
                string sqlquery2 = "select * from [dbo].[Industrial]";
                SqlCommand sulcomm2 = new SqlCommand(sqlquery2, conn);

                SqlDataAdapter sda2 = new SqlDataAdapter(sulcomm2);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);
                StringBuilder sb2 = new StringBuilder();
                sb2.Append("<center>");
                sb2.Append("<tr>Industrial Table</tr>");
                sb2.Append("“<tr/>");
                sb2.Append("<table border=1>");
                sb2.Append("<tr>");
                foreach (DataColumn dc2 in dt2.Columns)
                {
                    sb2.Append("<th>");
                    sb2.Append(dc2.ColumnName.ToUpper());
                    sb2.Append("</th>");

                }
                sb2.Append("</tr>");

                foreach (DataRow dr2 in dt2.Rows)
                {
                    sb2.Append("</tr>");
                    foreach (DataColumn dc2 in dt2.Columns)
                    {

                        sb2.Append("“<th>");
                        sb2.Append(dr2[dc2.ColumnName].ToString());
                        sb2.Append("</th>");

                    }
                    sb2.Append("</tr>");
                }
                sb2.Append("</table>");
                sb2.Append("</center>");
                Panel1.Controls.Add(new Label { Text = sb2.ToString() });
                conn.Close();

            }
        }
    }
}