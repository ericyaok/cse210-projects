using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        // Square newSquare = new Square("blue",6);
        // Console.WriteLine(newSquare.GetColor());
        // Console.WriteLine(newSquare.GetArea());

        // Rectangle newRectangle = new Rectangle("red",6,5);
        // Console.WriteLine(newRectangle.GetColor());
        // Console.WriteLine(newRectangle.GetArea());

        // Circle newCircle = new Circle("green",5);
        // Console.WriteLine(newCircle.GetColor());
        // Console.WriteLine(newCircle.GetArea());



       
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Square("Red", 5));
        shapes.Add(new Rectangle("Blue", 4, 6));
        shapes.Add(new Circle("Green", 3));

        foreach (var shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.GetColor()}, Area: {shape.GetArea()}");
        }
    }
}