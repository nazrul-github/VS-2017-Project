using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedCamera
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the speed limit");
            int speedLimit  = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the speed of a vehicle: ");
            int vehicleSpeed = Convert.ToInt32(Console.ReadLine());
            if (vehicleSpeed < speedLimit)
            {
                Console.WriteLine("Ok");
            }else if(vehicleSpeed>speedLimit){
                int differenceInSpeed = vehicleSpeed - speedLimit;
                int demeritPoints = differenceInSpeed / 5;
                if (demeritPoints > 12)
                {
                    Console.WriteLine("License Suspended");
                }
                else { Console.WriteLine("{0} demerit points added to the license",demeritPoints); }
            }
            else { Console.WriteLine("Please enter a correct vehicle speed"); }
            
        }
    }
}
