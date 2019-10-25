using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeREgistrationWithSalary.Models
{
    public class Employee
    {
        public Employee()
        {
        }

        public Employee(string name, string emailAddress, string mobileNumber, string district, string gender, DateTime dateTime, int employeeRegistrationNumber)
        {
            Name = name;
            EmailAddress = emailAddress;
            MobileNumber = mobileNumber;
            District = district;
            Gender = gender;
            DateTime = dateTime;
            EmployeeRegistrationNumber = employeeRegistrationNumber;
        }

        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNumber { get; set; }
        public string District { get; set; }
        public string Gender { get; set; }
        public DateTime DateTime { get; set; }
        public int EmployeeRegistrationNumber { get; set; }
        public int ID { get; set; }

    }
}