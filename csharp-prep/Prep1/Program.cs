using System;

class Program
{
    static void Main()
    {
          /* Brigham Young University–Idaho
         Olubisi Ayantoye
       W01 Prove: Developer—C# Programming */
       
        // Prompt the user for their first name
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        
        // Prompt the user for their last name
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        
        // Display the name in the desired format
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}
