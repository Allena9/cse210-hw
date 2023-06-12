using System.Collections.Generic;

///<summary>
///The responsibility of an Journal is to store entries.
///</summary>
class Journal
{
    public List<Entry> entries;
    //Constructor
    public Journal()
    {
        entries = new List<Entry>();
    }
    //Adds an entry object to the entries list
    public void AddEntry(Entry entry)
    {
        if (!entries.Contains(entry))
        {
                entries.Add(entry);
        }
    }
    //Returns the list of all entries stored in the journal
    public List<Entry> GetAllEntries()
    {
        return this.entries;
    }
}