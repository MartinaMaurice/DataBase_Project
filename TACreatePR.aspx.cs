using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class TACreatePR : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GIU_Project"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int ta_id= int.Parse(TA_id.Text);
            int sid = Int16.Parse(Sid.Text);
            DateTime date = Convert.ToDateTime(Date.Text);
            String content= Content.Text;
            


            SqlCommand TACreatePR = new SqlCommand("TACreatePR", conn);
            
            TACreatePR.Parameters.Add(new SqlParameter("@TA_id", ta_id));
            TACreatePR.Parameters.Add(new SqlParameter("@sid", sid));
            TACreatePR.Parameters.Add(new SqlParameter("@date", date));
            TACreatePR.Parameters.Add(new SqlParameter("@content", content));

        }
    }
}