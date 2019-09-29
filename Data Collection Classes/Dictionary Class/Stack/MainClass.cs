using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer("John", 101, 6500);
            Customer customer2 = new Customer("Pam", 110, 8500);
            Customer customer3 = new Customer("Ross", 221, 7000);

            /*  Dictionary<int, Customer> nameOFDictionary = new Dictionary<int, Customer>();
              nameOFDictionary.Add(customer1.ID, customer1);
              nameOFDictionary.Add(customer2.ID, customer2);
              nameOFDictionary.Add(customer3.ID, customer3);

              nameOFDictionary.Remove(customer3.Salary);

              //getting key of nameOFDictionary and setting them to a new Dictionary Variable
            Dictionary<int, Customer>.KeyCollection allKeys = nameOFDictionary.Keys;
              Dictionary<int, Customer>.ValueCollection allValues = nameOFDictionary.Values;

              Console.WriteLine(allKeys);
              Console.WriteLine(allValues);
              nameOFDictionary.TryGetValue(221, out customer1);

             Customer customer119 = nameOFDictionary[221];
              Console.WriteLine($"Name: {customer119.Name} \nID: {customer119.ID} \nSalary: {customer119.Salary}");

              Console.WriteLine(nameOFDictionary.Count(kvp=>kvp.Value.Salary > 4500));

              if (!nameOFDictionary.ContainsKey(customer1.ID))
              {
                  nameOFDictionary.Add(customer1.ID, customer3); 
              }
              if (nameOFDictionary.ContainsKey(customer119.ID))
              {
                  Customer cust = nameOFDictionary[customer119.ID];
              }

              foreach  (int customerKeyValuePair in nameOFDictionary.Keys)
              {
                  Console.WriteLine(customerKeyValuePair);
                  //Console.WriteLine($"Name: {cus.Name} ID: {cus.ID} Salary: {cus.Salary} ");
              }
              Customer cust1;
              if (nameOFDictionary.TryGetValue(customer119.ID, out cust1))
              {
                  Console.WriteLine($"Name: {cust1.Name} ID: {cust1.ID}");
              } else { Console.WriteLine("The Key Is Not Found"); };*/

            // new customer array
            /* Customer[] customers = new Customer[3];
             customers[0] = customer1;
             customers[1] = customer2;
             customers[2] = customer3;

            Dictionary<int, Customer> nameOfDictionary2 = customers.ToDictionary(cust => cust.ID, cust => cust);
             foreach(KeyValuePair<int,Customer> customerKey in nameOfDictionary2)
             {
                 Console.WriteLine($"Keys: {customerKey.Value.Name}");
             }*/

            
            //To Convert List Into Dictionary
            /*
            List<Customer> customers = new List<Customer>();
            customers.Add(customer1);
            customers.Add(customer2);
            customers.Add(customer3);

            Dictionary<int, Customer> nameOfDictionary2 = customers.ToDictionary(cust => cust.ID, cust => cust);

            foreach (KeyValuePair<int, Customer> customerKey in nameOfDictionary2)
            {
                Console.WriteLine($"Keys: {customerKey.Value.Name}");
            }*/
        }
    }
    
}
