using System;

public class Reflection : Activity
{
    private string[] _promptQuestions { get; set; }
    private string[] _promptThinking { get; set; }

    public Reflection(string[] promptQuestions, string[] promptThinking, string title, string desc, int duration, int milliseconds)
        : base(duration, desc, title, milliseconds)
    {
        _promptQuestions = promptQuestions;
        _promptThinking = promptThinking;
    }

    public string GetRandomQuestion(Random rnd)
    {
        return _promptQuestions[rnd.Next(0, _promptQuestions.Length)];
    }
    public string GetRandomThinkingPrompt(Random rnd)
    {
        return _promptThinking[rnd.Next(0, _promptThinking.Length)];
    }
}
