using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Milestone
{
    public partial class CompanyGradeThesis : System.Web.UI.Page
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
            String Ttitle = title.Text;
            String compGrade = Cgrade.Text;

            SqlCommand GradeThesis = new SqlCommand("CompanyGradeThesis", conn);
            GradeThesis.CommandType = CommandType.StoredProcedure;
            GradeThesis.Parameters.Add(new SqlParameter("@Company_id", Cid));
            GradeThesis.Parameters.Add(new SqlParameter("@sid", Sid));
            GradeThesis.Parameters.Add(new SqlParameter("@thesis_title", Ttitle));
            GradeThesis.Parameters.Add(new SqlParameter("@Company_grade", compGrade));

            conn.Open();
            GradeThesis.ExecuteNonQuery();
            conn.Close();

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProfile.aspx");
        }
    }
}