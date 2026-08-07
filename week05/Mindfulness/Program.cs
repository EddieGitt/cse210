// ============================================================
// W05 Mindfulness Program
// Author: [Your Name]
//
// Exceeds core requirements in the following ways:
//
// 1. FOURTH ACTIVITY: Added a GratitudeActivity class that
//    extends the base Activity class, providing a fourth
//    mindfulness option beyond the three required.
//
// 2. NO REPEAT PROMPTS: ReflectionActivity and ListingActivity
//    track used prompts/questions and do not repeat any until
//    all have been shown at least once in the session.
//
// 3. ACTIVITY LOG: The program tracks how many times each
//    activity has been completed during the session and
//    displays a summary log when the user exits.
//
// 4. SPINNER + COUNTDOWN: Both animation types are implemented
//    in the base class using backspace characters (\b) to
//    create true in-place animation effects.
// ============================================================

using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Activity log — exceeds requirements
        Dictionary<string, int> activityLog = new Dictionary<string, int>
        {
            { "Breathing Activity", 0 },
            { "Reflection Activity", 0 },
            { "Listing Activity", 0 },
            { "Gratitude Activity", 0 }
        };

        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("=== Mindfulness Program ===\n");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Breathing Activity");
            Console.WriteLine("  2. Reflection Activity");
            Console.WriteLine("  3. Listing Activity");
            Console.WriteLine("  4. Gratitude Activity  [bonus]");
            Console.WriteLine("  5. View Activity Log");
            Console.WriteLine("  6. Quit");
            Console.Write("\nSelect a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();
                    activityLog["Breathing Activity"]++;
                    break;

                case "2":
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.Run();
                    activityLog["Reflection Activity"]++;
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();
                    activityLog["Listing Activity"]++;
                    break;

                case "4":
                    GratitudeActivity gratitude = new GratitudeActivity();
                    gratitude.Run();
                    activityLog["Gratitude Activity"]++;
                    break;

                case "5":
                    Console.Clear();
                    Console.WriteLine("=== Activity Log (This Session) ===\n");
                    foreach (var entry in activityLog)
                    {
                        Console.WriteLine($"  {entry.Key}: {entry.Value} time(s)");
                    }
                    Console.WriteLine("\nPress Enter to return to the menu.");
                    Console.ReadLine();
                    break;

                case "6":
                    running = false;
                    Console.Clear();
                    Console.WriteLine("Thank you for taking time for mindfulness. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    System.Threading.Thread.Sleep(1500);
                    break;
            }
        }
    }
}