using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var newNumber = DoRandom();
            Console.WriteLine(newNumber);
           
        }
        public static long DoRandom()
        {
            Random r = new Random();
            //////// it will create 13 digit number
            int number = r.Next(999999999);
            int number2 = r.Next(9999);

            return ((long)number2 * (long)1000000000) + (long)number;
        }
    }
}
