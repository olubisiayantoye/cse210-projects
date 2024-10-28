public abstract class ScriptureFormatter
{
    public abstract string Format(string scriptureText);
}

public class HideWordsFormatter : ScriptureFormatter
{
    public override string Format(string scriptureText)
    {
        // Hides specific words, for example, replacing "God" with a blank
        return scriptureText.Replace("God", "___");
    }
}

public class RevealHintFormatter : ScriptureFormatter
{
    public override string Format(string scriptureText)
    {
        // Adds a hint to the scripture text
        return scriptureText + " (Hint: The next word is 'God')";
    }
}

public class ScriptureMemorizer
{
    private ScriptureFormatter formatter;

    public ScriptureMemorizer(ScriptureFormatter formatter)
    {
        this.formatter = formatter;
    }

    public void DisplayScripture(string text)
    {
        Console.WriteLine(formatter.Format(text));
    }
}
