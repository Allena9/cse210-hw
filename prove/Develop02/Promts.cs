using System;
using System.Collections.Generic;

///<summary>
///The responsibility of an Prompts is to store a list of premade strings, and pull them from the stored list.
///</summary>
class Prompts
{
    public List<String> promptList;
    Random random = new Random();

    //Constructor
    public Prompts()
    {
        promptList = new List<String>() {"What was something you learned today?", "Who impacted you the most today?", "What is one thing that made you smile today?", "Name three things you're greatful for.", "What was your biggest accomplishment today?"};
    }
    //Gets a random prompt from the promptList
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