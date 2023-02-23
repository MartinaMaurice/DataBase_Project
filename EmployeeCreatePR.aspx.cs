using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Milestone
{
    public partial class EmployeeCreatePR : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProfile.aspx");

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GIU_Project"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            //takings inputs from the html
            int Empid = Int16.Parse(E_id.Text);
            string Sid = s_id.Text;
            DateTime Edate = Convert.ToDateTime(date.Text);
            String content = EContent.Text;

            SqlCommand ECreatePR = new SqlCommand("EmployeeCreatePR", conn);
            ECreatePR.CommandType = CommandType.StoredProcedure;
            ECreatePR.Parameters.Add(new SqlParameter("@Employee_id",Empid));
            ECreatePR.Parameters.Add(new SqlParameter("@sid", Sid));
            ECreatePR.Parameters.Add(new SqlParameter("@date", Edate));
            ECreatePR.Parameters.Add(new SqlParameter("@content", content));

            conn.Open();
            ECreatePR.ExecuteNonQuery();
            conn.Close();
        }
    }
}