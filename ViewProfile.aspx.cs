using Milestone;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Milestone
{
    public partial class ViewProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {



        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewBachelorProject.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddEmployee.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("CompanyGradeThesis.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("CompanyGradeDefense.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("CompanyGradePR.aspx");

        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmployeeGradeDefense.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmployeeGradeThesis.aspx");
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmployeeCreatePR.aspx");

        }
        protected void Button11_Click(object sender, EventArgs e)
        {
            Response.Redirect("MajorPreferences.aspx");
        }

        protected void TextBox1_TextChanged(object sender)
        {

        }

        protected void Button12_Click(object sender, EventArgs e)

        {
            string connStr = WebConfigurationManager.ConnectionStrings["GIU_Project"].ToString();
            SqlConnection conn = new SqlConnection(connStr);

            int uid = Int16.Parse(UserID.Text);
            conn.Open();

                string sqlquery = "SELECT * FROM [dbo].[Users] WHERE user_id = @user_id";
                SqlCommand sulcomm = new SqlCommand(sqlquery, conn);
                sulcomm.Parameters.AddWithValue("@user_id", UserID.Text);

                SqlDataAdapter sda = new SqlDataAdapter(sulcomm);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                // Check if the DataTable contains any rows
                if (dt.Rows.Count > 0)
                {
                    StringBuilder sb = new StringBuilder();
                    sb.Append("<center>");
                    sb.Append("<tr>Users Table</tr>");
                    sb.Append("“<tr/>");
                    sb.Append("<table border=1>");
                    sb.Append("<tr>");
                    foreach (DataColumn dc in dt.Columns)
                    {
                        sb.Append("<th>");
                        sb.Append(dc.ColumnName.ToUpper());
                        sb.Append("</th>");
                    }
                    sb.Append("</tr>");
                    foreach (DataRow dr in dt.Rows)
                    {
                    sb.Append("</tr>");
                    foreach (DataColumn dc in dt.Columns)
                    {

                        sb.Append("“<th>");
                        sb.Append(dr[dc.ColumnName].ToString());
                        sb.Append("</th>");

                    }
                    sb.Append("</tr>");
                }
                sb.Append("</table>");
                sb.Append("</center>");
                Panel1.Controls.Add(new Label { Text = sb.ToString() });
                conn.Close();
            }
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewMyThesis.aspx"); 
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            Response.Redirect("submitMyThesis.aspx");

        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewProgressReport.aspx");
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewMyDefense.aspx");
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateDefense.aspx");
        }

        protected void Button18_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewBachelorProjectGrades.aspx");
        }

        protected void Button19_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewNotBookedMeetings.aspx");
        }

        protected void Button20_Click(object sender, EventArgs e)
        {
            Response.Redirect("BookMeetings.aspx");
        }
        protected void Button22_Click(object sender, EventArgs e)
        {

            Response.Redirect("AddToDoInMeetings.aspx");
        }

        protected void Button21_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewMeetings.aspx");

        }

        protected void Button23_Click(object sender, EventArgs e)
        {
            Response.Redirect("LecturerCreateLocalProject.aspx");

        }

        protected void Button24_Click(object sender, EventArgs e)
        {
            Response.Redirect("SpecifyThesisDeadline.aspx");
        }

        protected void Button25_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateMeetings.aspx");
        }

        protected void Button26_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddToDoInMeetings.aspx");
        }

        protected void Button27_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewMeetingLecturer.aspx");
        }

        protected void Button28_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewEE.aspx");
        }

        protected void Button29_Click(object sender, EventArgs e)
        {
            Response.Redirect("ReccomendEE.aspx");
        }

        protected void Button30_Click(object sender, EventArgs e)
        {
            Response.Redirect("SuperviseIndustrial.aspx");
        }

        protected void Button31_Click(object sender, EventArgs e)
        {
            Response.Redirect("LecGradeThesis.aspx");
        }

        protected void Button32_Click(object sender, EventArgs e)
        {
            Response.Redirect("LecGradedefense.aspx");
        }

        protected void Button33_Click(object sender, EventArgs e)
        {
            Response.Redirect("LecCreatePR.aspx");
        }

        protected void Button34_Click(object sender, EventArgs e)
        {
            Response.Redirect("LecGradePR.aspx");
        }

        protected void Button35_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewUser.aspx");
        }

        protected void Button36_Click(object sender, EventArgs e)
        {
            Response.Redirect("AssignAllStudentsToLocalProject.aspx");
        }

        protected void Button37_Click(object sender, EventArgs e)
        {
            Response.Redirect("AssignTA.aspx");
        }

        protected void Button38_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewRecommendation.aspx");
        }

        protected void Button39_Click(object sender, EventArgs e)
        {
            Response.Redirect("AssignE.aspx");
        }

        protected void Button40_Click(object sender, EventArgs e)
        {
            Response.Redirect("ScheduleDefense.aspx");
        }

        protected void Button41_Click(object sender, EventArgs e)
        {
            Response.Redirect("TACreatePR.aspx");
        }

        protected void Button42_Click(object sender, EventArgs e)
        {
            Response.Redirect("TAAddToDo.aspx");
        }

        protected void Button43_Click(object sender, EventArgs e)
        {
            Response.Redirect("EEGradeThesis.aspx");
        }

        protected void Button44_Click(object sender, EventArgs e)
        {
            Response.Redirect("EEGradedefense.aspx");
        }
    }
}
   