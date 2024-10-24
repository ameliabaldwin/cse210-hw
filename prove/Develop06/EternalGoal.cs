public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void RecordEvent(int points)
    {
        _points += points;
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_shortName}: {_description} - points: {this._points}";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}|{_description}|{this._points}";
    }
}
