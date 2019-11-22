using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_practice
{
    class SavingsAccount:BankAccount
    {
        public SavingsAccount():base(45000,"robin's account","robin")
        {
            Console.WriteLine("I am inside bank account");
        }
    }
}
