public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void RecordEvent(int points)
    {
        _points += points;
        _completed = true;
    }

    public override bool IsComplete()
    {
        return _completed;
    }

    public override string GetDetailsString()
    {
        return $"[{(_completed ? "X" : " ")}] {_shortName}: {_description} - points: {this._points}";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}|{_description}|{this._points}|{_completed}";
    }
}
