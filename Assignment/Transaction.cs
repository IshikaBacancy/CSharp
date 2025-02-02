using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_1
{
    public class Transaction
    {
        
        public DateTime TransactionDate { get; set; }
        public string Type { get; set; }
        public double Amount {  get; set; }
        public double BalanceAfterTransaction { get; set; }

        public Transaction(string type, double amount, double balanceAfterTransaction)
        {
            TransactionDate = DateTime.Now;
            Type = type;
            Amount = amount;
            BalanceAfterTransaction = balanceAfterTransaction;

        }
        public void DisplayTransactionInfo()
        {
            Console.WriteLine($"{TransactionDate} | {Type} | Amount: {Amount} | Balance: {BalanceAfterTransaction}");
        }
    }
}
