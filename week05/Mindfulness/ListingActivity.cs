class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    public ListingActivity(string name, string description, int count) : base(name, description)
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