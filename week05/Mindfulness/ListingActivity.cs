class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    public ListingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
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
        List<string> inputs = new();
        while (duration >= 0)
        {
            Console.WriteLine("Type your prompt.");
            string input = Console.ReadLine();
            inputs.Add(input);
        }
        return inputs;
    }
}