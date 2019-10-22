using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiersInCSharp
{
    public class Person
    {
        private DateTime _birthDate;

        public void SetBirthDate(DateTime dateTime)
        {
            _birthDate = dateTime;
        }

        public DateTime GetBirhtDate()
        {
            return _birthDate;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.SetBirthDate(new DateTime(1998,08,01));
            Console.WriteLine(person.GetBirhtDate());
        }
    }
}
