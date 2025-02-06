using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Day_7
{
    sealed class RentalDatabase
    {
        private List<string> transactions = new List<string>();

        public void LogTransaction(string message)
        {
            //transactions.Add(message);
            Console.WriteLine($"Availability of car: {message}");
        }

        public void DisplayTransactions()
        {
            Console.WriteLine("Rental Database Stored Transactions:");
            foreach (var transaction in transactions)
            {
                Console.WriteLine(transaction);
            }
        }
    }
}
