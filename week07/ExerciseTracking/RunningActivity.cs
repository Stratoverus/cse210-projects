class RunningActivity : Activity
{
    private double _distance;
    public RunningActivity(string date, double minutes, string activityName, double distance) : base (date, minutes, activityName)
    {
        _distance = distance;
    }

    public override string GetDistance()
    {
        return $"{_distance} miles";
    }

    public override string GetSpeed()
    {
        double hours =  _minutes / 60;
        double speed = _distance / hours;
        return $"{speed} mph";
    }

    public override string GetPace()
    {
        double pace = _minutes / _distance;
        return $"{pace} minutes per mile";
    }
}