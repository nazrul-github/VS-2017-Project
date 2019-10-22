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
        private DateTime _startTime = new DateTime(1990, 01, 01);
        private DateTime _stopTime = new DateTime(1990, 01, 01);



        public DateTime StartTime()
        {

            _startTime = DateTime.Now;
            ;
            return _startTime;


        }


        public void StopTime()
        {
            if (StartTime() == _startTime)
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

