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

    }

    public List<string> GetListFromUser()
    {
        return [];
    }
}