public class Scripture
{
      /* Brigham Young University–Idaho
         Olubisi Ayantoye
     W03 Prove: Developer—Scripture Memorizer */
    
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<Word> visibleWords = _words.Where(word => !word.IsHidden()).ToList();

        if (visibleWords.Count == 0)
        {
            return;
        }

        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int randomIndex = random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
            visibleWords.RemoveAt(randomIndex);
        }
    }

    public string GetDisplayText()
    {
        string displayText = string.Join(" ", _words.Select(word => word.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {displayText}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}
