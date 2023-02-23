using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Net.NetworkInformation;

namespace WebApplication
{
    public partial class login_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

     

        protected void Login(object sender, EventArgs e)
        {
        string connStr= WebConfigurationManager.ConnectionStrings["GIU_Project"].ToString();
            SqlConnection conn= new SqlConnection(connStr);

            String type = User_type.Text;
            int id = Int16.Parse(User_id.Text);
            SqlCommand ViewUser = new SqlCommand("ViewUsers", conn);
            ViewUser.Parameters.Add(new SqlParameter("@User_type", type));
            ViewUser.Parameters.Add(new SqlParameter("@User_id", id));

            SqlParameter user_type = ViewUser.Parameters.Add("@User_type", SqlDbType.VarChar);
            SqlParameter user_id = ViewUser.Parameters.Add("@User_id", SqlDbType.Int);

            user_id.Direction = ParameterDirection.Output;
            user_type.Direction = ParameterDirection.Output;
            conn.Open();
            ViewUser.ExecuteNonQuery();
            string sqlquery = "select * from [dbo].[Users]";
            SqlCommand sulcomm = new SqlCommand(sqlquery, conn);

            SqlDataAdapter sda = new SqlDataAdapter(sulcomm);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            StringBuilder sb = new StringBuilder();
            sb.Append("<center>");
            sb.Append("<tr>Users Table</tr>");
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
