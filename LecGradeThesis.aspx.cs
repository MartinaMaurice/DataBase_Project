using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Milestone
{
    public partial class LecGradeThesis : System.Web.UI.Page
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
            int Lid = Int16.Parse(lid.Text);
            int Sid = Int16.Parse(sid.Text);
            String thesistitle = tht.Text;
            Double Lg = Double.Parse(lg.Text);


            SqlCommand Grade = new SqlCommand("LecGradeThesis", conn);
            Grade.CommandType = CommandType.StoredProcedure;
            Grade.Parameters.Add(new SqlParameter("@lecturer_id", Lid));
            Grade.Parameters.Add(new SqlParameter("@sid", Sid));
            Grade.Parameters.Add(new SqlParameter("@thesis_title", thesistitle));
            Grade.Parameters.Add(new SqlParameter("@lecturer_grade", Lg));



            conn.Open();
            Grade.ExecuteNonQuery();
            conn.Close();
        }
    }
}