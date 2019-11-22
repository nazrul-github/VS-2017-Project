using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace BusinessLayer
{
    public class EmployeeBusinessLayer
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

        public IEnumerable<Employee> Employees
        {
            get
            {
                List<Employee> allEmployees = new List<Employee>();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "SELECT * FROM tblEmploye";
                    cmd.Connection = connection;
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Employee aEmployee = new Employee();
                        aEmployee.EmployeeId = (int)reader["EmployeeId"];
                        aEmployee.EmployeeName = reader["EmployeeName"].ToString();
                        aEmployee.EmployeeGender = reader["EmployeeGender"].ToString();
                        aEmployee.EmployeeCity = reader["EmployeeCity"].ToString();
                        if (!(reader["DateOfBirth"] is DBNull))
                        {
                            aEmployee.DateOfBirth = DateTime.Parse(reader["DateOfBirth"].ToString());
                        }

                        allEmployees.Add(aEmployee);
                    }
                    reader.Close();
                    connection.Close();
                    return allEmployees;
                }
            }
        }

        public void AddEmployee(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "sp_SaveEmployee";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeName", employee.EmployeeName);
                cmd.Parameters.AddWithValue("@EmployeeGender", employee.EmployeeGender);
                cmd.Parameters.AddWithValue("@EmployeeCity", employee.EmployeeCity);
                cmd.Parameters.AddWithValue("@DateOfBirth", employee.DateOfBirth);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateEmployee(Employee employee)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "sp_UpdateEmployee";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmployeeId", employee.EmployeeId);
                cmd.Parameters.AddWithValue("@EmployeeName", employee.EmployeeName);
                cmd.Parameters.AddWithValue("@EmployeeGender", employee.EmployeeGender);
                cmd.Parameters.AddWithValue("@EmployeeCity", employee.EmployeeCity);
                cmd.Parameters.AddWithValue("@DateOfBirth", employee.DateOfBirth);
                connection.Open();
                cmd.ExecuteNonQuery();
            }

        }

        public void DeleteEmploye(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "DELETE FROM tblEmploye WHERE EmployeeId = @Id;";
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Connection = connection;
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
