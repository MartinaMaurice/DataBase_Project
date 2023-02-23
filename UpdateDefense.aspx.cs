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
    public partial class UpdateDefense : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GIU_Project"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int st_id = Int16.Parse(sid.Text);
            String def_content = dcontent.Text;

            SqlCommand UpdateDefense = new SqlCommand("UpdateMyDefense", conn);
            UpdateDefense.CommandType = CommandType.StoredProcedure;
            UpdateDefense.Parameters.Add(new SqlParameter("@sid", st_id));
            UpdateDefense.Parameters.Add(new SqlParameter("@defense_content", def_content));

            conn.Open();
            UpdateDefense.ExecuteNonQuery();
            conn.Close();
        }
    }
}