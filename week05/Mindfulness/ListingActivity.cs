class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    public ListingActivity(string name, string description, int duration, int count) : base(name, description, duration)
    {
        _count = count;
    }

    public void Run()
    {
        DisplayStartingMessage();
    }

    public void GetRandomPrompt()
    {

    }

    public List<string> GetListFromUser()
    {
        return [];
    }
}