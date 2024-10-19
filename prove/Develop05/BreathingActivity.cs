public class BreathingActivity : Activity
{
     /* Brigham Young University–Idaho
         Olubisi Ayantoye
       W05 Prove: Developer—Mindfulness */
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by guiding you through breathing in and out slowly.")
    {
    }

    // Overriding the Run method with enhanced animations
    public override void Run()
    {
        DisplayStartingMessage();

        // Simulate breathing by alternating between in and out
        for (int i = 0; i < _duration / 5; i++)
        {
            BreatheIn();
            BreatheOut();
        }

        DisplayEndingMessage();
    }

    // Method to simulate breathing in with expanding text effect
    private void BreatheIn()
    {
        Console.Clear();
        for (int i = 1; i <= 5; i++) // Expanding text
        {
            Console.WriteLine(new string(' ', 5 - i) + "Breathe In" + new string(' ', 5 - i));
            Thread.Sleep(500);
            Console.Clear();
        }
    }

    // Method to simulate breathing out with shrinking text effect
    private void BreatheOut()
    {
        Console.Clear();
        for (int i = 5; i >= 1; i--) // Shrinking text
        {
            Console.WriteLine(new string(' ', 5 - i) + "Breathe Out" + new string(' ', 5 - i));
            Thread.Sleep(500);
            Console.Clear();
        }
    }
}
