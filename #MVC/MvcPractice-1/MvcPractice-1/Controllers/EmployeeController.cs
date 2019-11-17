using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcPractice_1.Models;

namespace MvcPractice_1.Controllers
{
    public class EmployeeController : Controller
    {
        readonly EmployeeContext employeeContext = new EmployeeContext();

        //GET: All Employees
        public ActionResult Index(int departmentId)
        {
            List<Employee> aEmployees = employeeContext.Employees.Where(emp=>emp.DepartmentId == departmentId).ToList();
            return View(aEmployees);
        }
        // GET: Single Employee
        public ActionResult Details(int id)
        {
          var employee = employeeContext.Employees.Single(emp => emp.EmployeeId == id);
          return View(employee);
        }
    }
}