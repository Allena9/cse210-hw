using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry()
    {
        //Assign the current date
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
        //Assign a prompt to the entry
        PromptGenerator prompt = new PromptGenerator();
        _promptText = prompt.GetRandomPrompt();

    }

    public void RunEntry()
    {
        //Displays prompt and gets response.
        Console.WriteLine(_promptText);
        _entryText = Console.ReadLine();
    }
    public void Display()
    {
        Console.WriteLine(_date);
        Console.WriteLine(_promptText);
        Console.WriteLine(_entryText);
    }
}