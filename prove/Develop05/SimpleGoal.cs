using System;

public class SimpleGoal : Goal
{
    private bool _isComplete = false;


    public SimpleGoal(string name, string description, int point) : base(name, description, point)
    {

    }

    public override int RecordEvent()
    {
        setIscomplete();
        return base.getPoint();
    }

    public bool IsComplete()
    {
        return _isComplete;
    }

    public void setIscomplete()
    {
        _isComplete = true;
    }

    public override string GetDetailsString()
    {
        string complete;
        if (IsComplete())
        {
            complete ="X";
        }
        else
        {
            complete = "";
        }
        return $"[{complete} ] {base.getName()} ({base.getDescription()})";
    }

     public override string GetStringRepresentation()
    {
        return $"SimpleGoal, {base.getName()},{base.getDescription()},{base.getPoint()},{_isComplete}";
    }

}