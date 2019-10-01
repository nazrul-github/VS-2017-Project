using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace askForOkOrNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            
                while(true)
                {
                Console.WriteLine("Please enter a number to calculte or ok to exit");
                var userInput = Console.ReadLine();
                if(userInput.ToLower() == "ok") { break; }
                    sum +=  Convert.ToInt32(userInput);
                }
            Console.WriteLine("Total entered amount = {0}",sum);
            }     
                
        
    }
}
