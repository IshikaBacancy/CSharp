

using System;

using System.Linq;

namespace Practice_1
{
    class Program
    {
        static void Main(string[] args)
        {

            bool exit = false;
            //while(!exit)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Bank Menu:");
            //    Console.WriteLine("1. Create a new bank account");
            //    Console.WriteLine("2. View all bank accounts");
            //    Console.WriteLine("3. Search accounts by name");
            //    Console.WriteLine("4. Sort accounts by balance (Ascending/Descending)");
            //    Console.WriteLine("5. Deposit money into an account");
            //    Console.WriteLine("6. Withdraw money from an account");
            //    Console.WriteLine("7. View transaction history of an account");
            //    Console.WriteLine("8. View details of a specific account");
            //    Console.WriteLine("9. Get total bank balance");
            //    Console.WriteLine("10. Exit");

            //    Console.Write("Select an option: ");
            //    string choice = Console.ReadLine();

            //    switch (choice)
            //    {
            //        case "1":
            //           Account.AddAccount();
            //            break;

            //        case "2":
            //            Account.ViewAllAccounts();
            //            break;

            //        case "3":
            //            Account.SearchAccountByName();
            //            break;

            //        case "4":
            //            SortAccountsByBalance();
            //            break;

            //        case "5":
            //            Deposit();
            //            break;

            //        case "6":
            //            Withdraw();
            //            break;

            //        case "7":
            //            ViewTransactionHistory();
            //            break;

            //        case "8":
            //            ViewAccountDetails();
            //            break;

            //        case "9":
            //            Console.WriteLine($"Total bank balance: {Account.GetTotalBankBalance()}");
            //            break;

            //        case "10":
            //            exit = true;
            //            break;

            //        default:
            //            Console.WriteLine("Invalid option. Try again.");
            //            break;
            //    }

            //}
            Account account1 = new Account("Ishika Raiyani", 21890, 100000);
            Account account2 = new Account("Jane Smith", 21980, 500000);
            Account account3 = new Account("Priya Rajan", 123456, 100000);

            Account.AddAccount(account1);
            Account.AddAccount(account2);
            Account.AddAccount(account3);

            
            Console.WriteLine("\nViewing account details for account number 21890:");
            Account.ViewAccountByNumber(21890);

            Console.WriteLine($"\nTotal bank balance: {Account.GetTotalBankBalance()}");

            account1.DisplayAccountInfo();
            account2.DisplayAccountInfo();
            account3.DisplayAccountInfo();

            account1.Deposit(1000);
            account2.Deposit(1000);

            account1.Withdraw(2000);
            account2.Withdraw(45000);

            account1.ViewTransactionHistory();
            account2.ViewTransactionHistory();

            foreach (var account in Account.bankaccounts)
            {
                Console.WriteLine($"Account for {account.Name} with Account Number {account.AccountNumber} has an Initial Balance of {account.InitialBalance}");
            }

            Account.ViewAllAccounts();



            
            Console.WriteLine("\nSorting accounts by balance in ascending order...");
            Account.SortAccountsByBalance(true);
            Account.ViewAllAccounts();

            // Sorting accounts by balance (descending)
            Console.WriteLine("\nSorting accounts by balance in descending order...");
            Account.SortAccountsByBalance(false);
            Account.ViewAllAccounts();


        }


    }

}
