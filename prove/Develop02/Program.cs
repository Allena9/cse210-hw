using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
    //Creates the datetime object and saves the current date in a string
        DateTime currentTime = DateTime.Now;
        String dateText = currentTime.ToShortDateString();
    //Test for Entry Object
        Entry myEntry = new Entry();
        myEntry.Hold("Austin Allen", dateText);

        Entry theEntry = new Entry();
        Console.WriteLine(theEntry.prompt);
        theEntry.Hold(Console.ReadLine(), dateText);
    //Test for journal object
        Journal journal = new Journal();
        journal.AddEntry(myEntry);
        journal.AddEntry(theEntry);

    // Displays all current enties in the journal.
        List<Entry> entries = journal.GetAllEntries();
        foreach (Entry entry in entries)
        {
            string message = entry.ConvertToString();
            Console.WriteLine(message);
        }
    //Test for GetRandomPrompt function
        Prompts prompt = new Prompts();
        Console.WriteLine(prompt.GetRandomPrompt());

    // Test the store and read function
        Store store = new Store();
        store.store();
        store.read();
        
        

        
    }
}