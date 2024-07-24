using System;

public class Reception : Event
{
    private string _email;

    public Reception(string title, string description, DateTime date, string time, Address address, string email) : base(title, description, date, time, address, "Reception")
    {
        _email = email;
    }

    public string FullDetails(string standardDetails)
    {
        return $"{standardDetails}\nRSVP at: {_email}";
    }
}