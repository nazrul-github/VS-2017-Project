using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using ValidationGroups.Models;

namespace ValidationGroups
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void userNameTextBoxValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value == "")
            {
                args.IsValid = false;
            }
            else
            {
                if (args.Value.Length > 3)
                {
                    args.IsValid = true;
                }
                else
                {
                    args.IsValid = false;
                }
            }
        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "spLoginUser";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = connection;
                    cmd.Parameters.AddWithValue("@UserName", userNameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Password", passwordTextBox.Text);
                    connection.Open();
                   SqlDataReader reader =  cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        msgLabel.Text = "Logged In successfully";
                        msgLabel.ForeColor = Color.Green;
                    }
                    else
                    {
                        msgLabel.Text = "Couldn't logged in, please check username and password";
                        msgLabel.ForeColor = Color.Red;
                    }
                };
            }
            else
            {
                msgLabel.Text = "Couldn't logged in, please check username and password";
                msgLabel.ForeColor = Color.Red;
                ;
            }
        }

        protected void ageTextBoxCustomValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value == "")
            {
                args.IsValid = false;
            }
            else
            {
                int number = 0;
                bool isNumber = int.TryParse(args.Value, out number);
                if (isNumber && number > 18)
                {
                    args.IsValid = true;

                }
                else
                {
                    args.IsValid = false;
                }
            }
        }

        protected void registerButton_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string email = emailTextBox.Text;
                string userName = userNameTextBoxRegistration.Text;
                string password = passwordTextBoxRegistration.Text;
                int age = Convert.ToInt32(ageTextBox.Text);
                DateTime openingDate = Convert.ToDateTime(openingDateTextBox.Text);
                User newUser = new User(email, userName, password, age, openingDate);
                string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "spAddUser";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Email", newUser.Email);
                    cmd.Parameters.AddWithValue("@UserName", newUser.UserName);
                    cmd.Parameters.AddWithValue("@Password", newUser.Password);
                    cmd.Parameters.AddWithValue("@Age", newUser.Age);
                    cmd.Parameters.Add("@OpeningDate", newUser.OpeningDate);
                    SqlParameter outParameter = new SqlParameter();
                    outParameter.DbType = DbType.Int32;
                    outParameter.Direction = ParameterDirection.Output;
                    outParameter.ParameterName = "@UserId";
                    cmd.Parameters.Add(outParameter);
                    connection.Open();
                    int affectedRows = (int)cmd.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        msgLabelForRegistration.Text = "User added successfully, UserId = " + outParameter.Value;
                        msgLabelForRegistration.ForeColor = Color.Green;
                        GetClear();
                    }
                    else
                    {
                        msgLabelForRegistration.Text = "Process Failed!!!Please check all the input";
                        msgLabelForRegistration.ForeColor = Color.Red;
                    }
                }
            }
        }

        protected void clearButton_Click(object sender, EventArgs e)
        {
            GetClear();
        }

        private void GetClear()
        {
            emailTextBox.Text = string.Empty;
            userNameTextBoxRegistration.Text = string.Empty;
            passwordTextBoxRegistration.Text = string.Empty;
            confirmPasswordTextBox.Text = string.Empty;
            ageTextBox.Text = string.Empty;
            openingDateTextBox.Text = string.Empty;
        }
    }
}