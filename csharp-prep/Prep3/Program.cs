using System;

class Program
{
    static void Main()
    {
        
          /* Brigham Young University–Idaho
         Olubisi Ayantoye
       W01 Prove: Developer—C# Programming */
       
        // Variable to track if the user wants to keep playing
        string playAgain = "yes";

        // Loop for replaying the game
        while (playAgain == "yes")
        {
            // Generate a random magic number between 1 and 100
            Random random = new Random();
            int magicNumber = random.Next(1, 101);

            // Track the number of guesses
            int guessCount = 0;
            int guess = -1; // Initialize guess to a value that won't match the magic number

            Console.WriteLine("Welcome to the Guess My Number game!");

            // Loop until the user guesses the magic number
            while (guess != magicNumber)
            {
                // Ask the user for their guess
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount++;

                // Provide feedback
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
            }

            // Ask the user if they want to play again
            Console.Write("Do you want to play again? (yes/no) ");
            playAgain = Console.ReadLine().ToLower();
        }

        Console.WriteLine("Thanks for playing!");
    }
}
