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
    public partial class Sign_Up : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SignUp(object sender, EventArgs e)
        {
            //take connection string from configurations
            string connStr = WebConfigurationManager.ConnectionStrings["GIU_Project"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);
            //takings inputs from the html
            String fname = First_Name.Text;
            String lname = Last_Name.Text;
            String type = UserType.Text;
            String username = Username.Text;
            String email = Email.Text;
            DateTime bd = Convert.ToDateTime(Birthdate.Text);
            Double gpa = Double.Parse(GPA.Text);
            int sem = Int16.Parse(Semester.Text);
            String addr = Address.Text;
            String fc = Faculty_Code.Text;
            String mc = Major_Code.Text;
            String cn = Company_Name.Text;
            String rn = Representative_Name.Text;
            String re = Representative_Email.Text;
            String phone = Phone_Number.Text;
            String country = Country_Of_Residence.Text;

            //intiate the procedure and give it the inputs
            SqlCommand signUp = new SqlCommand("UserRegister", conn);
            signUp.CommandType = CommandType.StoredProcedure;
            signUp.Parameters.Add(new SqlParameter("@usertype ", type));
            signUp.Parameters.Add(new SqlParameter("@first_name", fname));
            signUp.Parameters.Add(new SqlParameter("@last_name", lname));
            signUp.Parameters.Add(new SqlParameter("@birth_date", bd));
            signUp.Parameters.Add(new SqlParameter("@GPA", gpa));
            signUp.Parameters.Add(new SqlParameter("@userName", username));
            signUp.Parameters.Add(new SqlParameter("@email", email));
            signUp.Parameters.Add(new SqlParameter("@semester", sem));
            signUp.Parameters.Add(new SqlParameter("@address", addr));
            signUp.Parameters.Add(new SqlParameter("@faculty_code", fc));
            signUp.Parameters.Add(new SqlParameter("@major_code", mc));
            signUp.Parameters.Add(new SqlParameter("@company_name", cn));
            signUp.Parameters.Add(new SqlParameter("@representative_name", rn));
            signUp.Parameters.Add(new SqlParameter("@representative_email", re));
            signUp.Parameters.Add(new SqlParameter("@phone_number", phone));
            signUp.Parameters.Add(new SqlParameter("@country_of_residence", country));



            //getting the output of the procedure
            SqlParameter user_id = signUp.Parameters.Add("@user_id", SqlDbType.Int);
            SqlParameter password = signUp.Parameters.Add("@password", SqlDbType.Int);

            user_id.Direction = ParameterDirection.Output;
            password.Direction = ParameterDirection.Output;

            conn.Open();
            signUp.ExecuteNonQuery();
            conn.Close();

            if (type.ToString() == "Student")
            {
                Session["user"] = user_id;
                Response.Write("You are a student");
                Response.Write(user_id.Value);
                Response.Write(password.Value);
            }
            else if (type.ToString() == "Lecturer")
            {
                Session["user"] = user_id;
                Response.Write("You are a Lecturer");
                Response.Write(user_id.Value);
                Response.Write(password.Value);
            }
            else if (type.ToString() == "Company")
            {
                Session["user"] = user_id;
                Response.Write("You are a Company");
                Response.Write(user_id.Value);
                Response.Write(password.Value);
            }
            else if (type.ToString() == "Teaching_Assistant")
            {
                Session["user"] = user_id;
                Response.Write("You are a Teaching_Assistant");
                Response.Write(user_id.Value);
                Response.Write(password.Value);
            }
            else if (type.ToString() == "Coordinator")
            {
                Session["user"] = user_id;
                Response.Write("You are a Coordinator");
                Response.Write(user_id.Value);
                Response.Write(password.Value);
            }
            else if (type.ToString() == "External_Examiner")
            {
                Session["user"] = user_id;
                Response.Write("You are a External_Examiner");
                Response.Write(user_id.Value) ;
                Response.Write(password.Value);
            }
            else
            {
                Session["user"] = user_id;
                Response.Write(user_id.Value);
                Response.Write(password.Value);
                Response.Redirect("ViewProfile.aspx");
            }
            Response.Write(Session["user"]);
        }
    }
}