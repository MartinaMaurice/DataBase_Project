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
    public partial class CompanyGradePR : System.Web.UI.Page
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
            int Cid = Int16.Parse(c_id.Text);
            string Sid = s_id.Text;
            DateTime prdate = Convert.ToDateTime( date.Text);
            String compGrade = Cgrade.Text;

            SqlCommand GradePR = new SqlCommand("CompanyGradePR", conn);
            GradePR.CommandType = CommandType.StoredProcedure;
            GradePR.Parameters.Add(new SqlParameter("@Company_id", Cid));
            GradePR.Parameters.Add(new SqlParameter("@sid", Sid));
            GradePR.Parameters.Add(new SqlParameter("@date", prdate));
            GradePR.Parameters.Add(new SqlParameter("@Company_grade", compGrade));

            conn.Open();
            GradePR.ExecuteNonQuery();
            conn.Close();

        }
    }
}