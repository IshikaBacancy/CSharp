using System;

namespace OOP_3_Assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ITaxCalculator standardTax = new StandardTaxCalculator();
            Invoice invoice = new Invoice(1000, standardTax);
            InvoicePrinter printer = new InvoicePrinter(invoice);

            printer.PrintInvoice();


        }
    }
}
