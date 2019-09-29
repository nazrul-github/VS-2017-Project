using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter width and height of your monitor to check for landscape or potrait");
            Console.WriteLine("Please enter the width");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the height");
            int height = Convert.ToInt32( Console.ReadLine());

            if(width>height){
                Console.WriteLine("This image is a landscape");
                }else{Console.WriteLine("This image is a potrait");

                Console.WriteLine("Finished Comparing");
             
        }
    }
}
