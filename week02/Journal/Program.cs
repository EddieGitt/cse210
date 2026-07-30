// ============================================================
// W02 Journal Program
// Author: [Ediomo Victor]
//
// Exceeds core requirements in the following ways:
// 1. Includes 10 diverse writing prompts (spec required only 5).
// 2. Entries display a running count summary ("X entries total").
// 3. PromptGenerator is its own class with a dedicated
//    responsibility, keeping Journal and Entry clean.
// 4. The save/load format uses ~|~ as a separator to safely
//    handle commas and common punctuation in responses.
// 5. File.Exists() check prevents crash on bad filename input.
// ============================================================

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool running = true;

        Console.WriteLine("Welcome to your Journal!");

        while (running)
        {
            Console.WriteLine("=== Journal Menu ===");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display all entries");
            Console.WriteLine("3. Save journal to file");
            Console.WriteLine("4. Load journal from file");
            Console.WriteLine("5. Quit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    journal.WriteNewEntry();
                    break;
                case "2":
                    journal.DisplayAll();
                    Console.WriteLine($"Total entries: {journal.GetEntryCount()}\n");
                    break;
                case "3":
                    journal.SaveToFile();
                    break;
                case "4":
                    journal.LoadFromFile();
                    break;
                case "5":
                    running = false;
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.\n");
                    break;
            }
        }
    }
}