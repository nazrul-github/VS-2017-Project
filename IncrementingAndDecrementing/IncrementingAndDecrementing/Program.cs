using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncrementingAndDecrementing
{
    class Program
    {
        static void Main(string[] args)
        {
            // int myNumber = 10;
            //myNumber = myNumber + 1;
            //myNumber += 1;

            //myNumber++;
            //myNumber--;

            /*  int intValue = myNumber++;

              Console.WriteLine($"{intValue}");

              Console.WriteLine(intValue);

              Console.WriteLine(myNumber);*/

            /*  int number = 20;

              number++;

              Console.WriteLine(number);

              int anotherNumber = number++;

              Console.WriteLine(anotherNumber);

              Console.WriteLine(number);*/

            int integerNumber = 5;

            ++integerNumber;

            Console.WriteLine(integerNumber);

            int anotherIntegerNumber = ++integerNumber;

            Console.WriteLine(anotherIntegerNumber);

            --integerNumber;

            Console.WriteLine(integerNumber);

            int decrementedIntegerValue = --integerNumber;

            Console.WriteLine(decrementedIntegerValue);

        }
    }
}
