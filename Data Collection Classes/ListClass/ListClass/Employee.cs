using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListClass
{
    class Employee
    {
        public string Name { get; set; }
        private int salary;
        private int id;
        private int yearsBeenWorking;
        
        public int Salary { get { return salary; } set { if (value > 0) { salary = value; } } }
        public int ID { get { return id; } set { if (value > 0) { id = value; } } }
        public int YearsWorked { get { return yearsBeenWorking; } set { if (value > 1) { yearsBeenWorking = value; } } }


        public Employee(string nameValue, int salaryValue, int idValue, int yearsWorkValue)
        {
            Name = nameValue;
            Salary = salaryValue;
            ID = idValue;
            YearsWorked = yearsWorkValue;
        }

    }
}
