class SwimmingActivity : Activity
{
    private double _laps;
    public SwimmingActivity(string date, double minutes, string activityName, double laps) : base (date, minutes, activityName)
    {
        _laps = laps;
    }

    public override string GetDistance()
    {
        double distance = _laps * 50 / 1000;
        return $"{distance} km";
    }

    public override string GetSpeed()
    {
        double hours = _minutes / 60;
        double speed = _laps * 50 / 1000 / hours;
        return $"{speed} kph";
    }

    public override string GetPace()
    {
        double distance = _laps * 50 / 1000;
        double pace = _minutes / distance;
        return $"{pace} min per km";
    }
}