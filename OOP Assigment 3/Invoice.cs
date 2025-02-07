using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3_Assignment
{
    //public class Invoice
    //{
    //    private double _amount;

    //    public Invoice(double amount)
    //    {
    //        this._amount = amount;
    //    }

    //    public double CalculateTotal()
    //    {
    //        return _amount * 1.18;
    //    }

    //    // Creating a new class for invoice printer to follow Single Responsibility Principle
    //    public class InvoicePrinter
    //    {
    //        public void PrintInvoice(Invoice invoice)
    //        {
    //            Console.WriteLine($"Invoice Total: {invoice.CalculateTotal()}");
    //        }
    //    }


    //}

   

    // Modify the Invoice class to use ITaxCalculator
    public class Invoice
    {
        private double amount;
        private ITaxCalculator taxCalculator;

        public Invoice(double amount, ITaxCalculator taxCalculator)
        {
            this.amount = amount;
            this.taxCalculator = taxCalculator;
        }

        // Calculate total using the specified tax calculator
        public double CalculateTotal()
        {
            return amount + taxCalculator.CalculateTax(amount);
        }

        public void PrintInvoice()
        {
            Console.WriteLine("Invoice Total: " + CalculateTotal());
        }
    }
}
