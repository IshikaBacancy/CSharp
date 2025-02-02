using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practice_1
{
    public class Account
    {


        // properties
        public string Name { get; set; }
        public int AccountNumber { get; set; }
        public int InitialBalance { get; set; }

        public List<Transaction> TransactionHistory { get; set; }

        // Constructor 
        public Account(string name, int accountNumber, int initialBalance)
        {
            Name = name;
            AccountNumber = accountNumber;
            InitialBalance = initialBalance;
            TransactionHistory = new List<Transaction>();
            TransactionHistory.Add(new Transaction("Account Creation", 0, initialBalance));
        }

        //deposit method
        public void Deposit(int amount)
        {
            if(amount <= 0)
            {
                Console.WriteLine("deposit amount must be greater than zero.");
                return;
            }
            InitialBalance += amount;

            TransactionHistory.Add(new Transaction("Deposit", amount, InitialBalance));
            Console.WriteLine($"Successfully deposited {amount}. New Balance: {InitialBalance}");
        }

        // Withdrawal method
        public void Withdraw(int amount, int MinimumBalance = 500)
        {
            if(amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be greater than zero");
                return;
            }
            if(InitialBalance - amount < MinimumBalance)
            {
                Console.WriteLine("Cannot withdraw {amount}. MinimumBalance must be maintained.");
                return;

            }
            InitialBalance -= amount;
            TransactionHistory.Add(new Transaction("Withdrawal", amount, InitialBalance));
            Console.WriteLine($"Successfully withdrew {amount}. New Balance: {InitialBalance}");
        }

        
        public void ViewTransactionHistory()
        {
            Console.WriteLine($"Transaction History for {Name} {AccountNumber}:");
            foreach (var Transaction in TransactionHistory)
            {
                Transaction.DisplayTransactionInfo();
            }
        }
        


        public static List<Account> bankaccounts = new List<Account>();

        public static void AddAccount(Account account)
        {
            bankaccounts.Add(account);
        }

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Name: {Name}, Account Number: {AccountNumber}, Initial Balance: {InitialBalance}");
        }

       
        public static void ViewAllAccounts()
        {
            Console.WriteLine("List of All Bank Accounts:");
            foreach (var account in bankaccounts)
            {
                Console.WriteLine($"Name: {account.Name}, Account Number: {account.AccountNumber}, Balance: {account.InitialBalance}");
            }


        }


        

        public static void SortAccountsByBalance(bool ascending)
        {
            if (ascending)
            {
                bankaccounts = bankaccounts.OrderBy(acc => acc.InitialBalance).ToList();
            }
            else
            {
                bankaccounts = bankaccounts.OrderByDescending(acc => acc.InitialBalance).ToList();
            }
        }

        public static void ViewAccountByNumber(int accountNumber)




        {
            var account = bankaccounts.FirstOrDefault(acc => acc.AccountNumber == accountNumber);
            if (account != null)
            {
                account.DisplayAccountInfo();
            }
            else
            {
                Console.WriteLine($"Account with number {accountNumber} not found.");
            }
        }

        public static int GetTotalBankBalance()
        {
            int totalBalance = bankaccounts.Sum(acc => acc.InitialBalance);
            return totalBalance;
        }

    }
}
