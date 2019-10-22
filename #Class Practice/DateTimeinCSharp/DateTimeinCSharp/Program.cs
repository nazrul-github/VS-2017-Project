using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeinCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  DateTime dateTime = new DateTime(1992,08,12);
            DateTime nowDateTime = DateTime.Now;
            DateTime todayDateTime = DateTime.Today;

            Console.WriteLine(nowDateTime.Minute);
            DateTime tomorrow = nowDateTime.AddDays(1);
            Console.WriteLine(tomorrow);

            Console.WriteLine(nowDateTime.ToLongDateString());
            Console.WriteLine(nowDateTime.ToShortDateString());
            Console.WriteLine(nowDateTime.DayOfWeek);
            Console.WriteLine(nowDateTime.Millisecond);
            Console.WriteLine(nowDateTime.Subtract(todayDateTime));
            Console.WriteLine(nowDateTime.ToString("yy-MM-dd hh-mm"));

            TimeSpan timeSpan = new TimeSpan(
                1,2,3);
            TimeSpan anotherTimeSpan = TimeSpan.FromHours(1);*/

            DateTime starTime = DateTime.Now;
            Console.WriteLine("Pess any key to stop the timer");
            Console.ReadKey();
            DateTime EndTime = DateTime.Now;

            TimeSpan minuteTimeSpan = EndTime.Subtract(starTime);

            Console.WriteLine("Minutes: "+minuteTimeSpan.Minutes);
            Console.WriteLine("Total Minutes: "+minuteTimeSpan.TotalMinutes);


        }
    }
}
