using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace GridViewPractice
{
    public class product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class ProductDataAccessLayer
    {
        public static List<product> GetAllProducts()
        {
            List<product> listProducts = new List<product>();

         string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using(SqlConnection connection = new SqlConnection(connectionString))
        {
                SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM tblProducts;";
            cmd.Connection = connection;
            connection.Open();
           SqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                product newProduct = new product();
                newProduct.Id = (int) rdr["id"];
                newProduct.Description = rdr["Description"].ToString();
                newProduct.Name = rdr["Name"].ToString();
                listProducts.Add(newProduct);
            }

            return listProducts;

        }
            
    }

}
}