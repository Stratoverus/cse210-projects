class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rng = new Random();
        int index = rng.Next(_prompts.Count);
        string prompt = _prompts[index];
        return prompt;
    }

    public string GetRandomQuestion()
    {
        Random rng = new Random();
        int index = rng.Next(_questions.Count);
        string question = _questions[index];
        return question;
    }

    public void DisplayPrompt()
    {

    }

    public void DisplayQuestions()
    {

    }
}