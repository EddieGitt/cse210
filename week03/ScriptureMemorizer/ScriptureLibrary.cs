// Holds a collection of scriptures and returns one at random.
// This exceeds core requirements — the spec only required one scripture.
public class ScriptureLibrary
{
    private List<Scripture> _scriptures;
    private Random _random = new Random();

    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>
        {
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son that whosoever believeth in him should not perish but have everlasting life"
            ),
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding In all thy ways acknowledge him and he shall direct thy paths"
            ),
            new Scripture(
                new Reference("Philippians", 4, 13),
                "I can do all things through Christ which strengtheneth me"
            ),
            new Scripture(
                new Reference("Joshua", 1, 9),
                "Be strong and of a good courage be not afraid neither be thou dismayed for the Lord thy God is with thee whithersoever thou goest"
            ),
            new Scripture(
                new Reference("Psalm", 23, 1, 3),
                "The Lord is my shepherd I shall not want He maketh me to lie down in green pastures he leadeth me beside the still waters He restoreth my soul"
            ),
            new Scripture(
                new Reference("Romans", 8, 28),
                "And we know that all things work together for good to them that love God to them who are the called according to his purpose"
            ),
            new Scripture(
                new Reference("Isaiah", 40, 31),
                "But they that wait upon the Lord shall renew their strength they shall mount up with wings as eagles they shall run and not be weary and they shall walk and not faint"
            )
        };
    }

    public Scripture GetRandomScripture()
    {
        int index = _random.Next(0, _scriptures.Count);
        return _scriptures[index];
    }
}