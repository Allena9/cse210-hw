using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, string streetAddress, string city, string state, string country)
    {
        _name = name;
        _address = new(streetAddress, city, state, country);
    }

    public bool IsUsa()
    {
        return _address.IsUsa();
    }

    public string LabelFormat()
    {
        return $"{_name}\n{_address.GetLabelFormat()}";
    }
}