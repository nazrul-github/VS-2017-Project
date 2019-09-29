using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 30;
            int number2 = 20;

          /*  if (number1 > number2)
            {
                Console.WriteLine("Number 1 is greater than Number 2");
            }
            else { Console.WriteLine("Number 1 is equal to or less than number 2"); }*/

            Console.WriteLine(number1 > number2 ? "Number 1 is greater than Number 2" : "Number 1 is equal to or less than number 2");
        }
    }
}
