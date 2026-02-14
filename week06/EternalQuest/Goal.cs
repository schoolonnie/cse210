using System.Text.Json.Serialization;
public abstract class Goal
{
    [JsonInclude]
    private string _shortName;
    [JsonInclude]
    private string _description;
    [JsonInclude]
    protected int _points;

    // Parameterless constructor for JSON deserialization
    protected Goal()
    {
        _shortName = "";
        _description = "";
        _points = 0;
    }

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public virtual string GetDetailsString()
    {
        string checkbox = "[ ]";
        string details = "";

        if (IsComplete())
        {
            checkbox = "[x]";
        }
        Type actualType = this.GetType(); 

        if (actualType == typeof(SimpleGoal) || actualType == typeof(ChecklistGoal))
        {
            details = ($"{checkbox} | {_shortName} - {_description}");
        }
        else if (actualType == typeof(EternalGoal))
        {
            details = ($"{_shortName} - {_description}");
        }
        
        return details;
    }
    public string GetName()
    {
        return _shortName;
    }
}