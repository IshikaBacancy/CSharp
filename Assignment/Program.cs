
//Console.WriteLine("Hello, World!");
using System;
using System.Collections.Generic;
using System.Linq;


namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            

    
        
        
            static void Main(string[] args)
            {
                String input;
               
                Console.WriteLine("Welcome to Bank Management System");
                while (true)
                {
                    Console.WriteLine("\nWhat you want to do:");
                    Console.WriteLine("1. Create account");
                    Console.WriteLine("2. Enter the account number");
                    

                    object ob1 = Console.ReadLine();
                    input = Convert.ToString(ob1);

                    if (input == "1")
                    {
                        Console.WriteLine("Enter account Type :");
                        .create_account();

                    }
                    else if (input == "2")
                    {
                        Console.Write("Enter account Number :");
                        .showInfo();
                    }
                    
                    
                    Console.ReadKey();


                }

            }

        
    }

}
        }
    



