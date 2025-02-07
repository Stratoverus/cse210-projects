class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string> 
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    public ListingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        GetRandomPrompt();
        Console.WriteLine("Begin thinking about the prompt...");
        ShowCountDown(5);
        GetListFromUser();
        _count = GetListFromUser().Count();
        Console.WriteLine($"You typed {_count} line(s).");
        Console.WriteLine("Press any key to move on...");
        Console.ReadLine();
        ShowSummary();
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random rng = new Random();
        int index = rng.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine(prompt);
    }

    public List<string> GetListFromUser()
    {
        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        List<string> inputs = new();
        while (DateTime.Now < futureTime)
        {
            Console.WriteLine("Type your thoughts...");
            string input = Console.ReadLine();
            inputs.Add(input);
        }
        return inputs;
    }
}