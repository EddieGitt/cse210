// Models a complete scripture — owns its reference and list of words.
// Responsible for displaying itself and hiding random words.
public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (string w in text.Split(' '))
        {
            _words.Add(new Word(w));
        }
    }

    public void HideRandomWords(int count)
    {
        // Only pick from words that are NOT already hidden
        List<Word> visible = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visible.Add(word);
            }
        }

        int hideCount = Math.Min(count, visible.Count);

        for (int i = 0; i < hideCount; i++)
        {
            int index = _random.Next(0, visible.Count);
            visible[index].Hide();
            visible.RemoveAt(index);
        }
    }

    public bool AllWordsHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }

    public string GetDisplayText()
    {
        List<string> parts = new List<string>();
        foreach (Word word in _words)
        {
            parts.Add(word.GetDisplayText());
        }
        return $"{_reference.GetDisplayText()}\n{string.Join(" ", parts)}";
    }
}