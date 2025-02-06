using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7
{
    interface IRentalOperations
    {


        void RentingCar(string customerName);
        void ReturningCar(string model);
        void DisplayAvailableCars();
    }

    public class RentalManager: IRentalOperations
    {
        void IRentalOperations.RentingCar(string customerName)
        {
            Console.WriteLine($"{customerName} has rented a car.");
        }

        void IRentalOperations.ReturningCar(string model)
        {
            Console.WriteLine($"The car model {model} has been returned.");
        }

        void IRentalOperations.DisplayAvailableCars()
        {
            Console.WriteLine("Displaying available cars...");
        }
    }


    
}
