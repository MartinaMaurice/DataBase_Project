using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Milestone
{
    public partial class ViewBachelorProjectGrades : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GIU_Project"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int st_id = Int16.Parse(sid.Text);

            SqlCommand ViewBachelorProjectGrades = new SqlCommand("ViewMyBachelorProjectGrade", conn);
            ViewBachelorProjectGrades.CommandType = CommandType.StoredProcedure;
            ViewBachelorProjectGrades.Parameters.Add(new SqlParameter("@sid", st_id));

            SqlParameter bachelor_grade = ViewBachelorProjectGrades.Parameters.Add("@BachelorGrade", SqlDbType.DateTime);
            bachelor_grade.Direction = ParameterDirection.Output;


            conn.Open();
            ViewBachelorProjectGrades.ExecuteNonQuery();
            conn.Close();

            Response.Write(bachelor_grade);
        }
    }
}