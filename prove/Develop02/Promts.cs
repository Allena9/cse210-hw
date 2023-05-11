using System;
using System.Collections.Generic;

///<summary>
///The responsibility of an Prompts is to store a list of premade strings, and pull them from the stored list.
///</summary>
class Prompts
{
    public List<String> promptList;
    Random random = new Random();
    public Prompts()
    {
        promptList = new List<String>() {"What was something you learned today?", "Who impacted you the most today?", "What is one thing that made you smile today?", "Name three things you're greatful for.", "What was your biggest accomplishment today?"};
    }

    public string GetRandomPrompt()
    {
        int count = promptList.Count;
        string currentPrompt = promptList[random.Next(0,count)];

        return currentPrompt;
    }

    public void Initialize()
    {
        
    }
}