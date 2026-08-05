// Stores the name of the commenter and the text of the comment.
public class Comment
{
    private string _commenterName;
    private string _text;

    public Comment(string commenterName, string text)
    {
        _commenterName = commenterName;
        _text = text;
    }

    public string GetCommenterName()
    {
        return _commenterName;
    }

    public string GetText()
    {
        return _text;
    }

    public void Display()
    {
        Console.WriteLine($"  [{_commenterName}]: {_text}");
    }
}