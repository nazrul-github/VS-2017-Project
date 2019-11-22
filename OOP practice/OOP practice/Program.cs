using System;

namespace OOP_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string emni = "new clock";

            SavingsAccount sv1 = new SavingsAccount();

            CheckingAccount chk1 = new CheckingAccount();

            chk1.Deposit(50000);
            Console.WriteLine(chk1.Balance);
            Console.WriteLine(chk1.CustomerName);
            Console.WriteLine();
            Console.WriteLine(sv1.Withdrawal(25000));
            Console.WriteLine(sv1.Balance);
            Console.WriteLine(sv1.CustomerName);
            Console.WriteLine(sv1.Balance);

            Console.ReadKey();
        }
    }
}
