using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target;
    private int _bonus;



    public ChecklistGoal(string name, string description, int point, int target, int bonus) : base(name, description, point)
    {
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        _amountCompleted += 1;

        if (IsComplete())
        {
            return base.getPoint() + _bonus;
        }
        else
        {
            return base.getPoint();
        }
    }

    public  bool IsComplete()
    {
        return _amountCompleted == _target;
    }

    public override string GetDetailsString()
    {
        string complete;
        if (IsComplete())
        {
            complete = "X";
        }
        else
        {
            complete = "";
        }
        return $"[{complete} ] {base.getName()} ({base.getDescription()}) --- Currenlty completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal, {base.getName()},{base.getDescription()},{base.getPoint()},{_bonus},{_target},{_amountCompleted}";
    }

}