public class EternalGoal : Goal
{
    // Parameterless constructor for JSON deserialization
    public EternalGoal() : base()
    {
    }

    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
        
    }

    public override int RecordEvent()
    {
        return _points;
    }
    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }
}