using System;

public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;

    // Constructor for Entry
    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    // Displays the entry with date, prompt, and response
    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine();
    }

    // Converts the entry to a string for file saving purposes
    public override string ToString()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }

    // Static method to create an Entry object from a string (for loading from file)
    public static Entry FromString(string entryString)
    {
        string[] parts = entryString.Split('|');
        return new Entry(parts[0], parts[1], parts[2]);
    }
}
