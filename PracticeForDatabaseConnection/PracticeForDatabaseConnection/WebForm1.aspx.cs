using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using  System.Configuration;

namespace PracticeForDatabaseConnection
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBCS1"].ConnectionString;
            GetConnection(connectionString);

        }

        private void GetConnection(string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText =
                    "UPDATE tbl_product set[Qty Available] = 200 Where[Product Id] = 2 UPDATE tbl_product set[Unit Price] = 100 Where[Product Id] = 4;";
                cmd.Connection = connection;
                connection.Open();
               int totalCount = cmd.ExecuteNonQuery();
                Response.Write($"Total rows inserted = {totalCount}<br/>");
                cmd.CommandText = "DELETE FROM tbl_product where [Product Id] = 4;";
                int totalRowDelete = cmd.ExecuteNonQuery();

                Response.Write($"Total rows deleted = {totalRowDelete}");

            }
        }

        
    }
}