using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, DateTime date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address, "Lecture")
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string FullDetails(string standardDetails)
    {
        return $"{standardDetails}\nSpeaker: {_speaker}\nVenu Capacity: {_capacity}";
    }
}