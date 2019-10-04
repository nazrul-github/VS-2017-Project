using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeForm
{
  public  class Employee
    {
        public string ID { get {
                Random random = new Random();
                string randomNumber = random.Next(100, 200).ToString();
                return randomNumber;
            } set { ID = value; } }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DateOfBirth { get; set; }
        public string Salary { get; set; }

        public Employee(string firstName, string lastName, string dateOfBirth, string salary)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Salary = salary;
        }
    }
}
