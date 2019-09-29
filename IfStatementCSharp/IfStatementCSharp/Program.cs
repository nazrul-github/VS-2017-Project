using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfStatementCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber;
            int secondNumber;

            Console.WriteLine("Please enter first integer value:");
            firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter second integer value:");
            secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine($"{firstNumber}, {secondNumber}");

            if (firstNumber==secondNumber) {
                Console.WriteLine($"{firstNumber} is the same as {secondNumber}");
            }
            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"{firstNumber} is greater than {secondNumber}");
            }
            if (secondNumber > firstNumber)
            {
                Console.WriteLine($"{firstNumber} is less than {secondNumber}");
            }
            // <=,>=,!=
            if (firstNumber <= secondNumber)
            {
                Console.WriteLine($"{firstNumber} is less than or equal to {secondNumber}");
            }
            if(firstNumber != secondNumber)
            {
                Console.WriteLine($"{firstNumber} is not equal to { secondNumber}");
            }

        }
    }
}
