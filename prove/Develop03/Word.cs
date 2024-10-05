public class Word
{
     /* Brigham Young University–Idaho
         Olubisi Ayantoye
     W03 Prove: Developer—Scripture Memorizer */
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Hides the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Shows the word
    public void Show()
    {
        _isHidden = false;
    }

    // Returns whether the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Returns the word text, or underscores if hidden
    public string GetDisplayText()
    {
        return _isHidden ? new string('_', _text.Length) : _text;
    }
}
