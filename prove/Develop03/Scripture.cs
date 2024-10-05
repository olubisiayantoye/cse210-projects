public class Scripture
{
    
       /* Brigham Young University–Idaho
         Olubisi Ayantoye
     W03 Prove: Developer—Scripture Memorizer */
    
    
    private Reference _reference;
    private List<Word> _words;

    // Constructor that takes a reference and the scripture text
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList(); // splits the scripture into words
    }

    // Hides a random number of words in the scripture
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int randomIndex = random.Next(_words.Count);
            _words[randomIndex].Hide();
        }
    }

    // Displays the scripture text, replacing hidden words with underscores
    public string GetDisplayText()
    {
        string displayText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {displayText}";
    }

    // Checks if all words are hidden
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
