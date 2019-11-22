using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_practice
{
    class BankAccount
    {
        public   BankAccount(double balance, string acoountNo, string customerName)
        {
            Balance = balance;
            AcoountNo = acoountNo;
            CustomerName = customerName;
        }



        public double Balance { get; private set; }
        public string AcoountNo { get; set; }
        public string CustomerName { get; set; }

        public string Deposit(double amount)
        {
            Balance += amount;
            return "Deposit successful";
        }
        public string Withdrawal(double amount)
        {
            Balance -= amount;
            return "Withdraw successful";
        }


    }
}
