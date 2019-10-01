using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    enum ImageOrientation
    {
        Landscape,
        Portrait
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Image width: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Image height: ");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = width > height ? (int)ImageOrientation.Landscape : (int)ImageOrientation.Portrait;
            Console.WriteLine("Image orientation is {0} ", orientation);
        } 
            

         
    }
    }

