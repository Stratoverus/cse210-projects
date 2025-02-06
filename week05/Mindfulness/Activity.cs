class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name} activity. {_description}");
        Console.Write("How many seconds for this activity? ");
        _duration = Convert.ToInt32(Console.ReadLine());
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("This was a good exercise right? Hope you're feeling better!");
        Console.WriteLine("Please any key to exit.");
        Console.ReadLine();
    }
//Might do a more fun animation here, we'll see what I have time for.
    public void ShowSpinner(int seconds)
    {
        while (seconds != 0)
        {
            Console.Write("+");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            seconds -= 1;
        }
    }
//I think this should work? I guess we'll see when I test it.
    public void ShowCountDown(int seconds)
    {
        while (seconds != 0)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            seconds -= 1;
            Console.Write("\b \b");
        }
    }
}