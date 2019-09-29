using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Customer
    {
        public string Name { get; set; }
        private int id;
        private int salary;

        public int ID { get { return id; } set { id = value; } }
        public int Salary { get { return salary; } set { salary = value; } }

        public Customer(string nameValue, int idValue, int salaryValue)
        {
            Name = nameValue;
            ID = idValue;
            Salary = salaryValue;
        }


    }
}
