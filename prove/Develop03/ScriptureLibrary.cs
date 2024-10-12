public class ScriptureLibrary
{
      /* Brigham Young University–Idaho
         Olubisi Ayantoye
     W03 Prove: Developer—Scripture Memorizer */
    
    
    private List<Scripture> _scriptures = new List<Scripture>();

    public ScriptureLibrary(string filePath)
    {
        LoadScripturesFromFile(filePath);
    }

    private void LoadScripturesFromFile(string filePath)
    {
        string[] lines = System.IO.File.ReadAllLines(filePath);
        foreach (var line in lines)
        {
            string[] parts = line.Split('|'); // Expecting format: "Book Chapter:Verse [text]"
            if (parts.Length == 3)
            {
                string book = parts[0];
                string[] chapterVerse = parts[1].Split(':');
                int chapter = int.Parse(chapterVerse[0]);
                string[] verses = chapterVerse[1].Split('-');
                int verse = int.Parse(verses[0]);
                int endVerse = verses.Length > 1 ? int.Parse(verses[1]) : verse;
                string text = parts[2];

                Reference reference = new Reference(book, chapter, verse, endVerse);
                Scripture scripture = new Scripture(reference, text);
                _scriptures.Add(scripture);
            }
        }
    }

    public Scripture GetRandomScripture()
    {
        Random random = new Random();
        int index = random.Next(_scriptures.Count);
        return _scriptures[index];
    }
}
