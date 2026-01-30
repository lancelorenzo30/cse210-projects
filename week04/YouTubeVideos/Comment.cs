class Comment
{
    private string _commenterName;
    private string _textComment;

    public Comment(string name, string text)
    {
        _commenterName = name;
        _textComment = text;
    }

    public void Display()
    {
        Console.WriteLine($"- {_commenterName}: {_textComment}");
    }
}