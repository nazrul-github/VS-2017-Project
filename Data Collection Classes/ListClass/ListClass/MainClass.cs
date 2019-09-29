using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListClass
{
    class MainClass
    {
       public static string yesOrNo;
        static void Main(string[] args)
        {
            
            Employee employeeOne = new Employee("Asiq", 4650, 115, 6);
            Employee employeeTwo = new Employee("Sajid", 3500, 118, 3);
            Employee employeeThree = new Employee("Zubair", 2350, 125, 2);
            Employee employeeFour = new Employee("Niyas", 8650, 135, 3);
            Employee employeeFive = new Employee("Ismail", 7665, 125, 7);
            Employee employeeSix = new Employee("Renny", 8663, 137, 8);

            //Creating a list
            List<Employee> employeesList = new List<Employee>(2);

            //Adding items to the list
            employeesList.Add(employeeOne);
            employeesList.Add(employeeTwo);
            employeesList.Add(employeeThree);
            employeesList.Add(employeeFour);
            employeesList.Add(employeeFive);
            employeesList.Insert(0, employeeSix);   

            //Retrive items from the list
            employeesList[1].Name = "Hamid";

            string employeeOneName = employeesList[1].Name;

           // Console.WriteLine(employeesList[4].YearsWorked);

            //Add items using for loop and printing the items
            /*
             List<String> customerNames = new List<string>();
            Console.WriteLine("Type 'y' to add new customer or Type 'n' to exit");
            yesOrNo = Console.ReadLine();

            while(yesOrNo != "n")
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine("Type name to add in customer");
                    customerNames.Add(Console.ReadLine());
                }
                Console.WriteLine("Name Of All The Customers");
                foreach (var item in customerNames)
                {

                    Console.WriteLine(item);
                }
                Console.WriteLine("Type 'y' to add new customer or Type 'n' to exit");
                yesOrNo = Console.ReadLine();
                
            }*/

            // to iterate through a list using for loop
         /*   for (int i = 0; i < employeesList.Count; i++)
            {
                Employee empCount = employeesList[i];
                Console.WriteLine($"ID: {empCount.ID}\nName:{empCount.Name} \nSalary: {empCount.Salary}\nYears Worked: {empCount.YearsWorked}");
                Console.WriteLine("*******************");
            }*/

            // to get a index of a particular item inside a list

            Console.WriteLine(employeesList.IndexOf(employeeOne, 2,3));



        }
    }
}
