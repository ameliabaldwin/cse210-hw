using System;

public class MathAssignment : Assignment
{
    private string _textBookSection {get;set;}
    private string _problems {get;set;}

    public MathAssignment(string textBookSection, string problems, string topic, string studentName): base(studentName, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{_textBookSection} {_problems}";
    }
}