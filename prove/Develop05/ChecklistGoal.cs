using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    private bool _receivedBonus;

    public ChecklistGoal(string shortName, string description, string points, int target, int bonus, int amountCompleted) : base(shortName, description, points)
    {
        _amountCompleted = amountCompleted;
        _receivedBonus = false;
        _target = target;
        _bonus = bonus;
    }

    public override string RecordEvent()
    {
        _amountCompleted++;
        if(_target == _amountCompleted && _receivedBonus == false)
        {
            int bonusPoints = Int32.Parse(_points) + _bonus;
            _receivedBonus = true;
            return bonusPoints.ToString();
        }
        else
        {
            return _points;
        }
    }

    public override bool IsComplete()
    {
        if(_target <= _amountCompleted)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        if(IsComplete() == true)
        {
            return $"[X] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName}_{_description}_{_points}_{_bonus}_{_target}_{_amountCompleted}";
    }
}