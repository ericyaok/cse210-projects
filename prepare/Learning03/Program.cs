using System;

class Program
{
    static void Main(string[] args)

    {
        Fraction unitFraction = new Fraction();
        Fraction topFraction = new Fraction(7);
        Fraction topdownFraction = new Fraction(100, 3);
        Console.WriteLine(unitFraction.GetFractionString());
        Console.WriteLine(topFraction.GetDecimalValue());
        Console.WriteLine(topdownFraction.GetFractionString());
        Console.WriteLine(topdownFraction.GetDecimalValue());
    }
}