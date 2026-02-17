public class SwimmingActivity : Activity
{
    private double _laps;
    public SwimmingActivity(double laps, double length) : base(length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50.0 / 1000.0;
    }
    public override double GetPace()
    {
        return _lenInMin / GetDistance();
    }
    public override double GetSpeed()
    {
        return 60.0 / GetPace();
    }
}