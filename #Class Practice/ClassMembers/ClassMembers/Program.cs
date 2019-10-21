using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMembers
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0} I am {1}",to,Name);
        }

        public static Person Parse(string str)
        {
            Person person = new Person();

            person.Name = str;
            return person;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           Person newPerson = Person.Parse("John");

            newPerson.Introduce("Mosh");
        }
    }
}
