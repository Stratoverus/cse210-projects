class SwimmingActivity : Activity
{
    double _laps;
    public SwimmingActivity(string date, int minutes, double laps) : base (date, minutes)
    {
        _laps = laps;
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