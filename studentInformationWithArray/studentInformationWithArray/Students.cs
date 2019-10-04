using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentInformationWithArray
{
    class Students
    {
        private string regNo;
        private string firstName;
        private string lastName;

        public Students(string regNo, string firstName, string lastName)
        {
            RegistrationNo = regNo;
            FirstName = firstName;
            LastName = lastName;
        }
        public string RegistrationNo { get { return regNo; } set { regNo = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set {lastName=value; } }

    }
}
