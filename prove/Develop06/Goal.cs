public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;
    protected bool _completed;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
        _completed = false;
    }

    public abstract void RecordEvent(int points);
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
    public abstract string GetStringRepresentation();
}