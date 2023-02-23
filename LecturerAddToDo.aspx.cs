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
    public partial class LecturerAddToDo : System.Web.UI.Page
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
            String todolist = todo.Text;
            int Mid = Int16.Parse(mid.Text);

            SqlCommand AddtoDo = new SqlCommand("AddEmployee", conn);
            AddtoDo.CommandType = CommandType.StoredProcedure;
            AddtoDo.Parameters.Add(new SqlParameter("@meeting_id", Mid));
            AddtoDo.Parameters.Add(new SqlParameter("@to_do_list", todolist));


            conn.Open();
            AddtoDo.ExecuteNonQuery();
            conn.Close();
        }
    }
}