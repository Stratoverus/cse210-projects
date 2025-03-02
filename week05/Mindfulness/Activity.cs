class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to {_name} activity.");
        Console.WriteLine($"{_description}");
        Console.Write("How many seconds for this activity? ");
        //I believe this is not a bad way to sanitize the input.
        string duration = Console.ReadLine();
        if (int.TryParse(duration, out int seconds))
        {
            _duration = seconds;
        }
        else
        {
            Console.WriteLine("Not a valid input. Defaulting to 60 seconds.");
            _duration = 60;
        }
        Console.WriteLine("Press enter when you're ready to start.");
        Console.ReadLine();
        Console.Clear();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("This was a good exercise right? Hope you're feeling better!");
        Console.WriteLine("Please enter to exit.");
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
            Console.Write("\b \b");
            
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

    public int GetDuration()
    {
        return _duration;
    }

    public void ShowSummary()
    {
        Console.Clear();
        Console.WriteLine("Activity Summary:");
        Console.WriteLine($"You completed the {_name} activity.");
        Console.WriteLine($"You did this in {_duration} seconds.");
        int longer = _duration * 2;
        Console.WriteLine($"Maybe next time you can do it for {longer} seconds?");
    }
}