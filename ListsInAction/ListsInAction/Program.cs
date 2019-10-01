using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsInAction
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberList = new List<int>() { 1,2,9,687,6,4,8,9};
            numberList.Add(96);
            numberList.AddRange(new int[5] { 5, 4, 3, 2, 1 });
            foreach (var number in numberList)
            {
                Console.WriteLine(  number);
            }
            Console.WriteLine("**********");
            Console.WriteLine(numberList.LastIndexOf(1));
            Console.WriteLine(numberList.Count);

            numberList.Remove(9);
                Console.WriteLine("New Number List After Removing 9");
            foreach (var number in numberList)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine($"index of 9 {numberList.IndexOf(9,0,7)}");
        }
    }
}
