using System;

public class Activity
{
    private int _duration { get; set; }
    private int _milliseconds { get; set; }
    private string _description { get; set; }
    private string _title { get; set; }

    public Activity(int duration, string desc, string title, int milliseconds)
    {
        _duration = duration;
        _description = desc;
        _title = title;
        _milliseconds = milliseconds;
    }

    public int GetDurationInMilSecs()
    {
        _milliseconds = _duration * 60 * 1000; // Converts minutes to milliseconds
        return _milliseconds;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetDesc()
    {
        return _description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public string GetActivityDetails()
    {
        return $"{_title}\nDescription: {_description}\nDuration: {_duration} mins";
    }
    
}
