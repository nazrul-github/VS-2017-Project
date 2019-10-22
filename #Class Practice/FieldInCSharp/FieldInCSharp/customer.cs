using System;
using System.Collections.Generic;

namespace FieldInCSharp
{
    public class Customer
    {
        public int id;
        public string name;
        public readonly  List<Order> Orders = new List<Order>();  //we can initialize the field here too (it's of personal taste to initialize the list at field or inside constructor)

     /*   public customer()
        {
          //  Orders = new List<Order>();
        }*/

        public Customer(int id)
        {
            this.id = id;
        }

        public Customer(int id, string name) : this(id)
        {
            this.name = name;
        }

        public void Promote()
        {
            //Orders = new List<Order>();
        }

    }
}
