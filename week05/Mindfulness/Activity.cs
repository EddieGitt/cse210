// Base class containing all shared attributes and behaviors
// for every mindfulness activity.
public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public string GetName()
    {
        return _name;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"=== {_name} ===\n");
        Console.WriteLine($"Description:\n{_description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready to begin...");
        ShowSpinner(3);
        Console.Clear();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done! ✓");
        ShowSpinner(3);
        Console.WriteLine($"\nYou have completed the {_name}.");
        Console.WriteLine($"Duration: {_duration} seconds.");
        ShowSpinner(4);
    }

    // Spinner animation using backspace to create spinning effect
    public void ShowSpinner(int seconds)
    {
        string[] frames = { "|", "/", "-", "\\" };
        DateTime end = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < end)
        {
            Console.Write(frames[i % frames.Length]);
            System.Threading.Thread.Sleep(250);
            Console.Write("\b");
            i++;
        }
        Console.Write(" \b");
    }

    // Countdown timer animation using backspace
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            System.Threading.Thread.Sleep(1000);
            Console.Write("\b \b");
            if (i >= 10)
            {
                Console.Write("\b \b");
            }
        }
    }
}