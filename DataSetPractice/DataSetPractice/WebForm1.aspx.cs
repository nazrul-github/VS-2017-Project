using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataSetPractice
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = new SqlCommand("spGetData",connection);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                dataSet.Tables[0].TableName = "product_inventory";
                dataSet.Tables[1].TableName = "tblProductCategories";
                GridView1.DataSource = dataSet.Tables["product_inventory"];
                GridView1.DataBind();
                GridView2.DataSource = dataSet.Tables["tblProductCategories"];
                GridView2.DataBind();
            }

        }
    }
}