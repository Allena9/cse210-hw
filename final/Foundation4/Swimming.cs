using System;

public class Swimming : Activity
{
    private double _numLaps;

    public Swimming(DateTime date, int length, double numLaps) : base(date, length, "Swimming")
    {
        _numLaps = numLaps;
    }

    public override double Distance()
    {
        return _numLaps * 50 / 1000 * 0.62;
    }

    public override double Speed()
    {
        return Distance() / base.GetLength() * 60;
    }

    public override double Pace()
    {
        return 60 / Speed();
    }
}