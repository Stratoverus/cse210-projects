using System.Xml;

class RunningActivity : Activity
{
    private double _distance;
    public RunningActivity(string date, int minutes, string activityName, double distance) : base (date, minutes, activityName)
    {
        _distance = distance;
    }

    public override string GetDistance()
    {
        return $"{_distance} miles";
    }

    public override string GetSpeed()
    {
        double hours =  ConvertToHour();
        double speed = _distance / hours;
        return $"{speed} mph";
    }

    public override string GetPace()
    {
        return "";
    }
}