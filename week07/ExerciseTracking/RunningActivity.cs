class RunningActivity : Activity
{
    private double _distance;
    public RunningActivity(string date, int minutes, string activityName, double distance) : base (date, minutes, activityName)
    {

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