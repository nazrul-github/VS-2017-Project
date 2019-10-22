using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer newCustomer = new Customer(35,"Ahmad");
            newCustomer.Orders.Add(new Order());
            newCustomer.Orders.Add(new Order());
            newCustomer.Orders.Add(new Order());
           Customer anotherCustomer = new Customer(10,"robin");
            Console.WriteLine(newCustomer.Orders.Count);
            Console.WriteLine(anotherCustomer.Orders.Count);
        }
    }
}
