using System;



//Console.WriteLine("Hello, World!");

// Method to calculate the factorial of a number
int Factorial(int n)
{
    int res = 1;

    for (int i = 2; i <= n; i++)
        res *= i;
    return res;
}

// Prompt the user to enter a number
Console.Write("Enter a number to calculate its factorial: ");
string? input = Console.ReadLine();

// Validate and parse user input
if (int.TryParse(input, out int num) && num >= 0)
{
    Console.WriteLine("Factorial of " + num + " is " + Factorial(num));
}
else
{
    Console.WriteLine("Invalid input! Please enter a non-negative integer.");
}
