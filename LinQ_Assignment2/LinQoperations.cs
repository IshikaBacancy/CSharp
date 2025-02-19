using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
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

        public void QueryInnerJoin()
        {
            List<Customer> customers = Customer.GetCustomerDetails();
            List<Order> orders = Order.GetOrders();

            var customerOrders = (from customer in customers
                                  join order in orders
                                  on customer.CustomerId equals order.CustomerId
                                  select new
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

        public void QueryGroupJoin()
        {
            List<Customer> customers = Customer.GetCustomerDetails();
            List<Order> orders = Order.GetOrders();

            var groupJoin = (from customer in customers
                             join order in orders
                             on customer.CustomerId equals order.CustomerId into customerOrders
                             select new
                             {
                                 customer.CustomerId,
                                 customer.Name,
                                 Orders = customerOrders.Select(o => new
                                 {
                                     o.CustomerId,
                                     o.Product
                                 }).ToList()
                             }).ToList();

            foreach (var customer in groupJoin)
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
        public void MethodCrossJoinPossibleCombinationsOfCustomersAndOrders()
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

        public void QueryCrossJoinPossibleCombinationsOfCUstomersAndOrders()
        {
            List<Customer> customers = Customer.GetCustomerDetails();
            List<Order> orders = Order.GetOrders();

            var crossJoin = (from customer in customers
                             from order in orders
                             select new
                             {
                                 customer.Name,
                                 order.Product
                             }).ToList();

            foreach (var item in crossJoin)
            {
                Console.WriteLine($"Name: {item.Name}, Product: {item.Product}");
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

            Console.WriteLine("By Method:The result of Left Outer Join is:");
            foreach (var item in leftOuterJoin)
            {
                Console.WriteLine($"CustomerId: {item.CustomerId}, Name: {item.Name}, OrderId: {item.OrderId}, Product: {item.Product}");
            }
        }

        public void QueryLeftOuterJoin()
        {
            List<Customer> customers = Customer.GetCustomerDetails();
            List<Order> orders = Order.GetOrders();
            var leftOuterJoin = (from customer in customers
                                 join order in orders
                                 on customer.CustomerId equals order.CustomerId into customerOrders
                                 from order in customerOrders.DefaultIfEmpty(new Order { OrderId = 0, Product = "No Orders" })
                                 select new
                                 {
                                     customer.CustomerId,
                                     customer.Name,
                                     order.OrderId,
                                     order.Product
                                 }).ToList();
            Console.WriteLine("By Query: The result of Left Outer Join is:");
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

            Console.WriteLine("By Method: Total amount spent by each customer:");
            foreach (var customer in GroupOrders)
            {
                Console.WriteLine($"CustomerId: {customer.CustomerId}, Total Spent: ${customer.TotalSpent}");
            }
        }

        public void QueryGroupOrderByCustomerId()
        {
            List<Customer> customers = Customer.GetCustomerDetails();
            List<Order> orders = Order.GetOrders();

            var GroupOrders = (from order in orders
                               group order by order.CustomerId into groupedOrders
                               select new
                               {
                                   CustomerId = groupedOrders.Key,
                                   TotalSpent = groupedOrders.Sum(order => order.Amount)
                               }).ToList();

            Console.WriteLine("By Query:Total amount spent by each customer:");
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

            Console.WriteLine("By Method: Orders grouped by customerId using Tolookup");

            foreach (var customerOrders in orderLookup)
            {
                Console.WriteLine($"CustomerId: {customerOrders.Key}");

                foreach (var order in customerOrders)
                {
                    Console.WriteLine($"   OrderId: {order.OrderId}, Product: {order.Product}, Amount: ${order.Amount}");
                }
            }
        }

        public void QueryOrderLookUpByCustomer()
   {
      List<Customer> customers = Customer.GetCustomerDetails();
      List<Order> orders = Order.GetOrders();

    // Using query syntax to group orders by CustomerId and convert it into a Lookup
    var orderLookup = (from order in orders select order
                       ).ToLookup(x => x.CustomerId);

    Console.WriteLine("By Query: Orders grouped by customerId using ToLookup");
    foreach (var customerOrders in orderLookup)
    {
        Console.WriteLine($"CustomerId: {customerOrders.Key}");

        foreach (var order in customerOrders)
        {
            Console.WriteLine($"   OrderId: {order.OrderId}, Product: {order.Product}, Amount: ${order.Amount}");
        }
     }
  }  

        //Modify the GroupBy query to display the CustomerId, count of orders, and the highest order amount per customer.
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

            
            Console.WriteLine("By Method:Customer Order Statistics:");
            foreach (var customer in customerOrderStats)
            {
                Console.WriteLine($"CustomerId: {customer.CustomerId}, Order Count: {customer.OrderCount}, Highest Order Amount: ${customer.MaxOrderAmount}");
            }
        }

        public void QueryGroupByCountOfOrders()
        {
            List<Customer> customers = Customer.GetCustomerDetails();
            List<Order> orders = Order.GetOrders();

            var customerOrderStats = (from order in orders
                                      group order by order.CustomerId into orderGroup
                                      select new
                                      {
                                          CustomerId = orderGroup.Key,
                                          OrderCount = orderGroup.Count(),
                                          MaxOrderAmount = orderGroup.Max(order => order.Amount)
                                      }).ToList();

            Console.WriteLine("By Query:Customer Order Statistics:");
            foreach (var customer in customerOrderStats)
            {
                Console.WriteLine($"CustomerId: {customer.CustomerId}, Order Count: {customer.OrderCount}, Highest Order Amount: ${customer.MaxOrderAmount}");
            }

        }

        //Fetch customer names who have placed at least one order above $500 using a nested LINQ query.
        public void MethodCustomerNestedQuery()
        {
            List<Customer> customers = Customer.GetCustomerDetails();
            List<Order> orders = Order.GetOrders();

            var highValueCustomers = customers
                .Where(customer => orders
                    .Any(order => order.CustomerId == customer.CustomerId && order.Amount > 500))
                .Select(customer => customer.Name)
                .ToList();

            
            Console.WriteLine("By Method:Customers with at least one order above $500:");
           
            foreach (var name in highValueCustomers)
            {
                Console.WriteLine(name);
            }

        }

        public void QueryCustomerNestedQuery()
        {
            List<Customer> customers = Customer.GetCustomerDetails();
            List<Order> orders = Order.GetOrders();

            var highValueCustomers = (from customer in customers
                                      where (from order in orders
                                             where order.CustomerId == customer.CustomerId && order.Amount > 500
                                             select order).Any()
                                      select customer.Name).ToList();

            Console.WriteLine("By Query:Customers with at least one order above $500:");

            foreach (var name in highValueCustomers)
            {
                Console.WriteLine(name);
            }

        }

        //Get a list of unique cities where customers live.
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

        public void QueryUniqueCitiesCustomers()
        {
            List<Customer> customers = Customer.GetCustomerDetails();
            var uniqueCities = (from customer in customers
                                select customer.City)
                               .Distinct()
                               .ToList();

            foreach (var city in uniqueCities)
            {
                Console.WriteLine(city);
            }

        }

        //Get a combined list of products from two different order collections.
        public void MethodProductsDifferentOrderCombinedCollections()
        {
            
            List<Order> orders = Order.GetOrders();
            List<Order> orders1 = Order.GetOrders1();

            var combinedUniqueProducts = orders
            .Select(order => order.Product)
            .Union(orders1.Select(order => order.Product)
            .ToList());

            Console.WriteLine("By Method: Union of all the products of both the order collections");
            foreach (var product in combinedUniqueProducts)
            {
                Console.WriteLine(product);
            }


        }

        public void QueryProductsDifferentOrderCombinedCollections()
        {
            List<Order> orders = Order.GetOrders();
            List<Order> orders1 = Order.GetOrders1();

            var combinedUniqueProducts = (from order in orders
                                          select order.Product)
                                         .Union(from order in orders1 select order.Product).ToList();

            Console.WriteLine("By Query:Union of all the products of both the order collections");
            foreach (var product in combinedUniqueProducts)
            {
                Console.WriteLine(product);
            }


        }

        //Find intersection products between two different order collections.
        public void MethodProductsIntersectionOrderCollections()
        {
            List<Order> orders = Order.GetOrders();  
            List<Order> orders1 = Order.GetOrders1(); 

            var commonProducts = orders
                .Select(order => order.Product)   
                .Intersect(orders1.Select(order => order.Product)) 
                .ToList(); 

            
            Console.WriteLine("By Method:Intersection Products Between Two Order Collections:");
            foreach (var product in commonProducts)
            {
                Console.WriteLine(product);
            }

        }

        public void QueryProductsIntersectionOrderCollections()
        {
            List<Order> orders = Order.GetOrders();
            List<Order> orders1 = Order.GetOrders1();

            var commonProducts = (from order in orders
                                  select order.Product)
                                  .Intersect(from order in orders1 select order.Product).ToList();

            Console.WriteLine("By Query:Intersection Products Between Two ORder Collections:");
            foreach (var product in commonProducts)
            {
                Console.WriteLine(product);
            }


        }

        // Find products that exist in the first order collection but not in the second.
        public void MethodGetProductsExceptOrderCollections()
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

        public void QueryGetProductsExceptOrderCollections()
        {
            List<Order> orders = Order.GetOrders();
            List<Order> orders1 = Order.GetOrders1();

            var uniqueProducts = (from order in orders
                                  select order.Product)
                                  .Except(from order in orders1
                                          select order.Product)
                                  .ToList();

            Console.WriteLine("Products in the first collection but not in the second:");
            foreach (var product in uniqueProducts)
            {
                Console.WriteLine(product);
            }


        }

        //Assume a list of duplicate product names. Write a LINQ query to get a distinct list.
        public void MethodGetDistinctProducts()
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

        public void QueryGetDistinctProducts()
        {
            List<string> products = new List<string>
            {
             "Laptop", "Smartphone", "Tablet", "Laptop", "Smartwatch",
             "Tablet", "Smartphone", "Monitor", "Laptop", "Smartwatch"
            };

            var distinctProducts = (from product in products select product).Distinct().ToList();


            Console.WriteLine("Distinct Products:");
            foreach (var product in distinctProducts)
            {
                Console.WriteLine(product);
            }

        }



        //Create a LINQ query that retrieves customers from a collection and demonstrate deferred execution.
        public void DeferredExecutionExample()
        {
            List<Customer> customers = Customer.GetCustomerDetails();

           
            var query = customers.Where(c => c.City == "New York");

            Console.WriteLine("Query created but NOT executed yet.");

            
            Console.WriteLine("Executing Query:"); // The execution is done here so we can update and modify in this
            foreach (var customer in query)
            {
                Console.WriteLine($"{customer.CustomerId} - {customer.Name} - {customer.City}");
            }
        }

        //Create a LINQ query that retrieves orders from a collection and demonstrate immediate execution.
        public void ImmediateExecutionExample()
        {
            List<Order> orders = Order.GetOrders();

            // LINQ query with immediate execution (in this no updation or insertion works)
            var query = orders.Where(o => o.Amount > 500).ToList(); 

            Console.WriteLine("Query will be executing immediately.");

            
            Console.WriteLine("Displaying Orders Above $500:");
            foreach (var order in query)
            {
                Console.WriteLine($"{order.OrderId} - {order.Product} - ${order.Amount}");
            }
        }

        // Implement an example that simulates lazy vs. eager loading using LINQ queries.
        public void MethodEagerLazyLoading()
        {
            List<Customer> customers = Customer.GetCustomerDetails();
            List<Order> orders = Order.GetOrders();

            
            Console.WriteLine("Lazy Loading:");
            var lazyCustomers = customers.Select(c => new
            {
                c.CustomerId,
                c.Name,
                c.City,
                Orders = orders.Where(o => o.CustomerId == c.CustomerId) 
            });

            foreach (var customer in lazyCustomers)
            {
                Console.WriteLine($"\nCustomer: {customer.Name} ({customer.City})");

                
                foreach (var order in customer.Orders)
                {
                    Console.WriteLine($"   Order ID: {order.OrderId}, Product: {order.Product}, Amount: {order.Amount}");
                }
            }

            
            Console.WriteLine("\nEager Loading:");
            var eagerCustomers = customers.Select(c => new
            {
                c.CustomerId,
                c.Name,
                c.City,
                Orders = orders.Where(o => o.CustomerId == c.CustomerId).ToList() 
            }).ToList();  

            foreach (var customer in eagerCustomers)
            {
                Console.WriteLine($"\nCustomer: {customer.Name} ({customer.City})");

                
                foreach (var order in customer.Orders)
                {
                    Console.WriteLine($"   Order ID: {order.OrderId}, Product: {order.Product}, Amount: {order.Amount}");
                }
            }
        }
   }
}
