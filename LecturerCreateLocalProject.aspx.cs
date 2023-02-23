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
    public partial class LecturerCreateLocalProject : System.Web.UI.Page
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
            int L_id = Int16.Parse(LID.Text);
            string PCode = PC.Text;
            String title = tt.Text;
            String Des = Desc.Text;
            String Major_Code = MCode.Text;


            SqlCommand LCLP = new SqlCommand("LecturerCreateLocalProject", conn);
            LCLP.CommandType = CommandType.StoredProcedure;
            LCLP.Parameters.Add(new SqlParameter("@lecturer_id", L_id));
            LCLP.Parameters.Add(new SqlParameter("@proj_code", PCode));
            LCLP.Parameters.Add(new SqlParameter("@title", title));
            LCLP.Parameters.Add(new SqlParameter("@description", Des));
            LCLP.Parameters.Add(new SqlParameter("@major_code", Major_Code));


            conn.Open();
            LCLP.ExecuteNonQuery();
            conn.Close();


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProfile.aspx");
        }
    }
}