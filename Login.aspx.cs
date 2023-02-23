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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Sign_Up(object sender, EventArgs e)
        {
            Response.Redirect("Sign_Up.aspx");
        }

        protected void loginB_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GIU_Project"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            //takings inputs from the html
            String email = Email.Text;
            String pass = Password.Text;
            SqlCommand login = new SqlCommand("UserLogin", conn);
            login.CommandType = CommandType.StoredProcedure;
            login.Parameters.Add(new SqlParameter("@email ", email));
            login.Parameters.Add(new SqlParameter("@password ", pass));

            SqlParameter user_id = login.Parameters.Add("@user_id", SqlDbType.Int);
            SqlParameter success = login.Parameters.Add("@success", SqlDbType.Int);

            user_id.Direction = ParameterDirection.Output;
            success.Direction = ParameterDirection.Output;

            conn.Open();
            login.ExecuteNonQuery();
            conn.Close();

            if (success.Value.ToString() == "True")
            {
                Session["user"] = user_id;
                //Response.Write(Session["user"]);
                Response.Write("welcome");
                Response.Redirect("ViewProfile.aspx");
            }
            else
                Response.Write("does not exist, please sign up first");

        }
    }
}