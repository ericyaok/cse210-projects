using System;

public class Cycling : Activity
{
    private double _speed;

    public Cycling (string date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double CalcDistance()
    {
        return (base.GetMinute() * _speed)/60;
    }

     public override double CalcPace()
    {
        return (60/_speed);
    }

    public override string GetSummary()
    {
        return $"{base.GetDate()} {this.GetType()} ({base.GetMinute()} min): Distance {CalcDistance():F2} km, Speed: {_speed:F2} kph, Pace: {CalcPace():F2} min per km";
    }
}