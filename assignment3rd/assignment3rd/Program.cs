using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3rd
{
    class Program
    {
        static void Main(string[] args)
        {
            String firstName;
            String lastName;

            Console.WriteLine("Input your firstname here: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Input your lastname here: ");
            lastName = Console.ReadLine();

            Console.Write($"Your name is: {firstName} {lastName}\n");
            Console.WriteLine($"Also in Write Line Metod Your name is: {firstName} {lastName}");

            Console.WriteLine("Write Your Favourite Sports here:");
            String favSports = Console.ReadLine();
            Console.Write($"Your favourite sport is {favSports}\n");
            String favColor = "Light Blue";
            Console.WriteLine($"Your name is {firstName} {lastName} and your favourite sport is {favSports} also your favourite color is {favColor}");
            Console.Write("Now we need little more information about your self\nWrite Down your favourite hobby below:- \n");
            string favHobby = Console.ReadLine();
            Console.WriteLine($"So it seems like your favourite hobby is {favHobby}");
        }
    }
}
