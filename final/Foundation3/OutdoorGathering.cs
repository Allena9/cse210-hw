using System;

public class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string title, string description, DateTime date, string time, Address address, string weather) : base(title, description, date, time, address, "Outdoor Gathering")
    {
        _weather = weather;
    }

    public string FullDetails(string standardDetails)
    {
        return $"{standardDetails}\nExpected weather: {_weather}";
    }
}