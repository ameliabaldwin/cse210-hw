using System;

public class Video
{
    private string title;
    private string author;
    private int length;

    private List<Comment> comments;

    public Video(string _title, string _author, int _length)
    {
        title = _title;
        author = _author;
        length = _length;
        comments = new List<Comment>();
    }
    public void AddComments(Comment comment)
    {
        comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }
    public List<Comment> GetComments()
    {
        return comments;
    }
    
    public string GetTitle()
    {
        return title;
    }
    public string GetAuthor()
    {
        return author;
    }
    public int GetLength()
    {
        return length;
    }
}