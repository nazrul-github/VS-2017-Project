using System;
using System.Collections.Generic;
using EmployeeREgistrationWithSalary.DAL;

namespace EmployeeREgistrationWithSalary.Models
{
    public class DepartmentManager
    {
        readonly GetDepartmentData getDepartmentData = new GetDepartmentData();
        public List<Department> GetDepartment()
        {
          return  getDepartmentData.GetData();
        }
    }
}