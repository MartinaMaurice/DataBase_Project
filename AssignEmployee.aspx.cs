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
    public partial class AssignEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProfile.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GIU_Project"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            //takings inputs from the html
            String Bachcode = Bcode.Text;
            int Cid = Int16.Parse(CID.Text);

            SqlCommand AssignE = new SqlCommand("AssignEmployee", conn);
            AssignE.CommandType = CommandType.StoredProcedure;
            AssignE.Parameters.Add(new SqlParameter("@Company_id", Cid));
            AssignE.Parameters.Add(new SqlParameter("@bachelor_code", Bachcode));

            SqlParameter staff = AssignE.Parameters.Add("@staff_id", SqlDbType.Int);

            staff.Direction = ParameterDirection.Output;


            conn.Open();
            AssignE.ExecuteNonQuery();
            conn.Close();

            Response.Write(staff);
        }
    }
}