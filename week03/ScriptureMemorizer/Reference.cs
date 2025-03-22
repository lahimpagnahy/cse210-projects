/// <summary>
/// The Reference class represents a scripture reference (e.g., "John 3:16" or "Proverbs 3:5-6")
/// </summary>
class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    
    // Remarque 10 
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse; // Remarque 11
    }
    
    // Remarque 12
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }
    
    /// <summary>
    /// Returns the formatted reference text
    /// </summary>
    public string GetDisplayText()
    {
        if (_verse == _endVerse)
        {
            // Single verse reference (e.g., "John 3:16")
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            // Verse range reference (e.g., "Proverbs 3:5-6")
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}