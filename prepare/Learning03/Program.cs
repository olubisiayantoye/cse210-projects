using System;

class Program
{
    static void Main(string[] args)
    {
        /* Brigham Young University–Idaho
         Olubisi Ayantoye
      W03 Prepare: Learning Activity*/
        
        // Test 1: Default constructor (1/1)
        Fraction frac1 = new Fraction();
        Console.WriteLine(frac1.GetFractionString()); // Output: 1/1
        Console.WriteLine(frac1.GetDecimalValue());   // Output: 1

        // Test 2: Constructor with one parameter (5 -> 5/1)
        Fraction frac2 = new Fraction(5);
        Console.WriteLine(frac2.GetFractionString()); // Output: 5/1
        Console.WriteLine(frac2.GetDecimalValue());   // Output: 5

        // Test 3: Constructor with two parameters (3/4)
        Fraction frac3 = new Fraction(3, 4);
        Console.WriteLine(frac3.GetFractionString()); // Output: 3/4
        Console.WriteLine(frac3.GetDecimalValue());   // Output: 0.75

        // Test 4: Constructor with two parameters (1/3)
        Fraction frac4 = new Fraction(1, 3);
        Console.WriteLine(frac4.GetFractionString()); // Output: 1/3
        Console.WriteLine(frac4.GetDecimalValue());   // Output: 0.3333333333333333

        // Test 5: Using getters and setters
        frac3.SetTop(6);
        frac3.SetBottom(7);
        Console.WriteLine(frac3.GetFractionString()); // Output: 6/7
        Console.WriteLine(frac3.GetDecimalValue());   // Output: 0.8571428571428571
    }
}
