public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(double distance, double length) : base(length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetPace()
    {
        return _lenInMin / _distance;
    }
    public override double GetSpeed()
    {
        return 60.0 / GetPace();
    }
}