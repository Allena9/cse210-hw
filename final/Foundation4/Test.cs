using System;

public class Test
{
    private List<Activity> _activities;
    private Random _ran;
    private double _ranStart;
    private double _ranEnd;

    public Test()
    {
        _activities = [];
        _ran = new();
        _ranStart = 0.1;
        _ranEnd = 30.1;
    }

    public void RunTest()
    {
        AddActivities();

        DisplaySummaries();
    }

    public void DisplaySummaries()
    {
        Console.Clear();

        foreach(Activity act in _activities)
        {
            Console.WriteLine(act.GetSummary());
        }

        Console.WriteLine();
    }

    public void AddActivities()
    {
        Running run = new(RandomDate(), _ran.Next(5,121), _ran.NextDouble() * (_ranEnd - _ranStart));
        Cycling cycle = new(RandomDate(), _ran.Next(5,121), _ran.NextDouble() * (_ranEnd - _ranStart));
        Swimming swim = new(RandomDate(), _ran.Next(5,121), _ran.NextDouble() * (_ranEnd - _ranStart));

        _activities.Add(run);
        _activities.Add(cycle);
        _activities.Add(swim);
    }

    public DateTime RandomDate()
    {
        DateTime date = new(_ran.Next(2023,2025), _ran.Next(1,13), _ran.Next(1,32));

        return date;
    }
}