// Models the journal — owns the list of entries and
// handles displaying, saving, and loading.
public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    private PromptGenerator _promptGenerator = new PromptGenerator();

    public void WriteNewEntry()
    {
        string prompt = _promptGenerator.GetRandomPrompt();
        string date = DateTime.Now.ToString("yyyy-MM-dd");

        Console.WriteLine($"\nPrompt: {prompt}");
        Console.Write("> ");
        string response = Console.ReadLine();

        Entry entry = new Entry(date, prompt, response);
        _entries.Add(entry);

        Console.WriteLine("Entry saved!\n");
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries yet.\n");
            return;
        }

        Console.WriteLine();
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile()
    {
        Console.Write("Enter filename to save to (e.g. journal.txt): ");
        string filename = Console.ReadLine();

        List<string> lines = new List<string>();
        foreach (Entry entry in _entries)
        {
            lines.Add(entry.ToFileString());
        }

        File.WriteAllLines(filename, lines);
        Console.WriteLine($"Journal saved to {filename}\n");
    }

    public void LoadFromFile()
    {
        Console.Write("Enter filename to load from (e.g. journal.txt): ");
        string filename = Console.ReadLine();

        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found.\n");
            return;
        }

        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            if (line.Trim() != "")
            {
                Entry entry = Entry.FromFileString(line);
                _entries.Add(entry);
            }
        }

        Console.WriteLine($"Loaded {_entries.Count} entries from {filename}\n");
    }

    public int GetEntryCount() => _entries.Count;
}