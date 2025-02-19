class BicycleActivity : Activity
{
    private double _speed;
    public BicycleActivity(string date, int minutes, string activityName, double speed) : base (date, minutes, activityName)
    {
        _speed = speed;
    }

    public override string GetDistance()
    {
        double hours = _minutes / 60;
        double distance = _speed * hours;
        return $"{distance} mile(s)";
    }

    public override string GetSpeed()
    {
        return $"{_speed} mph";
    }

    public override string GetPace()
    {
        double hours = _minutes / 60;
        double distance = _speed * hours;
        double pace = _minutes / distance;
        return $"{pace} minutes per mile";    
    }
}