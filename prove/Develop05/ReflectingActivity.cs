public class ReflectingActivity : Activity
{

 /* Brigham Young University–Idaho
         Olubisi Ayantoye
       W05 Prove: Developer—Mindfulness */

    // List of prompts and questions
    private List<string> _prompts = new List<string> {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need."
    };

    private string[] _questions = {
        "Why was this experience meaningful to you?",
        "How did you get started?",
        "How did you feel when it was complete?"
    };

    private List<string> _usedPrompts = new List<string>();

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on your strengths and past experiences.")
    {
    }

    // Overriding the Run method with unique prompts logic
    public override void Run()
    {
        DisplayStartingMessage();
        
        // Ensure all prompts are used before repeating
        if (_prompts.Count == 0)
        {
            _prompts.AddRange(_usedPrompts);
            _usedPrompts.Clear();
        }

        Random random = new Random();
        string selectedPrompt = _prompts[random.Next(_prompts.Count)];
        _prompts.Remove(selectedPrompt);
        _usedPrompts.Add(selectedPrompt);

        Console.WriteLine(selectedPrompt);
        ShowSpinner(3); // Pause for reflection

        // Looping through random reflection questions
        for (int i = 0; i < _duration / 5; i++)
        {
            Console.WriteLine(_questions[random.Next(_questions.Length)]);
            ShowSpinner(2);  // Pause for thinking
        }

        DisplayEndingMessage();
    }
}
