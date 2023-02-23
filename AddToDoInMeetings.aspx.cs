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
    public partial class AddToDoInMeetings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GIU_Project"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int meet_id = Int16.Parse(m_id.Text);
            String to_do_list = to_do.Text;

            SqlCommand AddToDoInMeetings = new SqlCommand("LecturerAddToDo", conn);
            AddToDoInMeetings.CommandType = CommandType.StoredProcedure;
            AddToDoInMeetings.Parameters.Add(new SqlParameter("@meeting_id", meet_id));
            AddToDoInMeetings.Parameters.Add(new SqlParameter("@to_do_list", to_do_list));
            try
            {
                conn.Open();
                AddToDoInMeetings.ExecuteNonQuery();
                conn.Close();
            }catch(Exception ex) {
                Response.Write("added successfully!");
            }
        }
    }
}