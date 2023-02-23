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

namespace Milestone
{
    public partial class viewProgressReport : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GIU_Project"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int st_id = Int16.Parse(sid.Text);
            DateTime date = Convert.ToDateTime(date1.Text);


            SqlCommand viewProgressReport = new SqlCommand("ViewMyProgressReports", conn);
            viewProgressReport.CommandType = CommandType.StoredProcedure;
            viewProgressReport.Parameters.Add(new SqlParameter("@sid", st_id));
            viewProgressReport.Parameters.Add(new SqlParameter("@date", date));


            conn.Open();
            viewProgressReport.ExecuteNonQuery();
            

            string sqlquery = "select * from [dbo].[ProgressReport]";
            SqlCommand sulcomm = new SqlCommand(sqlquery, conn);

            SqlDataAdapter sda = new SqlDataAdapter(sulcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            StringBuilder sb = new StringBuilder();
            sb.Append("<center>");
            sb.Append("<tr>Progress Report Table</tr>");
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
    