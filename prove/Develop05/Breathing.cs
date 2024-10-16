using System;

public class Breathing : Activity
{
    private string _messageBreathing1 { get; set; }
    private string _messageBreathing2 { get; set; }

    public Breathing(string messageBreathing1, string messageBreathing2, string title, string desc, int duration, int milliseconds) 
        : base(duration, desc, title, milliseconds)
    {
        _messageBreathing1 = messageBreathing1;
        _messageBreathing2 = messageBreathing2;
    }

    public void GetStuff()
    {
        string title = GetTitle();
        string desc = GetDesc();
        int duration = GetDuration();
        int milliseconds = GetDurationInMilSecs();
    }

    public string GetMessage1()
    {
        return _messageBreathing1;
    }

    public string GetMessage2()
    {
        return _messageBreathing2;
    }
}
