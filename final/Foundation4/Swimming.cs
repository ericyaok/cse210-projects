using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming (string date, int minutes, int lap) : base(date, minutes)
    {
        _laps = lap;
    }

    public override double CalcDistance()
    {
        return (_laps * 50)/1000;
    }

     public override double CalcSpeed()
    {
        return (CalcDistance()/base.GetMinute()) * 60;
    }

     public override double CalcPace()
    {
        return (60/CalcSpeed());
    }

    public override string GetSummary()
    {
        return $"{base.GetDate()} {this.GetType()} ({base.GetMinute()} min): Distance {CalcDistance():F2} km, Speed: {CalcSpeed():F2} kph, Pace: {CalcPace():F2} min per km";
    }
}