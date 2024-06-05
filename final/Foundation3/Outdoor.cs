using System;

public class Outdoor : Event
{
    private string _weather;

    public Outdoor (string title, string description, string date, string time, Address address, string weather) : base( title, description, date, time, address)
    {
        _weather = weather;
    }

    public void DisplayFullDetails()
    {  
        Console.WriteLine(base.StandardDetails());
        Console.WriteLine($"Forecasted Weather: {_weather}");
    }

}