using System;
using System.Collections.Generic;
using System.Linq;

public static class StringExtension
{
    public static int CountCustomVowels(this string input, HashSet<char> customVowels)
    {
        if (string.IsNullOrEmpty(input) || customVowels == null || customVowels.Count == 0)
            return 0;

        return input.Count(c => customVowels.Contains(char.ToLower(c)));
    }
}

class Program
{
    static void Main()
    {
        // Take user input for the string
        Console.Write("Enter a string : ");
        string text = Console.ReadLine();

        // Default vowels
        HashSet<char> vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

        // Ask user if they want to add more vowels
        Console.Write(" would you like to add the extra characters as vowels? (y/n): ");
        string choice = Console.ReadLine().ToLower();

        if (choice == "y")
        {
            Console.Write("Enter the additional characters to count as vowels: ");
            string additionalVowels = Console.ReadLine();

            // Adding the user-specified characters to the vowels set 
            foreach (char c in additionalVowels.ToLower())
            {
                vowels.Add(c);
            }
        }

        // Counting the vowels 
        int vowelCount = text.CountCustomVowels(vowels);
        Console.WriteLine($"Number of vowels in \"{text}\": {vowelCount}");
    }
}
