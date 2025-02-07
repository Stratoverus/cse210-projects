class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string> 
    {
        "Think of a time when you stood up for someone else.", 
        "Think of a time when you did something really difficult.", 
        "Think of a time when you helped someone in need.", 
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string> 
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    public ReflectingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        int duration = GetDuration();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        Console.WriteLine("Reflect on the following question for ten seconds, afterwards, another will appear.");
        while (DateTime.Now < futureTime)
        {
            DisplayQuestions();
            ShowSpinner(10);
            Console.WriteLine("Now think about the next question...");
        }
        ShowSummary();
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
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestions()
    {
        Console.WriteLine(GetRandomQuestion());
    }
}