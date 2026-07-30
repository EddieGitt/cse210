// ============================================================
// W03 Scripture Memorizer Program
// Author: [Ediomo Victor]
//
// Exceeds core requirements in the following ways:
//
// 1. SCRIPTURE LIBRARY: Instead of a single hardcoded scripture,
//    the program uses a ScriptureLibrary class that holds 7
//    scriptures and selects one at random each session.
//
// 2. SMART WORD HIDING: Words are only selected from those not
//    already hidden (spec allowed re-selecting hidden words).
//    This makes every keypress meaningful and speeds up the game.
//
// 3. MULTIPLE VERSE RANGES: Reference class supports both single
//    verse ("John 3:16") and verse ranges ("Proverbs 3:5-6")
//    via two constructors, and the library includes both types.
//
// 4. WORDS HIDDEN PER PRESS: 3 words are hidden per Enter press
//    (configurable), making the challenge more engaging.
// ============================================================

class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();
        Scripture scripture = library.GetRandomScripture();

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("All words are hidden. Well done!");
                break;
            }

            Console.Write("Press Enter to hide more words or type 'quit' to exit: ");
            string input = Console.ReadLine();

            if (input.Trim().ToLower() == "quit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}