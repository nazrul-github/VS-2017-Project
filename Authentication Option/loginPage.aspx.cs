using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Configuration;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Authentication_Option
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.CommandText = "SELECT * FROM tblUsers WHERE UserName = @UserName AND Password = @Password;";
            command.Parameters.AddWithValue("@UserName", userNameTextBox.Text);
            string password = EncryptPassword(passwrodTextBox.Text);
            command.Parameters.AddWithValue("@Password", password);
            command.Connection = connection;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                FormsAuthentication.RedirectFromLoginPage(userNameTextBox.Text, rememeberRadioButton.Checked);
            }
            else
            {
                msgLabel.Text = "Password: " + password;
                msgLabel.ForeColor = Color.Red;
            }

        }

        private string EncryptPassword(string passwrod)
        {
            string strmsg = String.Empty;
            byte[] encode = new byte[passwrod.ToString().Length];
            encode = Encoding.UTF8.GetBytes(passwrod);
            strmsg = Convert.ToBase64String(encode);
            return strmsg;
        }
    }
}