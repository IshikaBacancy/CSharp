using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7
{
    public partial class RentalOperations
    {
        public void RentedCar(string customerName)
        {
            Console.WriteLine($"{customerName} has rented a car.");
        }
    }

    public partial class RentalOperations
    {
        public void ReturnedCar(string model)
        {
            Console.WriteLine($"The car model {model} has been returned.");
        }

        public void DisplayAvailableCars()
        {
            Console.WriteLine("Displaying available cars...");
        }
    }
    


}
