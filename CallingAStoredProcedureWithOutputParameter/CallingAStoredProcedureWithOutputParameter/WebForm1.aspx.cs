using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CallingAStoredProcedureWithOutputParameter
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            GetNewConnection(connectionString);

        }

        private void GetNewConnection(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "spAddEmployee";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", nameTextBox.Text);
                cmd.Parameters.AddWithValue("@Gender", genderDropDownList.SelectedValue);
                cmd.Parameters.AddWithValue("@Salary",Convert.ToInt32(salaryTextBox.Text));
                SqlParameter outParameter = new SqlParameter();
                outParameter.DbType = DbType.Int32;
                outParameter.Direction = ParameterDirection.Output;
                outParameter.ParameterName = "@EmployeeId";
                cmd.Parameters.Add(outParameter);
                cmd.Connection = connection;
                connection.Open();
                cmd.ExecuteNonQuery();
                string lblValue = outParameter.Value.ToString();
                successLabel.Text = "Employee ID = " + lblValue;
            }
        }

    }
}
