using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsOfCSharp
{
    class Program
    {
        
        static void Main(string[] args)
        {
         //   UsePoint();
            GetAdded();
        }

            private static void GetAdded()
            {
                Calculator addCalculator = new Calculator();
                Point aPoint = new Point(10,89);
                Point bPoint = new Point(30,89);
                Point cPoint = new Point(40,9);
                Point dPoint = new Point(70,189);
                Point ePoint = new Point(100,819);

                Point result = addCalculator.Add(aPoint, bPoint, cPoint, dPoint, ePoint);
                Console.WriteLine(result.y);
            }

        private static void UsePoint()
        {
            try
            {
                Point newPoint = new Point { x = 10 };
                newPoint.Move(new Point(10,20));
                Console.WriteLine("Point is at {0} {1}",  newPoint.x, newPoint.y);
            }
            catch (Exception)
            {

                Console.WriteLine("An unexpected error occured");

            }
        }
    }
}
