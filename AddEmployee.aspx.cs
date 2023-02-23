using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Milestone
{
    public partial class AddEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GIU_Project"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            //takings inputs from the html
            String email = mail.Text;
            int Cid = Int16.Parse(id.Text);
            string phone = num.Text;
            String fieldd = field.Text;
            String cname = name.Text;

            SqlCommand addE= new SqlCommand("AddEmployee", conn);
            addE.CommandType = CommandType.StoredProcedure;
            addE.Parameters.Add(new SqlParameter("@CompanyID", Cid));
            addE.Parameters.Add(new SqlParameter("@email", email));
            addE.Parameters.Add(new SqlParameter("@name", cname));
            addE.Parameters.Add(new SqlParameter("@phone_number", phone));
            addE.Parameters.Add(new SqlParameter("@field", fieldd));

            SqlParameter staff = addE.Parameters.Add("@StaffID", SqlDbType.Int);
            SqlParameter password = addE.Parameters.Add("@password", SqlDbType.Int);

            staff.Direction = ParameterDirection.Output;
            password.Direction = ParameterDirection.Output;


            conn.Open();
            addE.ExecuteNonQuery();
            conn.Close();

            Response.Write(staff);
            Response.Write(password);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewProfile.aspx");
        }
    }
}