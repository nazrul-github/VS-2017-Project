using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StopWatchProject.Models
{
    class StopWatch
    {
        private DateTime _startTime;
        private DateTime _stopTime;



        public void StartTime()
        {
            if (_startTime - _startTime == new TimeSpan())
            {
                Console.WriteLine("Please stop the timer first");
            }
            else
            {
                
            _startTime = DateTime.Now;
            }
            ;


        }


        public void StopTime()
        {
            if (_stopTime != _startTime)
            {
                _stopTime = DateTime.Now;

                TimeSpan timeSpend = _startTime - _stopTime;
                Console.WriteLine(timeSpend);
            }
            else
            {
                Console.WriteLine("Please run the stopwatch");
            }

        }


    }

}

