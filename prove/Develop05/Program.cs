class Program
{
 /* Brigham Young University–Idaho
         Olubisi Ayantoye
       W05 Prove: Developer—Mindfulness */
//Exceeding Requirements:
//Breathing Animation: The breathing activity includes dynamic visual effects where the text size expands and shrinks, simulating a real breathing cycle.
//Unique Prompts in Reflection: The reflecting activity ensures that prompts do not repeat until all prompts have been used, improving variety and uniqueness for each session.
//Response Logging in Listing: The listing activity now saves and displays the user's responses at the end, allowing them to reflect on what they listed

    static void Main(string[] args)
    {
        while (true)
        {
            // Displaying menu options for the user
            Console.WriteLine("Choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            string choice = Console.ReadLine();

            // Switch statement for user choice
            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    break;
                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity();
                    reflecting.Run();
                    break;
                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please select again.");
                    break;
            }
        }
    }
}
