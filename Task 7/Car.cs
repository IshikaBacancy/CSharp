using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7
{
    public class Car: RentalService
    {
        public string Model { get; set; }
        public string Color { get; set; }

        public Car(string model, string color)
        {
            Model = model;
            Color = color;
           
        }
        public override void GetRentalType()
        {
            Console.WriteLine($"This is a Car Rental Service");
            Console.WriteLine($"Vehicle Details:{Color} {Model}");
        }
    }
}
