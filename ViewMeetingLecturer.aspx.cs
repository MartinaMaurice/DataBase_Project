using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Milestone
{
    public partial class ViewMeeting : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GIU_Project"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int Mid = Int16.Parse(mid.Text);
            int Lid = Int16.Parse(lid.Text);

            SqlCommand ViewMeetings = new SqlCommand("ViewMeetingLecturer", conn);
            ViewMeetings.CommandType = CommandType.StoredProcedure;
            ViewMeetings.Parameters.Add(new SqlParameter("@lecturer_id", Lid));
            ViewMeetings.Parameters.Add(new SqlParameter("@meeting_id", Mid));

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

        }
    }
}