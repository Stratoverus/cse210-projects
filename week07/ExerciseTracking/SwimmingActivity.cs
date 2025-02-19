class SwimmingActivity : Activity
{
    double _laps;
    public SwimmingActivity(string date, int minutes, double laps) : base (date, minutes)
    {
        _laps = laps;
    }
}