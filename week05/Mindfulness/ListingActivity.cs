// Guides the user to list as many positive things as they can.
public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt peace and gratitude this month?",
        "Who are some of your personal heroes?",
        "What are things that bring you joy?",
        "What are ways you have grown this year?"
    };

    private List<string> _usedPrompts = new List<string>();
    private Random _random = new Random();

    public ListingActivity() : base(
        "Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."
    )
    { }

    private string GetNextPrompt()
    {
        if (_usedPrompts.Count >= _prompts.Count)
        {
            _usedPrompts.Clear();
        }

        List<string> available = new List<string>();
        foreach (string p in _prompts)
        {
            if (!_usedPrompts.Contains(p))
            {
                available.Add(p);
            }
        }

        string chosen = available[_random.Next(available.Count)];
        _usedPrompts.Add(chosen);
        return chosen;
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetNextPrompt();
        Console.WriteLine($"\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"  --- {prompt} ---");
        Console.WriteLine("\nYou will have a few seconds to think before you begin...");
        ShowCountdown(5);

        Console.WriteLine("\n\nStart listing items (press Enter after each one):\n");

        List<string> items = new List<string>();
        DateTime end = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (item != null && item.Trim() != "")
            {
                items.Add(item.Trim());
            }
        }

        Console.WriteLine($"\nYou listed {items.Count} items!");

        DisplayEndingMessage();
    }
}