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
    public partial class EEGradeThesis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GIU_Project"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int ee_id = int.Parse(EE_id.Text);
            int sid = int.Parse(Sid.Text);
            String thesis_title = Thesis_title.Text;
            Double ee_grade= double.Parse(EE_grade.Text);



            SqlCommand EEGradeThesis = new SqlCommand("EEGradeThesis", conn);

            EEGradeThesis.Parameters.Add(new SqlParameter("@EE_id", ee_id));
            EEGradeThesis.Parameters.Add(new SqlParameter("@sid", sid));
            EEGradeThesis.Parameters.Add(new SqlParameter("@thesis_title", thesis_title));
            EEGradeThesis.Parameters.Add(new SqlParameter("@EE_grade", ee_grade));

        }
    }
}