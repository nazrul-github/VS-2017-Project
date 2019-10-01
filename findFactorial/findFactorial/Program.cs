using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findFactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number for factorial");
            int numberForFactiorial =Convert.ToInt32( Console.ReadLine());
            int GetFactiorial(int number)
            {
                int factorialNumber = 0;
                if (number == 0)
                {
                    factorialNumber = 1;
                }else
                {
                    factorialNumber = number * GetFactiorial(number - 1);
                }
                return factorialNumber;
            }
            Console.WriteLine(GetFactiorial(numberForFactiorial));

            Console.WriteLine("Enter The Second Number For Factorial");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int GetSecondFactorial(int number)
            {
                int count = 1;
                for (int i = 1; i <=number; i++)
                {
                    count = count * i;
                }
                    return count;
            }
            Console.WriteLine(GetSecondFactorial(secondNumber));
        }
    }
}
