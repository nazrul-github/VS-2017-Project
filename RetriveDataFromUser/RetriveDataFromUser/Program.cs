using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetriveDataFromUser
{
    class Program
    {
        static void Main(string[] args)
        {

            /* string firstName;
             string lastName;

             Console.WriteLine("Enter Your First Name: ");
             firstName = Console.ReadLine();

             Console.WriteLine("Enter Your Last Name: ");
             lastName = Console.ReadLine();

             Console.WriteLine($"{firstName} {lastName} \n"); */
            //asdfasdf

            int firstNumber;
            int secondNumber;
            int multiplicationResult;

            Console.WriteLine("Enter The First Number Here!");
            firstNumber =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Second Number Here!");
            secondNumber = int.Parse(Console.ReadLine());

            multiplicationResult = firstNumber * secondNumber;
            Console.WriteLine($"This is the muliplication result: {multiplicationResult}");
            }
    }
}
