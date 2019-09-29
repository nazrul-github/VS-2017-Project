using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Input The First Number To Compare");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Input Second Number To Compare");
            int secondNumber = int.Parse(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("First Number Is bigger");
            }
            if (firstNumber < secondNumber)
            {
                Console.WriteLine("Second Number Is Bigger");
            }
            if(firstNumber<=100 || secondNumber <= 1)
            {
                Console.WriteLine("Both Numbers Are Between 1 to 100");
            }
            if(firstNumber%2 != 0 || secondNumber%2 != 0)
            {
                Console.WriteLine("None of the numbers are prime number");
            }
            if (firstNumber % 2 == 0)
            {
                Console.WriteLine("The First Number Is A Composite Number");
            }
            if (secondNumber % 2 == 0)
            {
                Console.WriteLine("The Second Number Is a Composite Number");
            }

            Color name = new Color();

            name.Red = "Red";
            name.Blue = "Blue";
            name.Yellow = "Yellow";
            name.Purple = "Purple";
            Console.WriteLine($"{name.Red} {name.Blue} {name.Yellow} {name.Purple}");

        }
    }
}
