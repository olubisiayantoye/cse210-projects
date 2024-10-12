class Program
{
    /* Brigham Young University–Idaho
         Olubisi Ayantoye
     W03 Prove: Developer—Scripture Memorizer */
    
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary("scriptures.txt");
        Scripture scripture = library.GetRandomScripture();

        Console.WriteLine("Choose difficulty: 1. Easy  2. Medium  3. Hard");
        string difficultyInput = Console.ReadLine();
        int numberToHide = difficultyInput switch
        {
            "1" => 1,  // Easy: hide 1 word at a time
            "2" => 3,  // Medium: hide 3 words
            "3" => 5,  // Hard: hide 5 words
            _ => 1,    // Default to easy
        };

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

            scripture.HideRandomWords(numberToHide);
        }

        Console.Clear();
        Console.WriteLine("All words are hidden! Program ended.");
    }
}
