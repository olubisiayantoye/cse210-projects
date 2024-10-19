using System;
using System.Threading;

public abstract class Activity
{
     /* Brigham Young University–Idaho
         Olubisi Ayantoye
       W05 Prove: Developer—Mindfulness */
    
    // Protected members for use in derived classes
    protected string _name;
    protected string _description;
    protected int _duration;

    // Constructor to initialize common activity properties
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Common starting message for all activities
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name}...");
        Console.WriteLine(_description);
        Console.Write("Enter the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3); // Pauses before starting
    }

    // Common ending message for all activities
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Good job! You have completed {_name} for {_duration} seconds.");
        ShowSpinner(3);
    }

    // Method for showing a spinner animation (used across all activities)
    protected void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }

    // Abstract method to be implemented by all derived classes
    public abstract void Run();
}
