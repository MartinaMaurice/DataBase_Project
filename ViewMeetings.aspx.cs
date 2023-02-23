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
    public partial class ViewMeetings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GIU_Project"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int meet_id = Int16.Parse(m_id.Text);
            int st_id = Int16.Parse(sid.Text);

            SqlCommand ViewMeetings = new SqlCommand("ViewMeeting", conn);
            ViewMeetings.CommandType = CommandType.StoredProcedure;
            ViewMeetings.Parameters.Add(new SqlParameter("@sid", st_id));
            ViewMeetings.Parameters.Add(new SqlParameter("@meeting_id", meet_id));

            conn.Open();
            ViewMeetings.ExecuteNonQuery();

            string sqlquery = "select * from [dbo].[Meeting]";
            SqlCommand sulcomm = new SqlCommand(sqlquery, conn);

            SqlDataAdapter sda = new SqlDataAdapter(sulcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            StringBuilder sb = new StringBuilder();
            sb.Append("<center>");
            sb.Append("<tr>Meeting Table</tr>");
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

        

            string sqlquery2 = "select * from [dbo].[MeetingToDoList]";
            SqlCommand sulcomm2 = new SqlCommand(sqlquery2, conn);

            SqlDataAdapter sda2 = new SqlDataAdapter(sulcomm2);
            DataTable dt2 = new DataTable();
            sda2.Fill(dt2);
            StringBuilder sb2 = new StringBuilder();
            sb2.Append("<center>");
            sb2.Append("<tr>Meeting To Do List Table</tr>");
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
            Panel2.Controls.Add(new Label { Text = sb2.ToString() });
            conn.Close();

        }
    }
}
   
