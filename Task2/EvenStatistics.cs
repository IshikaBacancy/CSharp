using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class EvenStatistics

    {
        int count = 0;
        public int[] Numbers { get; set; }

        public EvenStatistics()
        {
            try
            {
                Random random = new Random();
                Numbers = new int[50];

                for (int i = 0; i < Numbers.Length; i++)
                {
                    Numbers[i] = random.Next(1, 50);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while generating random numbers: " + ex.Message);
                Numbers = new int[0];
            }

               
        }
            
        //Calculating the even sum of randomly generated 50 integers 
        public int CalculateEvenSum()
        {
            int sum = 0;
            try
            {
                foreach (int number in Numbers)
                {
                    if (number % 2 == 0)
                    {
                        sum += number;
                        count++;
                    }

                }
            }
            catch
            {
                Console.WriteLine("An error occurred while calculating even sum:");
            }
           
            return sum;

        }
         
        //Calculating the even sum of randomly generated 50 integers
        public double CalculateEvenAverage()
        {
            try
            {
                int sum = CalculateEvenSum();

                return count > 0 ? (double)sum / count : 0;
            }
            catch
            {
                Console.WriteLine("An error occurred while calculating even average: ");
                return 0;
            }
            //int sum = CalculateEvenSum();
            
            //return count > 0 ? (double)sum / count : 0;
        }
    }
}
