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
    public partial class EmployeeGradeDefense : System.Web.UI.Page
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
            int Eid = Int16.Parse(E_id.Text);
            string Sid = s_id.Text;
            String DL = loc.Text;
            String EmpGrade = Egrade.Text;

            SqlCommand EGradeDefense = new SqlCommand("EmployeeGradedefense", conn);
            EGradeDefense.CommandType = CommandType.StoredProcedure;
            EGradeDefense.Parameters.Add(new SqlParameter("@Employee_id", Eid));
            EGradeDefense.Parameters.Add(new SqlParameter("@sid", Sid));
            EGradeDefense.Parameters.Add(new SqlParameter("@defense_location", DL));
            EGradeDefense.Parameters.Add(new SqlParameter("@Employee_grade", EmpGrade));

            conn.Open();
            EGradeDefense.ExecuteNonQuery();
            conn.Close();

        }
    }
}