using System;
using System.Runtime.Intrinsics.X86;

public abstract class Activity
{
    private DateTime _date;
    private int _length;
    private string _type;

    public Activity(DateTime date, int length, string type)
    {
        _date = date;
        _length = length;
        _type = type;
    }

    public string GetSummary()
    {
        return $"{_date.ToString("dd MMMM yyyy")} {_type} ({_length} min)-Distance {Distance():F1} miles, Speed {Speed():F1} mph, Pace: {Pace():F2} min per mile";
    }

    public double GetLength()
    {
        return _length;
    }

    public abstract double Distance();
    public abstract double Speed();
    public abstract double Pace();

}