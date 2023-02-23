using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Milestone
{
    public partial class BookMeetings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GIU_Project"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int st_id = Int16.Parse(sid.Text);
            int meet_id = Int16.Parse(m_id.Text);

            SqlCommand BookMeetings = new SqlCommand("BookMeeting", conn);
            BookMeetings.CommandType = CommandType.StoredProcedure;
            BookMeetings.Parameters.Add(new SqlParameter("@sid", st_id));
            BookMeetings.Parameters.Add(new SqlParameter("@meeting_id", meet_id));

            conn.Open();
            BookMeetings.ExecuteNonQuery();
            conn.Close();
        }
    }
}