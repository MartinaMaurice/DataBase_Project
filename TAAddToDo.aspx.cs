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
    public partial class TAAddToDo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GIU_Project"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int meeting_id = int.Parse(Meeting_id.Text);
            String to_do_list = To_do_list.Text;



            SqlCommand TAAddToDo = new SqlCommand("TAAddToDo", conn);

            TAAddToDo.Parameters.Add(new SqlParameter("@meeting_id", meeting_id));
            TAAddToDo.Parameters.Add(new SqlParameter("@to_do_list", to_do_list));
           

        }
    }
}