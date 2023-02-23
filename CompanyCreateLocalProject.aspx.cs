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
    public partial class CompanyCreateLocalProject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GIU_Project"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            //takings inputs from the html
            int Cid = Int16.Parse(id.Text);
            string pcode = Code.Text;
            String titlee = title.Text;
            String des = desc.Text;
            String majorcode = Mcode.Text;


            SqlCommand CCLP = new SqlCommand("CompanyCreateLocalProject", conn);
            CCLP.CommandType = CommandType.StoredProcedure;
            CCLP.Parameters.Add(new SqlParameter("@company_id", Cid));
            CCLP.Parameters.Add(new SqlParameter("@proj_code", pcode));
            CCLP.Parameters.Add(new SqlParameter("@title", titlee));
            CCLP.Parameters.Add(new SqlParameter("@description", des));
            CCLP.Parameters.Add(new SqlParameter("@major_code", majorcode));

            try
            {
                conn.Open();
                CCLP.ExecuteNonQuery();
                conn.Close();
            }catch(Exception ex) {
                Response.Redirect("ViewProfile.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProfile.aspx");
        }
    }
}
/*

*/