using System;

public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int length, double distance) : base(date, length, "Running")
    {
        _distance = distance;
    }

    public override double Distance()
    {
        return _distance;
    }

    public override double Speed()
    {
        return _distance / base.GetLength() * 60;
    }

    public override double Pace()
    {
        return 60.0 / Speed();
    }
}