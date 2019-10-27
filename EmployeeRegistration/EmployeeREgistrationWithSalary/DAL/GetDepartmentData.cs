using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Configuration;
using EmployeeREgistrationWithSalary.Models;

namespace EmployeeREgistrationWithSalary.DAL
{
    public class GetDepartmentData
    {
        private readonly string connectionString = WebConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
        public List<Department> GetData()
        {
            List<Department> getDepartments = new List<Department>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "SELECT * FROM tblDepartment;";
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Department aDepartment = new Department();
                    aDepartment.DepartmentID = Int32.Parse(reader["DepartmentId"].ToString());
                    aDepartment.DepartmentName = reader["Name"].ToString();
                    getDepartments.Add(aDepartment);
                }
                reader.Close();
                connection.Close();
                return getDepartments;

            }
        }
    }
}