using System;

public class Running :Activity
{
    private double _distance;

    public Running (string date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double CalcDistance()
    {
        return _distance;
    }

}