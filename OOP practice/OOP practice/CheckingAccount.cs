using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_practice
{
    class CheckingAccount:BankAccount
    {
        public CheckingAccount() : base(25000,"another account","Zahir")
        {
            Console.WriteLine("I am inside checking account");
        }


    }
}
