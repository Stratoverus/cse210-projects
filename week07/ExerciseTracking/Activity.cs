class Activity
{
    private int _minutes;
    private string _date;
    private string _activityName;

    public Activity(string date, int minutes, string activityName)
    {
        _date = date;
        _minutes = minutes;
        _activityName = activityName;
    }

    public virtual string GetDistance()
    {
        return "";
    }

    public virtual string GetSpeed()
    {
        return "";
    }

    public virtual string GetPace()
    {
        return "";
    }

    public double ConvertToHour()
    {
        return _minutes / 60;
    }

    public void GetSummary()
    {
        Console.WriteLine($"{_date} {_activityName} ({_minutes} min)- Distance {GetDistance()}, Speed {GetSpeed()}, Pace: {GetPace()}");
    }
}