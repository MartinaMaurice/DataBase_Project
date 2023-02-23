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
    public partial class LecCreatePR : System.Web.UI.Page
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
            int Sid = Int16.Parse(sid.Text);
            DateTime Date = Convert.ToDateTime(date.Text);
            string Cont = (content.Text);


            SqlCommand Create = new SqlCommand("LecCreatePR", conn);
            Create.CommandType = CommandType.StoredProcedure;
            Create.Parameters.Add(new SqlParameter("@lecturer_id", Lid));
            Create.Parameters.Add(new SqlParameter("@sid", Sid));
            Create.Parameters.Add(new SqlParameter("@date", Date));
            Create.Parameters.Add(new SqlParameter("@content", Cont));



            conn.Open();
            Create.ExecuteNonQuery();
            conn.Close();
        }
    }
}