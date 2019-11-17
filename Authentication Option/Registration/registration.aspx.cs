using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Configuration;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Authentication_Option.Registration
{
    public partial class registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registerButton_Click(object sender, EventArgs e)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spRegisterUser",connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", userNameTextBox.Text);
                cmd.Parameters.AddWithValue("@Password", passwordTextBox.Text);
                cmd.Parameters.AddWithValue("@Email", emailTextBox.Text);
                connection.Open();
                int existUser = (int) cmd.ExecuteScalar();
                if (existUser == 1)
                {
                   Response.Redirect("~/loginPage.aspx");
                }else if(existUser == -1)

                {
                    msgLabel.Text = "User name already exist";
                }
            }
        }
    }
}