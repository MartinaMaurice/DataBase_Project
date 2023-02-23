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
    public partial class CreateMeetings : System.Web.UI.Page
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
            String meetingPoint = mid.Text;
            int Lid = Int16.Parse(lid.Text);
            DateTime dt = Convert.ToDateTime(date.Text);
            DateTime st = Convert.ToDateTime(stime.Text);
            string value = st.ToString("hh:mm:ss tt");
            DateTime et = Convert.ToDateTime(etime.Text);
            string value2 = st.ToString("hh:mm:ss tt");

            SqlCommand CreateM = new SqlCommand("CreateMeeting", conn);
            CreateM.CommandType = CommandType.StoredProcedure;
            CreateM.Parameters.Add(new SqlParameter("@lecturer_id", Lid));
            CreateM.Parameters.Add(new SqlParameter("@meeting_point", meetingPoint));
            CreateM.Parameters.Add(new SqlParameter("@date_time", dt));
            CreateM.Parameters.Add(new SqlParameter("@start_time", value));
            CreateM.Parameters.Add(new SqlParameter("@end_time", value2));


            conn.Open();
            CreateM.ExecuteNonQuery();
            conn.Close();

        }
    }
}