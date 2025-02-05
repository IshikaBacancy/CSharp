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
        private readonly bool Available;

        public Car()
        {
            
        }
        public Car(string brand, string model, float rentperday, bool isAvailable){
            Brand = brand;
            Model = model;
            RentPerDay = rentperday;
            Available = isAvailable;

        }
        ~Car()
        {
            Console.WriteLine("The car object you are trying to access is removed:");
        }
      public string RentCar 
      {  get; set;
            
      }
      public string ReturnCar
      { get; set; 
        
      }

      

      public bool IsAvailable
      { 
            get {  return Available;  } 
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

