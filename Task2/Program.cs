using System;
using Task2;

namespace Array
{
    class Program
    {
        static void Main(String[] args)
        {
            NumbersArr array = new NumbersArr();

            
            
            Console.WriteLine("The generated numbers are: " + string.Join(", ", array.Numbers));

            Console.WriteLine("The even sum of the array: " + array.CalculateEvenSum());

            Console.WriteLine("The even average of the array: " + array.CalculateEvenAverage());

        }
    }
}
