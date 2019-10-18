using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.Caching;

namespace Stored_Procedures_With_Object_Data_Source.Models
{
    public class DepartmentDataAccessLayer
    {

        public   List<Department> GetDepartments()
        {
       List<Department> listofDepartments = new List<Department>();
            string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection newConnection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = newConnection;
                cmd.CommandText = "spgetDepartments";
                cmd.CommandType = CommandType.StoredProcedure;
                newConnection.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    Department allDepartment = new Department();
                    allDepartment.DepartmentId = (int) rdr["DepartmentId"];
                    allDepartment.DepartmentName = rdr["Name"].ToString();
                    listofDepartments.Add(allDepartment);
                }
            }

            return listofDepartments;
        }
    }
    
}