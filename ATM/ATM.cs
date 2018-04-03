using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ATM
{
    public class ATM
    {
        // TODO: work on better way to store initial balance for ATM account

        public static double balance = 1000;

        public ATM()
        {
        }

        public double getBalance()
        {
            return balance;
        }

        public void withdraw(double amount)
        {
            balance = balance - amount;
        }

        public void deposit(double amount)
        {
            balance = balance + amount;
        }
    }
}