using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Net.NetworkInformation;

namespace Milestone
{
    public partial class viewMyThesis : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GIU_Project"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GIU_Project"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            int st_id = Int16.Parse(sid.Text);
            String title = title1.Text;

            SqlCommand ViewMyThesis = new SqlCommand("ViewMyThesis", conn);
            ViewMyThesis.CommandType = CommandType.StoredProcedure;
            ViewMyThesis.Parameters.Add(new SqlParameter("@sid", st_id));
            ViewMyThesis.Parameters.Add(new SqlParameter("@title", title));

            conn.Open();
            ViewMyThesis.ExecuteNonQuery();
           
                string sqlquery = "select * from [dbo].[Thesis]";
                SqlCommand sulcomm = new SqlCommand(sqlquery, conn);
                
                SqlDataAdapter sda = new SqlDataAdapter(sulcomm);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                StringBuilder sb = new StringBuilder();
                sb.Append("<center>");
                sb.Append("<tr>Thesis Table</tr>");
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
    }
}