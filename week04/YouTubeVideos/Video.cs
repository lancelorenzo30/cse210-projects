class Video
{
    private string _videoTitle;
    private string _videoAuthor;
    private int _videoLength;
    private List<Comment> _comments = new List<Comment>();


    public Video(string title, string author, int length)
    {
        _videoTitle = title;
        _videoAuthor = author;
        _videoLength = length;
    }

    public int CommentCounter()
    {
        return _comments.Count;
    }

    public void CommentAdder(Comment comment)
    {
      _comments.Add(comment); 
    }

    public void Display()
    {
        Console.WriteLine($"Title: {_videoTitle}");
        Console.WriteLine($"Author: {_videoAuthor}");
        Console.WriteLine($"Length: {_videoLength} seconds");
        Console.WriteLine($"Number of Comments: {CommentCounter()}");

        foreach (Comment comment in _comments)
        {
            comment.Display();
        }

        Console.WriteLine();
    }
}