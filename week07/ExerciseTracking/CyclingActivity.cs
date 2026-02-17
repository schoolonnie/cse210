public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(double speed, double length) : base(length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return _speed * (_lenInMin / 60.0);
    }
    public override double GetPace()
    {
        return 60.0 / _speed;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
}