using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            //for loops
            // we need to loop to go over the list of numbres and print the even numbers from 1 to 10

            var listOfNumbers = new List<int>(10);
            for (int i = 1; i <= 10; i++)
            {
                listOfNumbers.Add(i);
            }
            foreach (var number in listOfNumbers)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
                else { continue; }
            }

            // we need to loop to go over the list of numbres and print the even numbers from 10 to 1
            var secondList = new List<int>(10);
            for (int i = 10; i >= 1; i--)
            {
                secondList.Add(i);
            }
            foreach (var number in secondList)
            {
                if(number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }

            //create a string and iterate over the letters of the string
            Console.WriteLine("Enter your full name");
            string fullName = Console.ReadLine();
            List<char> lettersOfFullName = new List<char>();
            Console.WriteLine("List Of Letters In Your Name");
            for (int i = 0; i < fullName.Length; i++)
            {
                lettersOfFullName.Add(fullName[i]);
            }
            foreach (var letters in lettersOfFullName)
            {
                Console.WriteLine(letters);
            }

            // to just print the letters without storing them in a list
            for (int i = 0; i < fullName.Length; i++)
            {
                Console.WriteLine(fullName[i]);
            }
            foreach (var character in fullName)
            {
                Console.WriteLine(character);
            }

            //create an array and iterate over the items of the array
            var numbersArray = new int [] { 1, 2, 3, 4, 5 };
            foreach (var number in numbersArray)
            {
                Console.WriteLine(number);
            }
            
            //Write a simple eco programme, in this programme we are goin to display a message on the console asking the user to type their name. if the user types their name. The console is going to repeat or eco that name

            while (true)
            {
                Console.Write("Type your Name: ");
                string input = Console.ReadLine();
                    if (!String.IsNullOrWhiteSpace(input)){
                    Console.WriteLine($"Echo: {input}");
                    continue;
                }
                break;
            }
            
         // Using random Class

            //Using random class's next method to create random numbers between 1 to 100
             var randomClass = new Random();
              for (int i = 0; i < 10; i++)
              {
                  Console.WriteLine(randomClass.Next(1,100));

              }
            // using random class's next method to generate random password
            var randomLetters = new Random();
            Console.WriteLine("how many letters you need for the password");
            int lengthOfPassword = Convert.ToInt32(Console.ReadLine());
            var characterArray = new char[lengthOfPassword];

            for (int i = 0; i < lengthOfPassword; i++)
            {
                characterArray[i] =((char)('a' + randomLetters.Next(0,26)));
            }
            var password = new string(characterArray);
            Console.WriteLine("Your Password is below \n{0}",password);
        }
    }
}
