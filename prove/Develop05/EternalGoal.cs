using System;

public class EternalGoal : Goal
{


    public EternalGoal(string name, string description, int point) : base(name, description, point)
    {

    }

    public override int RecordEvent()
    {
        return base.getPoint();
    }

    public override string GetDetailsString()
    {
       return $"[ ] {base.getName()} ({base.getDescription()})";
    }

     public override string GetStringRepresentation()
    {
        return $"EternalGoal, {base.getName()},{base.getDescription()},{base.getPoint()}";
    }

}