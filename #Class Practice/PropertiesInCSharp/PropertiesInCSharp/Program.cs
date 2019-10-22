using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
         Person aPerson = new Person(new DateTime(1992,12,16));
            int age = aPerson._age;
            Console.WriteLine(age);
        }
    }
}
