using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace MvcPractice_1.Models
{
    [Table("tblDepartment")]
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
    }
}