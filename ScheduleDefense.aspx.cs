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
    public partial class ScheduleDefense : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GIU_Project"].ToString();
            SqlConnection conn = new SqlConnection(connStr);


            int Sid = Int16.Parse(sid.Text);
            DateTime Date = Convert.ToDateTime(date.Text);
            /* TimeSpan Time = time;*/
            String location = loc.Text;


            SqlCommand ScheduleDefense = new SqlCommand("AssignEE", conn);
            ScheduleDefense.Parameters.Add(new SqlParameter("@sid", Sid));
            ScheduleDefense.Parameters.Add(new SqlParameter("@date", Date));
           /* ScheduleDefense.Parameters.Add(new SqlParameter("@time", Time));*/
            ScheduleDefense.Parameters.Add(new SqlParameter("@location", location));

        }
    }
}