// Guides the user to reflect deeply on a meaningful experience.
public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you overcame a fear.",
        "Think of a time when you made someone's day better."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
        "Who else benefited from this experience?"
    };

    private List<string> _usedPrompts = new List<string>();
    private List<string> _usedQuestions = new List<string>();
    private Random _random = new Random();

    public ReflectionActivity() : base(
        "Reflection Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."
    )
    { }

    // Exceeds requirements: no prompt or question repeats until all used
    private string GetNextItem(List<string> all, List<string> used)
    {
        if (used.Count >= all.Count)
        {
            used.Clear();
        }

        List<string> available = new List<string>();
        foreach (string item in all)
        {
            if (!used.Contains(item))
            {
                available.Add(item);
            }
        }

        string chosen = available[_random.Next(available.Count)];
        used.Add(chosen);
        return chosen;
    }

    public void Run()
    {
        DisplayStartingMessage();

        string prompt = GetNextItem(_prompts, _usedPrompts);
        Console.WriteLine($"\nConsider the following prompt:\n");
        Console.WriteLine($"  --- {prompt} ---\n");
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        ShowSpinner(3);

        DateTime end = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < end)
        {
            string question = GetNextItem(_questions, _usedQuestions);
            Console.Write($"\n> {question} ");
            ShowSpinner(8);
        }

        DisplayEndingMessage();
    }
}