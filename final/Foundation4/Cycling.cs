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

}