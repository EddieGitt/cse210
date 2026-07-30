// Models a scripture reference like "John 3:16" or "Proverbs 3:5-6".
// Handles both single verse and verse range with multiple constructors.
public class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;
    private bool _isRange;

    // Single verse constructor e.g. "John 3:16"
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verse;
        _verseEnd = verse;
        _isRange = false;
    }

    // Verse range constructor e.g. "Proverbs 3:5-6"
    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
        _isRange = true;
    }

    public string GetDisplayText()
    {
        if (_isRange)
        {
            return $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
        }
        return $"{_book} {_chapter}:{_verseStart}";
    }
}