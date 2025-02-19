class BicycleActivity : Activity
{
    double _speed;
    public BicycleActivity(string date, int minutes, double speed) : base (date, minutes)
    {
        _speed = speed;
    }
}