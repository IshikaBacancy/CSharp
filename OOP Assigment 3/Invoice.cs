using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3_Assignment
{
    public class Invoice
    {
        private double amount;
        private ITaxCalculator taxCalculator;

        public Invoice(double amount, ITaxCalculator taxCalculator)
        {
            this.amount = amount;
            this.taxCalculator = taxCalculator;
        }

        
        public double CalculateTotal()
        {
            return amount + taxCalculator.CalculateTax(amount);
        }

       
    }

    // Implementing the Single Responsibility Principle by creating a separate class for PrintInvoice(InvoicePrinter)
    class InvoicePrinter
        {
           private Invoice invoice;

        public InvoicePrinter(Invoice invoice)
        {
            this.invoice = invoice;
        }

        public void PrintInvoice()
        {
           
            Console.WriteLine("Invoice Total (with tax): " + invoice.CalculateTotal());
        }
    }
}
