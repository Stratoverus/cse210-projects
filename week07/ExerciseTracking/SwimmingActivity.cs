class SwimmingActivity : Activity
{
    private double _laps;
    public SwimmingActivity(string date, int minutes, string activityName, double laps) : base (date, minutes, activityName)
    {
        _laps = laps;
    }

    public override string GetDistance()
    {
        return "";
    }

    public override string GetSpeed()
    {
        return "";
    }

    public override string GetPace()
    {
        return "";
    }
}