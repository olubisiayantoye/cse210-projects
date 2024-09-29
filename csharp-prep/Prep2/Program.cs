using System;

class Program
{
    static void Main()
    {
          /* Brigham Young University–Idaho
         Olubisi Ayantoye
       W01 Prove: Developer—C# Programming */
       
        // Prompt the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        int percentage = int.Parse(Console.ReadLine());

        // Declare a variable for the letter grade
        string letter = "";
        string sign = "";

        // Determine the letter grade
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Check if the user passed or failed
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Keep trying, and you'll do better next time!");
        }

        // Stretch Challenge: Determine if a "+" or "-" sign is needed
        if (letter != "A" && letter != "F") // A+ does not exist, and F doesn't have a + or -
        {
            int lastDigit = percentage % 10;
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }

        // Special case for A: only A or A-, no A+
        if (letter == "A" && percentage < 93)
        {
            sign = "-";
        }

        // Print the final grade with letter and sign
        Console.WriteLine($"Your grade is: {letter}{sign}");
    }
}
