using System;
using System.Runtime.Remoting.Messaging;

namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            RateCalculator calculator = new RateCalculator();
            int rating = calculator.Calculate(this);

            Console.WriteLine("Promote logic changed");
        }

       
    }
}