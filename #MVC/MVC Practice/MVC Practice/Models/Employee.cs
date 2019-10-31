using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_Practice.Models
{
    [Table("tblEmploye")]

    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeGender { get; set; }
        public string EmployeeCity { get; set; }
        public DateTime DateOfBirth { get; set; }

    }
}