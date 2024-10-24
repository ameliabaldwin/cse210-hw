public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public int AmountCompleted
    {
        get { return _amountCompleted; }
        set { _amountCompleted = value; }
    }

    public bool Completed
    {
        get { return _completed; }
        set { _completed = value; }
    }

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent(int points)
    {
        _amountCompleted += 1;
        _points += points;
        if (_amountCompleted == _target)
        {
            _completed = true;
            _points += _bonus;
        }
    }

    public override bool IsComplete()
    {
        return _completed;
    }

    public override string GetDetailsString()
    {
        return $"[{(_completed ? "X" : " ")}] {_shortName}: {_description} - {this._points} points (Completed {_amountCompleted}/{_target} times)";
    }

    public override string GetStringRepresentation()
    {
        return $"{_shortName}|{_description}|{this._points}|{_amountCompleted}|{_target}|{_bonus}|{_completed}";
    }
}
