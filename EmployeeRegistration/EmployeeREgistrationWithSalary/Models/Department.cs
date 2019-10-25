using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeREgistrationWithSalary.Models
{
    public class Department
    {
        public List<Employee> Employees = new List<Employee>();

        public Department()
        {
        }
    }
}