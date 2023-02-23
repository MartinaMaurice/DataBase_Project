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
    public partial class CompanyGradeDefense : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GIU_Project"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            //takings inputs from the html
            int Cid = Int16.Parse(c_id.Text);
            string Sid = s_id.Text;
            String DL = loc.Text;
            String compGrade = Cgrade.Text;

            SqlCommand GradeDefense = new SqlCommand("CompanyGradedefense", conn);
            GradeDefense.CommandType = CommandType.StoredProcedure;
            GradeDefense.Parameters.Add(new SqlParameter("@Company_id", Cid));
            GradeDefense.Parameters.Add(new SqlParameter("@sid", Sid));
            GradeDefense.Parameters.Add(new SqlParameter("@defense_location", DL));
            GradeDefense.Parameters.Add(new SqlParameter("@Company_grade", compGrade));

            conn.Open();
            GradeDefense.ExecuteNonQuery();
            conn.Close();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProfile.aspx");
        }
    }
}