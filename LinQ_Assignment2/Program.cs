using System;
using System.Collections.Generic;
using LinQ_Assignment_2;

namespace LinQ_Assignment2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Order> orders = Order.GetOrders();
            List<Order> orders1 = Order.GetOrders1();

            List<Customer> Customers = Customer.GetCustomerDetails();

            LinQoperations operations = new LinQoperations();
            operations.MethodGetInnerJoin();
            operations.MethodGroupJoin();
            operations.MethodCrossJoinPossibleCombinationsofCustomersAndOrders();
            operations.MethodLeftOuterJoin();
            operations.MethodGroupOrderByCustomerId();
            operations.MethodOrderLookUpByCustomer();
            operations.MethodGroupByCountOfOrders();
            operations.MethodCustomerNestedQuery();
            operations.MethodUniqueCitiesCustomers();
            operations.MethodProductsDifferentOrderCombinedCollections();
            operations.MethodProductsIntersectionOrderCollections();
            operations.MethodProductsExceptOrderCollections();
            operations.GetDistinctProducts();
            operations.DeferredExecutionExample();
            operations.ImmediateExecutionExample();
        }
    }
}


