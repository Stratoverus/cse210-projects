class BicycleActivity : Activity
{
    double _speed;
    public BicycleActivity(string date, int minutes, double speed) : base (date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return 0;
    }

    public override double GetSpeed()
    {
        return 0;
    }

    public override double GetPace()
    {
        return 0;
    }
}