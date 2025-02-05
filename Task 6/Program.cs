using System;
using Day_6;

namespace Day_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();



            Car luxuryCar = new Car("Mercedes", "S-Class", 5000.5f, true);
            

            Car luxuryCar1 = new Car("BMW", "7 Series", 6000.2f, false);
           

            Car luxuryCar2 = new Car("Audi", "A8", 5500.8f, false);
           



            Car economyCar1 = new Car("Toyota", "Corolla", 365.7f, true);
            
            Car economyCar2 = new Car("Hyundai", "Elantra", 400.3f, false);
           
            Car economyCar3 = new Car("Honda", "Civic", 450.2f, true);
           
            Car economyCar4 = new Car("Ford", "Focus", 320.5f, true);
            
            Car economyCar5 = new Car("Nissan", "Sentra", 350.8f, false);
            

            Console.WriteLine("Luxury Cars:");
            luxuryCar.GetDetails();
            luxuryCar1.GetDetails();
            luxuryCar2.GetDetails();

            Console.WriteLine();

            Console.WriteLine("Economy Cars:");
            economyCar1.GetDetails();
            economyCar2.GetDetails();
            economyCar3.GetDetails();
            economyCar4.GetDetails();
            economyCar5.GetDetails();
        }

    }
}

