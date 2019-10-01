using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiDimensionalArraysInAction
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] numbers = new int[] { 3, 7, 9, 6, 8, 9,13,1,2,8,7 };
           // // Length properties
            Console.WriteLine("Length: {0}",numbers.Length);
            //Indexof()
            int indexOfNine = Array.IndexOf(numbers, 9);
            Console.WriteLine($"The index of {numbers[2]}: {indexOfNine}");
            //Clear()
           Array.Clear(numbers, 0, 2);
            Console.WriteLine("Affect of clear method");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            //Copy()
            var secondArrayOfNumbers = new int[6];
            Array.Copy(numbers, 1, secondArrayOfNumbers, 2, 4);
            Console.WriteLine("Second Array Of Numbers Element");
            foreach (var number in secondArrayOfNumbers)
            {
                Console.WriteLine(number);
            }
            //Sort()
            Array.Sort(numbers);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("******************");
            //Reverse
            Array.Reverse(numbers);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
