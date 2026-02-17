public abstract class Activity
{
    private string _date;
    protected double _lenInMin;

    public Activity(double length)
    {
        _date = DateOnly.FromDateTime(DateTime.Now).ToString("MM-dd-yyyy");
        _lenInMin = length;
    }

    public abstract double GetDistance();
    public abstract double GetPace();
    public abstract double GetSpeed();

    public void GetSummary()
    {
        string activityType = "";
        switch (this)
        {
            case RunningActivity:
                activityType = "Running";
                break;
            case CyclingActivity:
                activityType = "Cycling";
                break;
            case SwimmingActivity:
                activityType = "Swimming";
                break;
        }

        Console.WriteLine($"{_date}, {activityType} ({_lenInMin} min)- Distance: {Math.Round(GetDistance(), 2)} km, Speed: {Math.Round(GetSpeed(), 2)} kph, Pace: {Math.Round(GetPace(), 2)} min per km");
    }
}