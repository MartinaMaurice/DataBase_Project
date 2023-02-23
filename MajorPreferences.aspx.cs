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
    public partial class MajorPreferences : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GIU_Project"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            int st_id = Int16.Parse(sid.Text);
            String Pro_code = bcode.Text;
            int pref_number = Int16.Parse(pnumber.Text);

            SqlCommand makePref = new SqlCommand("MakePreferencesLocalProject", conn);
            makePref.CommandType = CommandType.StoredProcedure;
            makePref.Parameters.Add(new SqlParameter("@sid", st_id));
            makePref.Parameters.Add(new SqlParameter("@bachelor_code", Pro_code));
            makePref.Parameters.Add(new SqlParameter("@preference_number", pref_number));

            conn.Open();
            makePref.ExecuteNonQuery();
            conn.Close();




        }
    }
}