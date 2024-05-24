using System;

public class Rectangle : Shape
{
    private float _length;
    private float _width;

    public Rectangle(string color,float length, float width) : base(color)
    {
        _width = width;
        _length = length;
    }

   
    public override string GetArea()
    {
        float area = _length * _width;
        return $"Area of the shape is {area}";
    }
}