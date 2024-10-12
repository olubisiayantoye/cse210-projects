public class Reference
{
     /* Brigham Young University–Idaho
         Olubisi Ayantoye
     W03 Prove: Developer—Scripture Memorizer */
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        return _verse == _endVerse 
            ? $"{_book} {_chapter}:{_verse}" 
            : $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }
}
