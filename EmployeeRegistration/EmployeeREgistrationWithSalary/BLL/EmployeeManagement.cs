using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using EmployeeREgistrationWithSalary.DAL;
using EmployeeREgistrationWithSalary.Models;

namespace EmployeeREgistrationWithSalary.BLL
{
    public class EmployeeManagement
    {
        GetEmployeeData newRequest = new GetEmployeeData();
        public void MobileNumberLengthValidate(object source, ServerValidateEventArgs args)
        {
            long number = 0;
            bool isInteger = long.TryParse(args.Value, out number);
            if (args.Value.Length==11 && isInteger )
            {
                args.IsValid = true;
            }
            else
            {
                args.IsValid = false;
            }
        }


        public bool IsExist(Employee newEmployee)
        {
            bool isTrue = newRequest.EmployeeExist(newEmployee);
            if (isTrue)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string SendData(Employee newEmployee)
        {

            if (IsExist(newEmployee))
            {
                return "Employee Id Already Exist";
            }
            else
            {
                return 
            newRequest.SaveToDatabase(newEmployee);
            }

        }

        public string UpdateData(Employee newEmployee)
        {
            if (IsExist(newEmployee))
            {
                return 
                    newRequest.UpdateToDatabase(newEmployee);
            }
            else
            {
                return "";
                
            }
        }

        public List<Employee> GetDataForGridView()
        {
            List<Employee> getEmployees = GetEmployeeData.GetGridViewData();
            return getEmployees;
        }
    }
}