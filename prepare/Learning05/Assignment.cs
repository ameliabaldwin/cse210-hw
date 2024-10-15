using System;

public class Assignment
{
    protected string _studentName {get;set;}
    private string _topic{get;set;}

    public Assignment()
    {
        _studentName = "unknown";
        _topic = "unknown";
    }
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetTopic()
    {
        return _topic;
    }
    public string GetStudentName()
    {
        return _studentName;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

}