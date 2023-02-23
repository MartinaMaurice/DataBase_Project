using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class AssignE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GIU_Project"].ToString();
            SqlConnection conn = new SqlConnection(connStr);


            int cid = Int16.Parse(Cid.Text);
            int ee = Int16.Parse(EE_id.Text);
            String code =  proj_code.Text;


            SqlCommand AssignE = new SqlCommand("AssignEE", conn);
            AssignE.Parameters.Add(new SqlParameter("@coordinator_id", cid));
            AssignE.Parameters.Add(new SqlParameter("@EE_id", ee));
            AssignE.Parameters.Add(new SqlParameter("@proj_code", code));

        }
    }
}