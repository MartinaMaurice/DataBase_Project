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
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Net.NetworkInformation;

namespace WebApplication
{
    public partial class ViewRecommendation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GIU_Project"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

           
            int id = Int16.Parse(lecturer_id.Text);
            SqlCommand ViewRecommendation = new SqlCommand("ViewRecommendation", conn);
            ViewRecommendation.Parameters.Add(new SqlParameter("@lecture_id", id));

              SqlParameter Lecturer_id = ViewRecommendation.Parameters.Add("@lecture_id", SqlDbType.Int);

            Lecturer_id.Direction = ParameterDirection.Output;
       
            conn.Open();
            ViewRecommendation.ExecuteNonQuery();
        
            string sqlquery = "select * from [dbo].[LecturerRecommendEE]";
            SqlCommand sulcomm = new SqlCommand(sqlquery, conn);

            SqlDataAdapter sda = new SqlDataAdapter(sulcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            StringBuilder sb = new StringBuilder();
            sb.Append("<center>");
            sb.Append("<tr>LecturerRecommendEE Table</tr>");
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

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
    
}