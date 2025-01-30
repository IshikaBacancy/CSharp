// Task 4: Create a program that performs multiple asynchronous operations concurrently.
// You must ensure that the program does not block while waiting for multiple tasks to complete.
// The twist: You need to gather and process the results of these operations in parallel and output them as soon as all tasks are finished.

using AsyncManager;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {

        try
        {
            Console.WriteLine("Starting asynchronous tasks...");
            List<Task<int>> tasks = new List<Task<int>>
            {
                AsyncTasker.PerformAsyncTask(1),
                AsyncTasker.PerformAsyncTask(2),
                AsyncTasker.PerformAsyncTask(3),
                AsyncTasker.PerformAsyncTask(4)
            };

            int[] results = await Task.WhenAll(tasks);


            foreach (int result in results)
            {
                Console.WriteLine(result);
            }
                

            Console.WriteLine("All tasks completed.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

            
    }
}
