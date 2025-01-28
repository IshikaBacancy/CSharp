using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class NumbersArr

    {
        int count = 0;
        public int[] Numbers { get; set; }

        public NumbersArr()
        {
           
            

              Random random = new Random();
                Numbers = new int[50];


                for (int i = 0; i < Numbers.Length; i++)
                {
                    Numbers[i] = random.Next(1, 50);


                }
        }
            
        //Calculating the even sum of randomly generated 50 integers 
        public int CalculateEvenSum()
        {
            int sum = 0;
            foreach (int number in Numbers)
            {
                if(number % 2 == 0)
                {
                    sum += number;
                    count++;
                }
                
            }
            return sum;

        }
         
        //Calculating the even sum of randomly generated 50 integers
        public double CalculateEvenAverage()
        {
            int sum = CalculateEvenSum();
            
            return count > 0 ? (double)sum / count : 0;
        }
    }
}
