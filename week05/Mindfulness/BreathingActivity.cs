class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        DateTime currentTime = DateTime.Now;
        while (currentTime < futureTime)
        {
            Console.WriteLine("Breathe in....");
            Console.WriteLine("");
            ShowCountDown(5);
            Console.Clear();
            Console.WriteLine("Breathe out....");
            Console.WriteLine("");
            ShowCountDown(5);
            Console.Clear();
        }
        DisplayEndingMessage();
    }
}