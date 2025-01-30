// See https://aka.ms/new-console-template for more information

//Task 2: Create a program that generates 50 random integers, stores them in an array, and calculates and displays both the sum and average of even numbers only

using System;
using Task2;


namespace Array
{
    class Program
    {
        static void Main(String[] args)
        {
            try
            {
                EvenStatistics array = new EvenStatistics();

                try
                {
                    Console.WriteLine("The generated numbers are: " + string.Join(", ", array.Numbers));

                    Console.WriteLine("The even sum of the array: " + array.CalculateEvenSum());

                    Console.WriteLine("The even average of the array: " + array.CalculateEvenAverage());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred while processing the numbers: " + ex.Message);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred while initializing the EvenStatistics object: " + ex.Message);
            }
                






            


        }
    }
}









