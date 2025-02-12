using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Assignment_2
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name {  get; set; }
        public string City {  get; set; }

        public Customer()
        {
            Console.WriteLine("The Customer Constructor is called");
        }

        public Customer(int customerId, string name, string city)
        {
            CustomerId = customerId;
            Name = name;
            City = city;
        }

        public static List<Customer> GetCustomerDetails()
        {
            return new List<Customer> {

                new Customer { CustomerId = 101, Name = "Alice Johnson", City = "New York" },
                new Customer { CustomerId = 102, Name = "Bob Smith", City = "Los Angeles" },
                new Customer { CustomerId = 103, Name = "Charlie Davis", City = "Chicago" },
                new Customer { CustomerId = 104, Name = "David Wilson", City = "Houston" },
                new Customer { CustomerId = 105, Name = "Emma Brown", City = "Phoenix" },
                new Customer { CustomerId = 106, Name = "Frank White", City = "San Diego" },
                new Customer { CustomerId = 107, Name = "Grace Miller", City = "Dallas" },
                new Customer { CustomerId = 108, Name = "Henry Moore", City = "San Francisco" },
                new Customer { CustomerId = 109, Name = "Isabella Taylor", City = "Miami" },
                new Customer { CustomerId = 110, Name = "Jack Anderson", City = "Seattle" }
            };
        }
    }
}
