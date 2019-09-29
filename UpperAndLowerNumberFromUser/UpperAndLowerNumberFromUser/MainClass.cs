using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperAndLowerNumberFromUser
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the upper number:");
            int upperNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please input the lower number:");
            int lowerNumber = int.Parse(Console.ReadLine());
                Console.WriteLine($"All integers between {upperNumber} and {lowerNumber}");
            for(int i = lowerNumber; i<=upperNumber; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
