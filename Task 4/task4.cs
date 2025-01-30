using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    public  class task4
    {
        public static async Task<int> PerformAsyncTask(int id)
        {
            Console.WriteLine($"Task {id} started ....");
            await Task.Delay(new Random().Next(1000, 3000));
            Console.WriteLine($"Task {id} completed.");
            return id * 10;
        }
    }
}
