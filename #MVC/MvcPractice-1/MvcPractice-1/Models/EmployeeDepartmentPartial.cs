using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcPractice_1.Models
{
    [MetadataType(typeof(EmployeeMetaData))]
    public partial class Employee
    {

    }

    public class EmployeeMetaData
    {
        public int employeeId { get; set; }
        [Display(Name = "Employee Name")]
        [Required]
        public string name { get; set; }
        [Display(Name = "Employee Gender")]
        [Required]
        public string Gender { get; set; }
        [Display(Name = "Employee Salary")]
        [Required(ErrorMessage = "Please enter salary amount")]
        public Nullable<int> SALARY { get; set; }
        [Display(Name = "Employee Department")]
        [Required]
        public Nullable<int> DepartmentId { get; set; }
    }
    [MetadataType(typeof(DepartmentMetadata))]
    public partial class Department
    {
        
    }

    public class DepartmentMetadata
    {
        [DisplayName("Employee Department")]
        public string Name { get; set; }
    }
}