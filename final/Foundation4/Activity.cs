using System;

public class Activity
{
    private string _date;
    private int _minutes;

    public Activity (string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public string GetDate()
    {
        return _date;
    }

    public int GetMinute()
    {
        return _minutes;
    }

    public virtual double CalcDistance(){
        return 0.00;
    }

    public virtual double CalcPace(){
        return 0.00;
    }
    
    public virtual double CalcSpeed(){
        return 0.00;
    }

    public virtual string GetSummary(){
        return "Default summary";
    }
}