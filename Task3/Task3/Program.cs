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
            public void Exercise3()
            {
                Console.Write("Image width: ");
                var width = Convert.ToInt32(Console.ReadLine());

                Console.Write("Image height: ");
                var height = Convert.ToInt32(Console.ReadLine());

                var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
                Console.WriteLine("Image orientation is " + orientation);
            }

        public enum ImageOrientation
        {
            Landscape,
            Portrait
        }
    }
    }
}
