using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stored_Procedures_With_Object_Data_Source.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName  { get; set; }
        public string DepartmentName { get; set; }
    }
}