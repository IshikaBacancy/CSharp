using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_7
{
    public class Vehicle
    {
        public string Brand;
        public string Model;

        public Vehicle()
        {
            //Console.WriteLine("The base class constructor is called");
        }

        public Vehicle(string brand, string model)
        {
            Brand = brand;
            Model = model;
        }

        public virtual void Rent()
        {
            Console.WriteLine("The Rent is:");
        }

        public virtual void DisplayCarDetails()
        {
            Console.WriteLine("The Car details is:");
            Console.WriteLine($"Brand: {Brand}, Model: {Model}");
        }


        public virtual void CalculateRentCost()
        {
            Console.WriteLine("The new Calculated rent cost is:");
        }


    }

    public class LuxuryCar : Vehicle
    {
        public int HigherRent;

        public LuxuryCar()
        {

        }

        public LuxuryCar(string brand, string model, int higherRent)
            : base(brand, model)
        {
            HigherRent = higherRent;
            Console.WriteLine($"LuxuryCar constructor is called. Higher Rent: {HigherRent}");
        }

        public override void Rent()
        {
            base.Rent();
            Console.WriteLine("The Highest Rent is: +HigherRent");
        }

        public override void CalculateRentCost()
        {
            Console.WriteLine("The calculated rent cost for luxury car is:");
        }

        public override void DisplayCarDetails()
        {
            base.DisplayCarDetails();
            Console.WriteLine("$\"Luxury Car Specific Details: Budget Rent: {BudgetRent}");
        }
    }


    public class EconomyCar : Vehicle
    {
        public int BudgetRent;

        public EconomyCar()
        {

        }

        public EconomyCar(string brand, string model, int budgetRent)
            : base(brand, model)
        {
            BudgetRent = budgetRent;
            Console.WriteLine($"EconomyCar constructor is called. Budget Rent: {BudgetRent}");
        }

        public override void Rent()
        {
            base.Rent();
            Console.WriteLine("The Budget Rent is: +BudgetRent");
        }

        public override void CalculateRentCost()
        {
            Console.WriteLine("The new Calculated rent cost for budget friendly is:");
        }

        public override void DisplayCarDetails()
        { 
                base.DisplayCarDetails();
                Console.WriteLine("$\"Economy Car Specific Details: Budget Rent: {BudgetRent}");
        }
    }
    public class MethodOverloading
    {
        public string customerName;
        public int rentalDays;

        public void RentCar(string customerName)
        {
            Console.WriteLine("The name of the customer who took rent is" +(customerName));
        }

        public void RentCar(string customerName, int rentalDays)
        {
            Console.WriteLine("The customer name who took rent is" +(customerName));
            Console.WriteLine("The no of days it was on rent:" +(rentalDays));
        }
    }   


}
