using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class EEGradedefense : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GIU_Project"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int ee_id = int.Parse(EE_id.Text);
            int sid = int.Parse(Sid.Text);
            String defense_loc = Defense_loc.Text;
            Double ee_grade = double.Parse(EE_grade.Text);



            SqlCommand EEGradedefense = new SqlCommand("EEGradedefense", conn);

            EEGradedefense.Parameters.Add(new SqlParameter("@EE_id", ee_id));
            EEGradedefense.Parameters.Add(new SqlParameter("@sid", sid));
            EEGradedefense.Parameters.Add(new SqlParameter("@defense_location", defense_loc));
            EEGradedefense.Parameters.Add(new SqlParameter("@EE_grade", ee_grade));
        }
    }
}