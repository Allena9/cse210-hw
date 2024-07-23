using System;

public class EternalGoal : Goal
{
    public EternalGoal(string shortName, string description, string points) : base(shortName, description, points)
    {

    }

    public override string RecordEvent()
    {
        return _points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName}_{_description}_{_points}";
    }
}