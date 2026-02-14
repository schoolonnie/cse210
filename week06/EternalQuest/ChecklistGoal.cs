using System.Text.Json.Serialization;
public class ChecklistGoal : Goal
{
    [JsonInclude]
    private int _amountCompleted;
    [JsonInclude]
    private int _target;
    [JsonInclude]
    private int _bonus;
    [JsonInclude]
    private bool _isComplete = false;

    // Parameterless constructor for JSON deserialization
    public ChecklistGoal() : base()
    {
        _amountCompleted = 0;
        _target = 0;
        _bonus = 0;
    }

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override int RecordEvent()
    {
        _amountCompleted ++;
        if (_amountCompleted == _target)
        {
            Console.WriteLine($"You have completed the goal {_target} times! You received {_bonus} points!");
            _isComplete = true;
            return _points + _bonus;
        }
        else
        {
            return _points;
        }
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public string TimesComplete()
    {
        string timesDone = ($"[{_amountCompleted}/{_target}]");
        return timesDone;
    }
    public override string GetDetailsString()
    {
        string timesDone = TimesComplete();
        string baseMessage = base.GetDetailsString();
        return ($"{timesDone} | ") + baseMessage;
    }

}