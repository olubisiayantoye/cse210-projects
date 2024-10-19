public class ListingActivity : Activity
{
     /* Brigham Young University–Idaho
         Olubisi Ayantoye
       W05 Prove: Developer—Mindfulness */
    private string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people you have helped this week?"
    };

    private List<string> _responses = new List<string>(); // To store user responses

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by listing them.")
    {
    }

    // Overriding the Run method with saving user responses
    public override void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();
        Console.WriteLine(_prompts[random.Next(_prompts.Length)]);
        ShowSpinner(3);  // Pause before listing

        Console.WriteLine("Start listing items: ");
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        // Collecting user input and saving it in the list
        while (DateTime.Now < endTime)
        {
            string response = Console.ReadLine();
            if (!string.IsNullOrEmpty(response))
            {
                _responses.Add(response);
            }
        }

        // Display back the user's responses
        Console.WriteLine($"You listed {_responses.Count} items:");
        foreach (string response in _responses)
        {
            Console.WriteLine("- " + response);
        }

        DisplayEndingMessage();
    }
}
