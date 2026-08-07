// Extra activity: guides the user through a gratitude journaling session.
// This exceeds the core requirements by adding a 4th activity type.
public class GratitudeActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "What is something beautiful you noticed today?",
        "Who is someone you are grateful for and why?",
        "What is a challenge that helped you grow?",
        "What is something you often take for granted?",
        "What is a small moment today that made you smile?"
    };

    private Random _random = new Random();

    public GratitudeActivity() : base(
        "Gratitude Activity",
        "This activity will help you cultivate gratitude by guiding you to reflect on specific things you are thankful for. Gratitude has been shown to improve mood and overall wellbeing."
    )
    { }

    public void Run()
    {
        DisplayStartingMessage();

        DateTime end = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < end)
        {
            string prompt = _prompts[_random.Next(_prompts.Count)];
            Console.WriteLine($"\nReflect on this:\n  --- {prompt} ---");
            Console.Write("\nYour thoughts: ");
            Console.ReadLine();
            ShowSpinner(3);
        }

        DisplayEndingMessage();
    }
}