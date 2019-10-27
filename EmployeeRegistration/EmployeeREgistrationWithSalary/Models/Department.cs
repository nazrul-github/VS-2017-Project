using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeREgistrationWithSalary.Models
{
    public class Department
    {
        readonly DepartmentManager departmentManager = new DepartmentManager();
        public List<Employee> Employees = new List<Employee>();
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }

        public List<Department> GetDepartments()
        {
            return departmentManager.GetDepartment();
        } 

        public Department()
        {
        }
    }
}