using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncManager
{
    public class AsyncTasker
    {
        public static async Task<int> PerformAsyncTask(int id)
        {
            try
            {
                Console.WriteLine($"Task {id} started ....");
                await Task.Delay(new Random().Next(1000, 3000));
                Console.WriteLine($"Task {id} completed.");
                return id * 10;
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Error in Task {id}: {ex.Message}");
                return -1;
            }

            
        }
    }
}
