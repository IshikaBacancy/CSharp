using System;
using System.Collections.Generic;

namespace Assignment
{
    abstract class Account
    {
        public string Name { get; private set; }
        public string AccountNumber { get; private set; }
        public double Balance { get; private set; }

        public Account(string name, string accountNumber, double initialBalance)
        {
            Name = name;
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }
    }

    class Bank
    {
        private List<Account> accounts = new List<Account>();

        public void CreateAccount(string name, string accountNumber, double initialBalance)
        {
            var account = new SavingsAccount(name, accountNumber, initialBalance);
            accounts.Add(account);
            Console.WriteLine("Account created successfully.");
        }
    }

    

    class Program
    {
        static void Main()
        {
            Bank bank = new Bank();
            bank.CreateAccount("John Doe", "123456789", 1000);
        }
    }
}
