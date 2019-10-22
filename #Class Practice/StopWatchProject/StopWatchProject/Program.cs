using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StopWatchProject.Models;

namespace StopWatchProject
{
    
    class Program
    {
        static void Main(string[] args)
        {
           StopWatch timeStopWatch = new StopWatch();

            timeStopWatch.StartTime();

            Console.WriteLine("Press any key to stop the timer");
            Console.ReadKey();
            timeStopWatch.StartTime();
        }
    }
}
