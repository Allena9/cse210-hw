using System;

public class Event
{
    private string _title;
    private string _description;
    private DateTime _date;
    private string _time;
    private Address _address;
    private string _eventType;

    public Event(string title, string description, DateTime date, string time, Address address, string eventType)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = eventType;
    }

    public string StandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description}\nDate & time: {_date.ToString("d")} at {_time}\nLocation:\n{_address.GetAddress()}";
    }

    public string ShortDescription()
    {
        return $"Event Type: {_eventType}\nTitle: {_title}\nDate: {_date.ToString("d")}";
    }
}