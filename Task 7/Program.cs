using System;

namespace Day_7
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Vehicle vehicle = new Vehicle();
            //vehicle.Rent();

            Vehicle vehicle1 = new LuxuryCar();
            vehicle1.Rent();

            Vehicle vehicle2 = new EconomyCar();
            vehicle2.Rent();

            //Method overloading
            MethodOverloading rent = new MethodOverloading();
            rent.RentCar("ishika");
            rent.RentCar("ishika", 15);

            LuxuryCar luxuryCar = new LuxuryCar();
            luxuryCar.CalculateRentCost();



            EconomyCar economyCar = new EconomyCar();
            economyCar.CalculateRentCost();

            // Implementing Rental Service in Car and creating car object 
            Car car = new Car("ford","mustang");
            car.GetRentalType();

            // Sealed Class object
            RentalDatabase rentalDB = new RentalDatabase();

            rentalDB.LogTransaction("Car rented");
            
            Console.WriteLine("\nStored Transactions:");
            rentalDB.DisplayTransactions();

            //Interface RentalManager object
            IRentalOperations rentalManager = new RentalManager();

            rentalManager.RentingCar("John Doe");
            rentalManager.ReturningCar("Toyota");
            rentalManager.DisplayAvailableCars();

            //partial class
            RentalOperations rentalOps = new RentalOperations();

            rentalOps.RentedCar("Ram Kapoor");
            rentalOps.ReturnedCar("Ford");
            rentalOps.DisplayAvailableCars();
         }
    }
}
