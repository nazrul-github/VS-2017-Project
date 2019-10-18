using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Stored_Procedures_With_Object_Data_Source.Models;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Stored_Procedures_With_Object_Data_Source
{
    public class EmployeeDataAccessLayer
    {
        public static List<Employee> GetEmployeeById(int departmentId)
        {
            List<Employee> newEmployees = new List<Employee>();
            string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);   
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "spgetEmployeeByDepartmentId";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@DepartmentId", departmentId);
            connection.Open();
          SqlDataReader rdr =  cmd.ExecuteReader();
            while (rdr.Read())
            {
                Employee aEmployee = new Employee();
                aEmployee.EmployeeId = (int) rdr["EmployeeId"];
                aEmployee.EmployeeName = rdr["Name"].ToString();
                aEmployee.DepartmentName = rdr["DepartmentName"].ToString();
                newEmployees.Add(aEmployee);
            }

            return newEmployees;
        }
    }
}