class RunningActivity : Activity
{
    double _distance;
    public RunningActivity(string date, int minutes, double distance) : base (date, minutes)
    {

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