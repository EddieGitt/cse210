// Stores the title, author, length, and comments of a YouTube video.
public class Video
{
    private string _title;
    private string _author;
    private int _lengthSeconds;
    private List<Comment> _comments;

    public Video(string title, string author, int lengthSeconds)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumComments()
    {
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine("=================================================");
        Console.WriteLine($"Title:    {_title}");
        Console.WriteLine($"Author:   {_author}");
        Console.WriteLine($"Length:   {_lengthSeconds} seconds");
        Console.WriteLine($"Comments: {GetNumComments()}");
        Console.WriteLine("-------------------------------------------------");

        foreach (Comment comment in _comments)
        {
            comment.Display();
        }

        Console.WriteLine();
    }
}