using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace SQLInjectionAttach
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void getProductsButton_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

            GetConnectionForGridView(connectionString);
            

        }

        private void GetConnectionForGridView(string connectionString)
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.AddWithValue("@Product", searchTextBox.Text + "%");
                cmd.CommandText =
                    "SELECT * FROM product_inventory WHERE ID LIKE @Product OR product_name LIKE @Product OR quantity_available LIKE @Product";
                cmd.Connection = connection;
                connection.Open();
                GridView1.DataSource = cmd.ExecuteReader();
                GridView1.DataBind();
            }
        }
    }
}