class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
    }

    public string GetRandomPrompt()
    {
        return "";
    }

    public string GetRandomQuestion()
    {
        return "";
    }

    public void DisplayPrompt()
    {

    }

    public void DisplayQuestions()
    {

    }
}