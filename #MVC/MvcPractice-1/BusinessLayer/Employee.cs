using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BusinessLayer
{
    public interface IEmploye
    {
        int EmployeeId { get; set; }
        string EmployeeGender { get; set; }
        string EmployeeCity { get; set; }
        DateTime? DateOfBirth { get; set; }
    }
    public class Employee: IEmploye
    {
        public int EmployeeId { get; set; }
        [Required]
        public string EmployeeName { get; set; }
        [Required]
        public string EmployeeGender { get; set; }
        [Required]
        public string EmployeeCity { get; set; }
        [Required]
        public DateTime? DateOfBirth { get; set; }
    }
    
}
