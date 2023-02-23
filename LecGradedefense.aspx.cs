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
    public partial class LecGradedefense : System.Web.UI.Page
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
            String DefenseLoc = dl.Text;
            Double Lg = Double.Parse(lg.Text);


            SqlCommand Grade1 = new SqlCommand("LecGradedefense", conn);
            Grade1.CommandType = CommandType.StoredProcedure;
            Grade1.Parameters.Add(new SqlParameter("@lecturer_id", Lid));
            Grade1.Parameters.Add(new SqlParameter("@sid", Sid));
            Grade1.Parameters.Add(new SqlParameter("@defense_location", dl));
            Grade1.Parameters.Add(new SqlParameter("@lecturer_grade", Lg));



            conn.Open();
            Grade1.ExecuteNonQuery();
            conn.Close();
        }
    }
}