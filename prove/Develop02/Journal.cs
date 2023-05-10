using System.Collections.Generic;

///<summary>
///The responsibility of an Journal is to store entries.
///</summary>
class Journal
{
    public List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }
    public void AddEntry(Entry entry)
    {
        if (!entries.Contains(entry))
        {
                entries.Add(entry);
        }
    }
    public List<Entry> GetAllEntries()
    {
        return this.entries;
    }
}