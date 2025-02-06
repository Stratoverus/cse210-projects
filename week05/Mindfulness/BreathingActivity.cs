class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        while (duration >= 0)
        {
            Console.WriteLine("Breathe in....");
            Console.WriteLine("");
            ShowCountDown(5);
            Console.Clear();
            Console.WriteLine("Breathe out....");
            Console.WriteLine("");
            ShowCountDown(5);
            Console.Clear();
            duration -= 6;
        }
        DisplayEndingMessage();
    }
}