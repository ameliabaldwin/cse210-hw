using System;

public class Comment
{
    private string userName;
    private string text;
    public Comment(string _userName, string _text)
    {
        userName = _userName;
        text = _text;

    }
    public string GetUsername()
    {
        return userName;
    }
    public string GetText()
    {
        return text;
    }
}