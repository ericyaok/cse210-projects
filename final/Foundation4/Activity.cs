using System;

public class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
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

    public virtual double CalcDistance()
    {
        return 0.00;
    }

    public virtual double CalcPace()
    {
        return (GetMinute()/CalcDistance());
    }

    public virtual double CalcSpeed()
    {
        return (CalcDistance()/GetMinute()) * 60;
    }

    public virtual string GetSummary()
    {
        return $"{GetDate()} {this.GetType()} ({GetMinute()} min): Distance {CalcDistance():F2} km, Speed: {CalcSpeed():F2} kph, Pace: {CalcPace():F2} min per km";
    }
}