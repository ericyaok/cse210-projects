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

}