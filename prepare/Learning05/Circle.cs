using System;

public class Circle : Shape
{
    private float _radius;

    public Circle(string color,float radius) : base(color)
    {
        _radius = radius;
    }

   
    public override string GetArea()
    {
        double area = 3.14 * _radius * _radius;
        return $"Area of the shape is {area}";
    }
}