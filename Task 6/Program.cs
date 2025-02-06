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
            luxuryCar.RentCar();
            luxuryCar.ReturnCar();
            
            Car luxuryCar1 = new Car("BMW", "7 Series", 6000.2f, true);
            luxuryCar1.RentCar();
            luxuryCar1.ReturnCar();

            Car luxuryCar2 = new Car("Audi", "A8", 5500.8f, false);
            luxuryCar2.RentCar();
            luxuryCar2.ReturnCar();

            Car economyCar1 = new Car("Toyota", "Corolla", 365.7f, true);
            economyCar1.RentCar();
            economyCar1.ReturnCar();

            Car economyCar2 = new Car("Hyundai", "Elantra", 400.3f, false);
            economyCar2.RentCar();
            economyCar2.ReturnCar();

            Car economyCar3 = new Car("Honda", "Civic", 450.2f, true);
            economyCar3.RentCar();
            economyCar3.ReturnCar();

            Car economyCar4 = new Car("Ford", "Focus", 320.5f, true);
            economyCar4.RentCar();
            economyCar4.ReturnCar();

            Car economyCar5 = new Car("Nissan", "Sentra", 350.8f, false);
            economyCar5.RentCar();
            economyCar5.ReturnCar();

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
