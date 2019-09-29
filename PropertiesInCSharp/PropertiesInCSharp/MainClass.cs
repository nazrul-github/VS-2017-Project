using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesInCSharp
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Computer myComputer = new Computer();


            //Console.WriteLine(myComputer.GetComputerName());
            myComputer.ComputerName = "iPhone 5s";
            Console.WriteLine(myComputer.ComputerName);

            myComputer.ComputerPower = 500;
            Console.WriteLine(myComputer.ComputerPower);
        }
    }
}
