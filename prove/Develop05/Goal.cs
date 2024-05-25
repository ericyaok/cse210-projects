using System;

public  abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _point;

    public Goal(string name, string description, int point )
    {
        _shortName = name;
        _description = description;
        _point = point;
    }


    public string getName()
    {
        return _shortName;
    }

    public string getDescription()
    {
        return _description;
    }

    public int getPoint()
    {
        return _point;
    }
    

    public abstract int RecordEvent();

    public abstract string GetDetailsString();
   

    public abstract string GetStringRepresentation();
    
}