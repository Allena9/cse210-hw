using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int length, double speed) : base(date, length, "Cycling")
    {
        _speed = speed;
    }

    public override double Distance()
    {
        return base.GetLength() / Pace();
    }

    public override double Speed()
    {
        return _speed;
    }

    public override double Pace()
    {
        return 60.0 / _speed;
    }
}
