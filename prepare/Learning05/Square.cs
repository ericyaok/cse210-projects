using System;

public class Square : Shape
{
    private float _side;

    public Square(string color,float side) : base(color)
    {
        _side = side;
    }

   
    public override string GetArea()
    {
        float area = _side * _side;
        return $"Area of the shape is {area}";
    }
}