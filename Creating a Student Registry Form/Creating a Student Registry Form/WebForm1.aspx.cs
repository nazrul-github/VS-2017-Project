using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace Creating_a_Student_Registry_Form
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM tblProductCategories; SELECT * FROM product_inventory; ";
                cmd.Connection = connection;
                connection.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    tblProductCategories.DataSource = rdr;
                    tblProductCategories.DataBind();
                    while (rdr.NextResult())
                    {
                    product_inventory.DataSource = rdr;
                    product_inventory.DataBind();
                    }
                }
            }
        }
    }
}