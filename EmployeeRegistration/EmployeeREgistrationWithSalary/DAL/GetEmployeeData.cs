using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using EmployeeREgistrationWithSalary.Models;

namespace EmployeeREgistrationWithSalary.DAL
{
    public class GetEmployeeData
    {
        public bool EmployeeExist(Employee newEmployee)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText =
                    "SELECT * FROM tblEmploye WHERE RegistrationNumber = @EmployeeReg AND MobileNumber = @MobileNumber";
                cmd.Parameters.AddWithValue("@EmployeeReg", newEmployee.EmployeeRegistrationNumber);
                cmd.Parameters.AddWithValue("@MobileNumber", newEmployee.MobileNumber);
                cmd.Connection = connection;
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public string SaveToDatabase(Employee newEmployee)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "spSaveEmployee";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", newEmployee.Name);
                cmd.Parameters.AddWithValue("@MObileNumber", newEmployee.MobileNumber);
                cmd.Parameters.AddWithValue("@District", newEmployee.District);
                cmd.Parameters.AddWithValue("@Gender", newEmployee.Gender);
                cmd.Parameters.AddWithValue("@DateOfBirth", newEmployee.DateTime);
                cmd.Parameters.AddWithValue("@RegistrationNumber", newEmployee.EmployeeRegistrationNumber);
                SqlParameter outParameter = new SqlParameter();
                outParameter.DbType = DbType.Int32;
                outParameter.Direction = ParameterDirection.Output;
                outParameter.ParameterName = "@EmployeeId";
                cmd.Parameters.Add(outParameter);
                connection.Open();
                int affected = cmd.ExecuteNonQuery();
                if (affected > 0)
                {
                    string affectedData ="Employee added, Employee Id: "+ "@EmployeeId";
                    return affectedData;
                }
                else
                {
                    return "Employee adding failed check all the information";
                }
            }
        }

        public string UpdateToDatabase(Employee newEmployee)
        {
            string connectionString = WebConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "spGetEmployee";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", newEmployee.Name);
                cmd.Parameters.AddWithValue("@MObileNumber", newEmployee.MobileNumber);
                cmd.Parameters.AddWithValue("@District", newEmployee.District);
                cmd.Parameters.AddWithValue("@Gender", newEmployee.Gender);
                cmd.Parameters.AddWithValue("@DateOfBirth", newEmployee.DateTime);
                cmd.Parameters.AddWithValue("@RegistrationNumber", newEmployee.EmployeeRegistrationNumber);
                connection.Open();
                int affectedRow = cmd.ExecuteNonQuery();
                if (affectedRow > 0)
                {
                    return "Employee data updated for @RegistrationNumber,";
                }
                else
                {
                    return "Employee data update failed";
                }
            }
        }

        public static List<Employee> GetGridViewData()
        {
            List<Employee> employees = new List<Employee>();
            string connectionString = WebConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM employee_data",connection);
                
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Employee employee = new Employee();
                while (reader.Read())
                {
                    employee.ID = (int)reader["EmployeeId"];
                    employee.Name = reader["Name"].ToString();
                    employee.MobileNumber = reader["MobileNumber"].ToString();
                    employee.Gender = reader["Gender"].ToString();
                    employee.DateTime = Convert.ToDateTime(reader["DateOfBirth"]);
                    employee.EmployeeRegistrationNumber = Convert.ToInt32( reader["RegistrationNumber"]);
                }
                employees.Add(employee);

                reader.Close();
                connection.Close();
                return employees;
            }
        }
    }
}