using System;

public class Running :Activity
{
    private double _distance;

    public Running (string date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double CalcSpeed()
    {
        return (_distance/base.GetMinute()) * 60;
    }

     public override double CalcPace()
    {
        return (base.GetMinute()/_distance);
    }

    public override string GetSummary()
    {
        return $"{base.GetDate()} {this.GetType()} ({base.GetMinute()} min): Distance {_distance:F2} km, Speed: {CalcSpeed():F2} kph, Pace: {CalcPace():F2} min per km";
    }
}