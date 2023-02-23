using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Milestone
{
    public partial class ReccomendEE : System.Web.UI.Page
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
            int Lid = Int16.Parse(lid.Text);
            String ProjC = pjc.Text;
            int EEid = Int16.Parse(eeid.Text);



            SqlCommand ReccE = new SqlCommand("ReccomendEE", conn);
            ReccE.CommandType = CommandType.StoredProcedure;
            ReccE.Parameters.Add(new SqlParameter("@lecturer_id", lid));
            ReccE.Parameters.Add(new SqlParameter("@Proj_code", ProjC));
            ReccE.Parameters.Add(new SqlParameter("@EE_id", EEid));


            conn.Open();
            ReccE.ExecuteNonQuery();
            conn.Close();
        }
    }
}