using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Assignment_2

{
    public class LinQoperations
    {
        //Write a LINQ query to fetch the CustomerId, Customer Name, OrderId, and Product using an inner join.
        public void MethodGetInnerJoin()
        {

            List<Customer> customers = Customer.GetCustomerDetails();
            List<Order> orders = Order.GetOrders();

            var customerOrders = customers.Join(
                orders,
                customer => customer.CustomerId,
                order => order.CustomerId,
                (customer, order) => new
                {
                    customer.CustomerId,
                    customer.Name,
                    order.OrderId,
                    order.Product
                }).ToList();

            foreach (var item in customerOrders)
            {
                Console.WriteLine($"Customer ID: {item.CustomerId}, Name: {item.Name}, Order ID: {item.OrderId}, Product: {item.Product}");
            }

        }

        //Write a LINQ query to perform a Group Join, listing customers along with their orders.
        public void MethodGroupJoin(){
            List<Customer> customers = Customer.GetCustomerDetails();
            List<Order> orders = Order.GetOrders();

            var GroupJoin = customers.GroupJoin(
                 orders,
                 customer => customer.CustomerId,
                 order => order.CustomerId,
                 (customer, customerOrders) => new
                 {
                     customer.CustomerId,
                     customer.Name,
                     Orders = customerOrders.Select(o => new
                     {
                         o.CustomerId,
                         o.Product
                     }).ToList()

                 }).ToList();

            foreach (var customer in GroupJoin)
            {
                Console.WriteLine($"CustomerId: {customer.CustomerId}, Name: {customer.Name}");
                if (customer.Orders.Any())
                {
                    foreach (var order in customer.Orders)
                    {
                        Console.WriteLine($"  -> OrderId: {order.CustomerId}, Product: {order.Product}");
                    }
                }
                else
                {
                    Console.WriteLine("  -> No Orders");
                }
            }
        }

        //Write a LINQ query to perform a Cross Join, generating all possible combinations of Customers and Orders.
        public void MethodCrossJoinPossibleCombinationsofCustomersAndOrders()
        {
            List<Customer> customers = Customer.GetCustomerDetails();
            List<Order> orders = Order.GetOrders();
            
            var CrossJoin = customers.SelectMany(
                customers=>orders,
                (customer, order) => new
                {
                    
                    customer.Name,
                    order.Product
                }).ToList();
            foreach (var item in CrossJoin)
            {
                Console.WriteLine($"Name: {item.Name},Product: {item.Product}");
            }


        }

        //Write a LINQ query to perform a Left Outer Join, listing all customers along with their orders (even if they don’t have any orders).
        public void MethodLeftOuterJoin()
        {
            List<Customer> customers = Customer.GetCustomerDetails();
            List<Order> orders = Order.GetOrders();

            var leftOuterJoin = customers.GroupJoin(
                orders,
                customer => customer.CustomerId,  
                order => order.CustomerId,        
                (customer, customerOrders) => new 
                {
                    customer.CustomerId,
                    customer.Name,
                    Orders = customerOrders.DefaultIfEmpty(new Order { OrderId = 0, Product = "No Orders" })
                }).SelectMany(
                    customerWithOrders => customerWithOrders.Orders, 
                    (customerWithOrders, order) => new
                    {
                        customerWithOrders.CustomerId,
                        customerWithOrders.Name,
                        order.OrderId,
                        order.Product
                    }).ToList();

           
            foreach (var item in leftOuterJoin)
            {
                Console.WriteLine($"CustomerId: {item.CustomerId}, Name: {item.Name}, OrderId: {item.OrderId}, Product: {item.Product}");
            }
        }

        //Write a LINQ query to group orders by CustomerId, displaying the total amount spent by each customer.
        public void MethodGroupOrderByCustomerId()
        {
            List<Customer> customers = Customer.GetCustomerDetails();
            List<Order> orders = Order.GetOrders();

            var GroupOrders = orders.GroupBy(order => order.CustomerId)
                .Select(group=> new
                {
                    CustomerId = group.Key,
                    TotalSpent = group.Sum(order => order.Amount)
                }).ToList();

            Console.WriteLine("Total amount spent by each customer:");
            foreach (var customer in GroupOrders)
            {
                Console.WriteLine($"CustomerId: {customer.CustomerId}, Total Spent: ${customer.TotalSpent}");
            }
        }

        //Use ToLookup to create a dictionary-like structure where CustomerId is the key and orders are the values.
        public void MethodOrderLookUpByCustomer()
        {
            List<Customer> customers = Customer.GetCustomerDetails();
            List<Order> orders = Order.GetOrders();
            var orderLookup = orders.ToLookup(order => order.CustomerId);

            Console.WriteLine("Orders grouped by customerId using Tolookup");

            foreach (var customerOrders in orderLookup)
            {
                Console.WriteLine($"CustomerId: {customerOrders.Key}");

                foreach (var order in customerOrders)
                {
                    Console.WriteLine($"   OrderId: {order.OrderId}, Product: {order.Product}, Amount: ${order.Amount}");
                }
            }
        }


        public void MethodGroupByCountOfOrders()
        {
            List<Customer> customers = Customer.GetCustomerDetails();
            List<Order> orders = Order.GetOrders();

            var customerOrderStats = orders
        .GroupBy(order => order.CustomerId) 
        .Select(group => new
        {
            CustomerId = group.Key,  
            OrderCount = group.Count(),  
            MaxOrderAmount = group.Max(order => order.Amount) 
        }).ToList();

            
            Console.WriteLine("Customer Order Statistics:");
            foreach (var customer in customerOrderStats)
            {
                Console.WriteLine($"CustomerId: {customer.CustomerId}, Order Count: {customer.OrderCount}, Highest Order Amount: ${customer.MaxOrderAmount}");
            }
        }

        //public void MethodCustomerNestedQuery()
        //{
        //    List<Customer> customers = Customer.GetCustomerDetails();
        //    List<Order> orders = Order.GetOrders();
        //    var customerNames = customers
        //   .Where(customer => customer.Orders
        //    .Any(order => order.Price > 500))
        //.Select(customer => customer.Name);

        //    // Output the customer names
        //    foreach (var name in customerNames)
        //    {
        //        Console.WriteLine(name);
        //    }
        //}

        public void MethodUniqueCitiesCustomers()
        {
            List<Customer> customers = Customer.GetCustomerDetails();
            var uniqueCities = customers
           .Select(customer => customer.City)  
           .Distinct()  
           .ToList();  

            
            foreach (var city in uniqueCities)
            {
                Console.WriteLine(city);
            }
        }

        public void MethodProductsDifferentOrderCombinedCollections()
        {
            //List<Customer> customers = Customer.GetCustomerDetails();
            List<Order> orders = Order.GetOrders();
            List<Order> orders1 = Order.GetOrders1();

            var combinedUniqueProducts = orders1
            .Select(order => order.Product)
            .Concat(orders1.Select(order => order.Product))
            .Distinct()  
            .ToList();   
            
            foreach (var product in combinedUniqueProducts)
            {
                Console.WriteLine(product);
            }


        }

        public void MethodProductsIntersectionOrderCollections()
        {
            List<Order> orders = Order.GetOrders();  
            List<Order> orders1 = Order.GetOrders1(); 

            var commonProducts = orders
                .Select(order => order.Product)   
                .Intersect(orders1.Select(order => order.Product)) 
                .ToList(); 

            
            Console.WriteLine("Common Products Between Two Order Collections:");
            foreach (var product in commonProducts)
            {
                Console.WriteLine(product);
            }

        }

        public void MethodProductsExceptOrderCollections()
        {
            List<Order> orders = Order.GetOrders();   
            List<Order> orders1 = Order.GetOrders1(); 

            var uniqueProducts = orders
                .Select(order => order.Product)   
                .Except(orders1.Select(order => order.Product)) 
                .ToList(); 

            
            Console.WriteLine("Products in the first collection but not in the second:");
            foreach (var product in uniqueProducts)
            {
                Console.WriteLine(product);
            }
        }

        public void GetDistinctProducts()
        {
            List<string> products = new List<string>
            {
             "Laptop", "Smartphone", "Tablet", "Laptop", "Smartwatch",
             "Tablet", "Smartphone", "Monitor", "Laptop", "Smartwatch"
            };

            var distinctProducts = products.Distinct().ToList(); 

            Console.WriteLine("Distinct Products:");
            foreach (var product in distinctProducts)
            {
                Console.WriteLine(product);
            }
        }

        public void DeferredExecutionExample()
        {
            List<Customer> customers = Customer.GetCustomerDetails();

           
            var query = customers.Where(c => c.City == "New York");

            Console.WriteLine("Query created but NOT executed yet.");

            
            Console.WriteLine("Executing Query:");
            foreach (var customer in query)
            {
                Console.WriteLine($"{customer.CustomerId} - {customer.Name} - {customer.City}");
            }
        }

        public void ImmediateExecutionExample()
        {
            List<Order> orders = Order.GetOrders();

            // LINQ query with immediate execution
            var query = orders.Where(o => o.Amount > 500).ToList(); // Executes immediately

            Console.WriteLine("Query executed immediately.");

            // Iterating over results (already stored in memory)
            Console.WriteLine("Displaying Orders Above $500:");
            foreach (var order in query)
            {
                Console.WriteLine($"{order.OrderId} - {order.Product} - ${order.Amount}");
            }
        }





    }
}
