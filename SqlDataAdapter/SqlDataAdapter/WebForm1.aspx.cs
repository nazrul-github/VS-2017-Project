using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SqlDataAdapter
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               System.Data.SqlClient.SqlDataAdapter da = new System.Data.SqlClient.SqlDataAdapter("spGetProductInventory", connection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet ds = new DataSet();

                da.Fill(ds);
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
        }

        protected void getProductButton_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                System.Data.SqlClient.SqlDataAdapter  da=  new System.Data.SqlClient.SqlDataAdapter();
                da.SelectCommand = new SqlCommand("spGetEmployeeWithId",connection);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("@EmployeeId", searchTextBox.Text);
                DataSet ds = new DataSet();
                da.Fill(ds);
                
                GridView2.DataSource = ds;
                GridView2.DataBind();
            }
        }
    }
}