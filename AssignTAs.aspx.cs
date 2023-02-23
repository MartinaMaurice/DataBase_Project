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
    public partial class AssignTAs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GIU_Project"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            String code = proj_code.Text;
            int id = Int16.Parse(TA_id.Text);
            int Cid = Int16.Parse(coordinator_id.Text);

            SqlCommand AssignTAs = new SqlCommand("AssignTAs", conn);
            AssignTAs.Parameters.Add(new SqlParameter("@coordinator_id", Cid));
            AssignTAs.Parameters.Add(new SqlParameter("@TA_id", id));
            AssignTAs.Parameters.Add(new SqlParameter("@proj_code", code));


        }
    }
}