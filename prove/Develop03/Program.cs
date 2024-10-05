class Program
{
    static void Main(string[] args)
    {
           /* Brigham Young University–Idaho
         Olubisi Ayantoye
     W03 Prove: Developer—Scripture Memorizer */
        
        
        
        // Create a reference and scripture
        Reference reference = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son");

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3); // Hides 3 words at a time
        }

        Console.Clear();
        Console.WriteLine("All words are hidden! Program ended.");
    }
}
