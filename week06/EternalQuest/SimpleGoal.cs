using System.Text.Json.Serialization;
public class SimpleGoal : Goal
{
    [JsonInclude]
    private bool _isComplete;

    // Parameterless constructor for JSON deserialization
    public SimpleGoal() : base()
    {
        _isComplete = false;
    }

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return _points;
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }

}