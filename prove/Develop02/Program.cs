using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Entry myEntry = new Entry();
        myEntry.Hold("What is your name?", "Austin Allen", "8 May 2023");

        Entry theEntry = new Entry();
        theEntry.Hold("What is your favorite color?", "Billy Bob", "8 May 2323");

        Journal journal = new Journal();
        journal.AddEntry(myEntry);
        journal.AddEntry(theEntry);

        List<Entry> entries = journal.GetAllEntries();
        foreach (Entry entry in entries)
        {
            string message = entry.ConvertToString();
            Console.WriteLine(message);
        }

        Prompts prompt = new Prompts();
        Console.WriteLine(prompt.GetRandomPrompt());
        
    }
}