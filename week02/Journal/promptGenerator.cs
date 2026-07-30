// Responsible for storing and randomly selecting writing prompts.
public class PromptGenerator
{
    private List<string> _prompts = new List<string>
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What is something new I learned today?",
        "What am I most grateful for today?",
        "What challenge did I face today and how did I handle it?",
        "What made me smile or laugh today?",
        "What is one thing I want to do differently tomorrow?",
        "Describe a moment today where you felt truly present."
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(0, _prompts.Count);
        return _prompts[index];
    }
}