using System.Collections.Generic;

namespace Constructors
{
    public class Customer
    {
        public int id;
        public string name;
        public List<Order> Orders;
        

        public Customer(int id):this()
        {
            this.id = id;
        }

        public Customer(int id, string name) : this(id)
        {
            this.name = name;
        }

        public Customer()
        {
            Orders = new List<Order>();
        }
    }
}
