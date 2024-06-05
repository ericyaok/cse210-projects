using System;

public class Reception : Event
{
    private string _email;

    public Reception (string title, string description, string date, string time, Address address, string email) : base( title, description, date, time, address)
    {
        _email = email;
    }

    public void DisplayFullDetails()
    {  
        Console.WriteLine(base.StandardDetails());
        Console.WriteLine($"Email to RSVP: {_email}");
    }

}