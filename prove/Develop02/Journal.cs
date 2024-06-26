using System;
using System.Diagnostics.Metrics;
using System.IO;
public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = [];
    }

    public void AddEntry()
    {
        //Creates new Entry object
        Entry entry = new Entry();
        entry.RunEntry();
        //Adds new entry to list of entries
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        //Goes through each entry in the list and displays it
        foreach(Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine("");
        }
    }

    public void SaveToFile()
    {
        //Asks the name of the file. 
        Console.WriteLine("What is the file name?");
        string fileName = Console.ReadLine();

        //Opens the requested file and inputs each entry in the journal
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry num in _entries)
            {
                outputFile.WriteLine(num._date);
                outputFile.WriteLine(num._promptText);
                outputFile.WriteLine(num._entryText);
            }
        }
    }

    public void LoadFromFile()
    {
        //Clears current journal
        _entries.Clear();

        //Requests file name
        Console.WriteLine("What is the file name?");
        string fileName = Console.ReadLine();
        
        //Preps variables for loops
        Entry entry = new Entry();
        int counter = 0;
        
        //Opens requested file. Inputs Entry variables and saves entry to journal. Creates new Entry object every 3 lines. 
        string[] lines = System.IO.File.ReadAllLines(fileName);
        {
            foreach (string line in lines)
            {
                //Checks if the Entry has all variables filled
                if (counter == 3)
                {
                    entry = new Entry();
                    counter = 0;
                }

                //Adds 1 to counter
                counter++;

                //Checks which variable needs line. 
                if (counter == 1)
                {
                    entry._date = line;
                }
                else if (counter == 2)
                {
                    entry._promptText = line;
                }
                else if (counter == 3)
                {
                    entry._entryText = line;
                    _entries.Add(entry);
                }
            }
        }
    }
}