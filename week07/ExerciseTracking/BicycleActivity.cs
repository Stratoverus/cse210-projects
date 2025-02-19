class BicycleActivity : Activity
{
    private double _speed;
    public BicycleActivity(string date, int minutes, string activityName, double speed) : base (date, minutes, activityName)
    {
        _speed = speed;
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