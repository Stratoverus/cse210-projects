using System;

public class PromptGenerator
{

    public List<string> _prompts = new List<string>{"What was the most impactful thing that happened to you today?", "What are three things that you are grateful for today and why?", "What are some mini-miracles that happened today?", "What did you study today in the Gospel?", "Who did you serve today and why?"};

    public string GetRandomPrompt()
    {
        Random rng = new Random();

        int index = rng.Next(_prompts.Count);
        string prompt = _prompts[index];
        return prompt;
    } 
}