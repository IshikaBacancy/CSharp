using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6
{
    public class Car
    {
        public string Brand;
        public string Model;
        public float RentPerDay;
        private  bool _Available;

        public Car()
        {

        }
        public Car(string brand, string model, float rentperday, bool isAvailable)
        {
            Brand = brand;
            Model = model;
            RentPerDay = rentperday;
            _Available = isAvailable;

        }
        ~Car()
        {
            Console.WriteLine("The car object you are trying to access is removed:");
        }
        
        public void RentCar()
        {
            if(_Available) {
                _Available = false;
                Console.WriteLine("Car has been rented successfully.");
            }
            else
            {
                Console.WriteLine("Car is not available for rent.");
            }
        }

        public void ReturnCar()
        {
            if (!_Available)
            {
                _Available = true;
                Console.WriteLine("Car has been returned successfully.");
            }
            else
            {
                Console.WriteLine("Car is already available.");
            }
        }
        public bool IsAvailable
        {
            get { return _Available; }
        }

        public void GetDetails()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Rent Per Day: {RentPerDay}");
            Console.WriteLine($"Availability: {(IsAvailable ? "Available" : "Not Available")}");
            
        }

    }
}

