using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pickingRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomNumber = new Random();
            int randomNumberForGuess = randomNumber.Next(1,10);
            Console.WriteLine($"Your Random Number Is: {randomNumberForGuess}");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Gues the number");
                int guessTheNumber = Convert.ToInt32( Console.ReadLine());
                if(guessTheNumber == randomNumberForGuess)
                {
                    Console.WriteLine("You Won");
                    break;
                }
                else
                {
                    Console.WriteLine("You Lost");
                }

            }
        }
    }
}
