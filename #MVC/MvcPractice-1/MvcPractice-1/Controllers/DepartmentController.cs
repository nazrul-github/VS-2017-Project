using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcPractice_1.Models;

namespace MvcPractice_1.Controllers
{
    public class DepartmentController : Controller
    {
        EmployeeContext department = new EmployeeContext();
        // GET: Department
        public ActionResult Index()
        {
            List < Department > allDepartments = department.Departments.ToList();
            return View(allDepartments);
        }
    }
}