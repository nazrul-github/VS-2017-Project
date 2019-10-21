using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer(1,"John");
            Console.WriteLine(customer.id);
            Console.WriteLine(customer.name);

            Order newOrder = new Order();
            customer.Orders.Add(newOrder);


        }
    }
}
