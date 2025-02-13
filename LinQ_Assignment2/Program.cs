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
            operations.QueryGroupJoin();

            operations.MethodGroupJoin();
            operations.QueryGroupJoin();

            operations.MethodCrossJoinPossibleCombinationsOfCustomersAndOrders();
            operations.QueryCrossJoinPossibleCombinationsOfCUstomersAndOrders();

            operations.MethodLeftOuterJoin();
            operations.QueryLeftOuterJoin();

            operations.MethodGroupOrderByCustomerId();
            operations.QueryGroupOrderByCustomerId();

            operations.MethodOrderLookUpByCustomer();
            operations.QueryOrderLookUpByCustomer();

            operations.MethodGroupByCountOfOrders();
            operations.QueryGroupByCountOfOrders();

            operations.MethodCustomerNestedQuery();
            operations.QueryCustomerNestedQuery();

            operations.MethodUniqueCitiesCustomers();
            operations.QueryUniqueCitiesCustomers();

            operations.MethodProductsDifferentOrderCombinedCollections();
            operations.QueryProductsDifferentOrderCombinedCollections();

            operations.MethodProductsIntersectionOrderCollections();
            operations.QueryProductsIntersectionOrderCollections();

            operations.MethodGetProductsExceptOrderCollections();
            operations.QueryGetProductsExceptOrderCollections();

            operations.MethodGetDistinctProducts();
            operations.QueryGetDistinctProducts();

            operations.DeferredExecutionExample();
            operations.ImmediateExecutionExample();

            operations.MethodEagerLazyLoading();
         }
    }
}


