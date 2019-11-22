using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcPractice_1.Models
{
    public class DepartmentTotal
    {
        [Key]
        public string Name { get; set; }
        public int Total { get; set; }
    }
}