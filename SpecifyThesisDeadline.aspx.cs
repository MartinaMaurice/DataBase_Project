using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Milestone
{
    public partial class SpecifyThesisDeadline : System.Web.UI.Page
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
            string DeadL = Deadline.Text;

            SqlCommand STD = new SqlCommand("SpecifyThesisDeadline", conn);
            STD.CommandType = CommandType.StoredProcedure;
            STD.Parameters.Add(new SqlParameter("@deadline", DeadL));
            try{
                conn.Open();
                STD.ExecuteNonQuery();
                conn.Close();
            }catch (Exception ex)
            {
                Response.Redirect("ViewProfile.aspx");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProfile.aspx");
        }
    }
}