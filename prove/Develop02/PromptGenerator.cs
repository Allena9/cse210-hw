using System;

public class PromptGenerator
{
    public List<string> _prompts;

    public PromptGenerator()
    {
        //Assigns prompts to the list of prompts
        _prompts = ["Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?", "Whats a problem I solved today?"];
    }

    public string GetRandomPrompt()
    {
        //Creates a random number to pick from the list of prompts and returns that prompts from its list.
        Random rnd = new Random();
        int num = rnd.Next(5);
        string passThrough = _prompts[num];

        return passThrough;
    }
}