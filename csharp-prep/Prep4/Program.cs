using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
          /* Brigham Young University–Idaho
         Olubisi Ayantoye
       W01 Prove: Developer—C# Programming */
        
        //I Initialize an empty list to store the numbers
        List<int> numbers = new List<int>();
        
        // Ask the user to input numbers and add them to the list
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int number;
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());

            // Only add non-zero numbers to the list
            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0); // Stop when the user enters 0
        
        // Core Requirements:
        // 1. Compute the sum of the numbers in the list
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        // 2. Compute the average of the numbers in the list
        double average = (double)sum / numbers.Count;

        // 3. Find the maximum number in the list
        int max = numbers[0]; // Initialize with the first number
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        // Output core results
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");

        // Stretch Challenge:
        // 4. Find the smallest positive number in the list
        int? smallestPositive = null;
        foreach (int num in numbers)
        {
            if (num > 0 && (smallestPositive == null || num < smallestPositive))
            {
                smallestPositive = num;
            }
        }

        if (smallestPositive != null)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        }

        // 5. Sort the numbers in ascending order and display them
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
