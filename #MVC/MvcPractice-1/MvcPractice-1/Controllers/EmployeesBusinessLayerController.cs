using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;

namespace MvcPractice_1.Controllers
{
    public class EmployeesBusinessLayerController : Controller
    {
        EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();

        // GET: EmployeesBusinessLayer
        public ActionResult Index()
        {
            List<Employee> employees = employeeBusinessLayer.Employees.ToList();
            return View(employees);
        }

        [HttpGet]
        [ActionName("Create")]
        public ActionResult Create_Get()
        {
            return View();
        }

        [HttpPost]

        /*
        //using FormCollction to collect form data 
        public ActionResult Create(FormCollection formCollection)
           {
               Employee aEmployee = new Employee();
               aEmployee.EmployeeName = formCollection["EmployeeName"];
               aEmployee.EmployeeCity = formCollection["EmployeeCity"];
               aEmployee.DateOfBirth = Convert.ToDateTime(formCollection["DateOfBirth"]);
               aEmployee.EmployeeGender = formCollection["Gender"];

               employeeBusinessLayer.AddEmployee(aEmployee);
               return RedirectToAction("Index");
           }*/
        /*
         // using paramter (parameter name should be same as the form input nmae) to collect form data
           public ActionResult Create(string employeeName,string gender,string employeeCity, DateTime dateOfBirth)
           {
               Employee aEmployee = new Employee();
               aEmployee.EmployeeName = employeeName;
               aEmployee.EmployeeCity = employeeCity;
               aEmployee.DateOfBirth = dateOfBirth;
               aEmployee.EmployeeGender = gender;

               employeeBusinessLayer.AddEmployee(aEmployee);
               return RedirectToAction("Index");
           }*/
        /*
         //Using Employee class as Employee class is used to create the form all the input name is same as the Employee class property name
         // if any name is different we have to change it to match the employee property.
         public ActionResult Create(Employee employee)
           {
               if (ModelState.IsValid)
               {
                   employeeBusinessLayer.AddEmployee(employee);
                   return RedirectToAction("Index");
               }

               return View();

           }*/

        // Using no parameter and updating employee object with UpdateModel method
        // But if we use this way we will get a compailation error as the both Post and Get method has the same name and same parameter which is none
        // to fix that we will use [ActionName("Create")] if we define action name for this method we can change the method name to anything and it will work, simillarly we can change the action method name for the get request
        [ActionName("Create")]
        public ActionResult Create_Post()
        {


            Employee employee = new Employee();
            TryUpdateModel(employee);
            if (ModelState.IsValid)
            {
                employeeBusinessLayer.AddEmployee(employee);
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        [ActionName("Edit")]
        public ActionResult Edit(int id)
        {
            Employee aEmployee = employeeBusinessLayer.Employees.Single(emp => emp.EmployeeId == id);
            return View(aEmployee);
        }

        /*
         //This is the include method
               [HttpPost]
           [ActionName("Edit")]
           public ActionResult Edit_Post(int id)
           {
               Employee aEmployee = employeeBusinessLayer.Employees.Single(emp => emp.EmployeeId == id);

               UpdateModel(aEmployee,new string[]{"EmployeeId","EmployeeCity","EmployeeGender", "DateOfBirth" });
               if (ModelState.IsValid)
               {
                   employeeBusinessLayer.UpdateEmployee(aEmployee);
                   return RedirectToAction("Index");
               }

               return View(aEmployee);
           }*/

        //Exclude method
        /*
        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit_Post(int id)
        {
            Employee aEmployee = employeeBusinessLayer.Employees.Single(emp => emp.EmployeeId == id);
            TryUpdateModel(aEmployee,null,null,new string[]{"EmployeeName"});
            if (ModelState.IsValid)
            {
                employeeBusinessLayer.UpdateEmployee(aEmployee);
                return RedirectToAction("Index");
            }

            return View(aEmployee);
        }*/

        //Bind method
        /*
                [HttpPost]
                [ActionName("Edit")]
                public ActionResult Edit_Post([Bind(Exclude = "EmployeeName")] Employee aEmployee)
                {
                    aEmployee.EmployeeName = employeeBusinessLayer.Employees
                        .Single(emp => emp.EmployeeId == aEmployee.EmployeeId).EmployeeName;
                    if (ModelState.IsValid)
                    {
                        employeeBusinessLayer.UpdateEmployee(aEmployee);
                        return RedirectToAction("Index");
                    }

                    return View(aEmployee);
                }*/
        // Using Interface
        [HttpPost]
        [ActionName("Edit")]
        public ActionResult Edit_Post(int id)
        {
            Employee aEmployee = employeeBusinessLayer.Employees.Single(emp => emp.EmployeeId == id);
            TryUpdateModel<IEmploye>(aEmployee);
            if (ModelState.IsValid)
            {
                employeeBusinessLayer.UpdateEmployee(aEmployee);
                return RedirectToAction("Index");
            }

            return View(aEmployee);
        }

        [HttpGet]
        [ActionName("Delete")]
        public ActionResult Delete_Get(int id)
        {
            Employee aEmployee = new Employee();
            aEmployee = employeeBusinessLayer.Employees.Single(emp => emp.EmployeeId == id);
            return View(aEmployee);
        }

        [HttpPost]
        [ActionName("Delete")]
        public ActionResult Delete_Post(int id)
        {
            employeeBusinessLayer.DeleteEmploye(id);
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Employee aEmployee = new Employee();
            aEmployee = employeeBusinessLayer.Employees.Single(emp => emp.EmployeeId == id);
            return View(aEmployee);
        }
    }
}