using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebuggingInCSharp
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Boxer myBoxer = new Boxer();

            Console.WriteLine(myBoxer.GetPunchPower());

            int number = int.Parse(Console.ReadLine());

            myBoxer.SetPunchPower(number);
            Console.WriteLine(myBoxer.GetPunchPower());

        }
    }
}
