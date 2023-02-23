using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Milestone
{
    public partial class submitMyThesis : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connStr = WebConfigurationManager.ConnectionStrings["GIU_Project"].ToString();
            //create a new connection
            SqlConnection conn = new SqlConnection(connStr);

            int st_id = Int16.Parse(student_id.Text);
            String title = title1.Text;
            String PDF_document = PDF_doc.Text;

            SqlCommand submitMyThesis = new SqlCommand("SubmitMyThesis", conn);
            submitMyThesis.CommandType = CommandType.StoredProcedure;
            submitMyThesis.Parameters.Add(new SqlParameter("@sid", st_id));
            submitMyThesis.Parameters.Add(new SqlParameter("@title", title));
            submitMyThesis.Parameters.Add(new SqlParameter("@PDF_Document", PDF_document));

            conn.Open();
            submitMyThesis.ExecuteNonQuery();
            conn.Close();


        }
    }
}