using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumOfTheSquareOfTheFirstTenNaturalNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum_of_squares(int number)
            {
                int sum = 0;
                for(int i = 1; i<number; i++)
                {
                    sum = sum + (i * i);
                }
                return sum;
            }
            int square_of_sum(int number)
            {
                int sum = 0;
                for(int i = 1; i < number; i++)
                {
                    sum += i;
                }
                return sum * sum;
            }
            int result = square_of_sum(100) - sum_of_squares(100);
            Console.WriteLine(result);
        }
    }
}
