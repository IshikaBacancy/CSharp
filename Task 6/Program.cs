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
            luxuryCar.GetRentCar();
            luxuryCar.SetRentCar("Model A");
            luxuryCar.GetReturnCar();
            luxuryCar.SetReturnCar("Model A");




            Car luxuryCar1 = new Car("BMW", "7 Series", 6000.2f, false);
            luxuryCar1.GetRentCar();
            luxuryCar.SetRentCar("Model B");
            luxuryCar.GetReturnCar();
            luxuryCar.SetReturnCar("Model C");


            Car luxuryCar2 = new Car("Audi", "A8", 5500.8f, false);
            luxuryCar2.GetRentCar();
            luxuryCar.SetRentCar("Model C");
            luxuryCar.GetReturnCar();
            luxuryCar.SetReturnCar("Model C");



            Car economyCar1 = new Car("Toyota", "Corolla", 365.7f, true);
            economyCar1.GetRentCar();
            economyCar1.SetRentCar("Model D");
            economyCar1.GetReturnCar();
            economyCar1.SetReturnCar("Model D");


            Car economyCar2 = new Car("Hyundai", "Elantra", 400.3f, false);
            economyCar2.GetRentCar();
            economyCar2.SetRentCar("Model E");
            economyCar2.GetReturnCar();
            economyCar2.SetReturnCar("Model E");

            Car economyCar3 = new Car("Honda", "Civic", 450.2f, true);
            economyCar3.GetRentCar();
            economyCar3.SetRentCar("Model F");
            economyCar3.GetReturnCar();
            economyCar3.SetReturnCar("Model F");

            Car economyCar4 = new Car("Ford", "Focus", 320.5f, true);
            economyCar4.GetRentCar();
            economyCar4.SetRentCar("Model G");
            economyCar4.GetReturnCar();
            economyCar4.SetReturnCar("Model G");

            Car economyCar5 = new Car("Nissan", "Sentra", 350.8f, false);
            economyCar5.GetRentCar();
            economyCar5.SetRentCar("Model H");
            economyCar5.GetReturnCar();
            economyCar5.SetReturnCar("Model H");


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
