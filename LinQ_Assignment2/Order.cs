using System;
using System.Collections.Generic;

namespace LinQ_Assignment_2
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public string Product { get; set; }
        public decimal Amount { get; set; }

        public Order()
        {
            Console.WriteLine("The Order Constructor is called");
        }

        public Order(int orderId, int customerId, string product, decimal amount)
        {
            OrderId = orderId;
            CustomerId = customerId;
            Product = product;
            Amount = amount;
        }

        public static List<Order> GetOrders()
        {
            return new List<Order>
            {
                new Order { OrderId = 1, CustomerId = 101, Product = "Laptop", Amount = 899.99m },
                new Order { OrderId = 2, CustomerId = 102, Product = "Smartphone", Amount = 499.99m },
                new Order { OrderId = 3, CustomerId = 103, Product = "Tablet", Amount = 299.50m },
                new Order { OrderId = 4, CustomerId = 104, Product = "Smartwatch", Amount = 199.99m },
                new Order { OrderId = 5, CustomerId = 105, Product = "Wireless Headphones", Amount = 149.99m },
                new Order { OrderId = 6, CustomerId = 106, Product = "Gaming Console", Amount = 399.99m },
                new Order { OrderId = 7, CustomerId = 107, Product = "Bluetooth Speaker", Amount = 79.99m },
                new Order { OrderId = 8, CustomerId = 108, Product = "Mechanical Keyboard", Amount = 129.99m },
                new Order { OrderId = 9, CustomerId = 109, Product = "External Hard Drive", Amount = 89.99m },
                new Order { OrderId = 10, CustomerId = 110, Product = "Monitor", Amount = 249.99m }
            };
        }

        public static List<Order> GetOrders1()
        {
            return new List<Order>
            {
                new Order { OrderId = 1, CustomerId = 101, Product = "Laptop", Amount = 899.99m },
                new Order { OrderId = 2, CustomerId = 102, Product = "Smartphone", Amount = 499.99m },
                new Order { OrderId = 3, CustomerId = 103, Product = "Smart TV", Amount = 799.99m },  // Changed product name
                new Order { OrderId = 4, CustomerId = 104, Product = "Smartwatch", Amount = 199.99m },
                new Order { OrderId = 5, CustomerId = 105, Product = "Wireless Headphones", Amount = 149.99m },
                new Order { OrderId = 6, CustomerId = 106, Product = "Gaming Console", Amount = 399.99m },
                new Order { OrderId = 7, CustomerId = 107, Product = "Bluetooth Speaker", Amount = 79.99m },
                new Order { OrderId = 8, CustomerId = 108, Product = "Mechanical Keyboard", Amount = 129.99m },
                new Order { OrderId = 9, CustomerId = 109, Product = "External SSD", Amount = 89.99m },  // Changed product name
                new Order { OrderId = 10, CustomerId = 110, Product = "Curved Monitor", Amount = 249.99m }

            };
        }
    }
}
