using System;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;

    }


    private void setDuration(int duration)
    {
        _duration = duration;

    }

    public int getDuration()
    {
        return _duration;
    }


    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine(" ");
        Console.WriteLine($"{_description}");
        Console.WriteLine(" ");
        Console.Write("How long in seconds, would you like for your session? ");
        string optionString = Console.ReadLine();
        setDuration(int.Parse(optionString));
        Console.Clear();

        Console.WriteLine("Get Ready....");
        ShowSpinner(5);
        Console.WriteLine(" ");
        Console.WriteLine(" ");

    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!!");
        ShowSpinner(5);
        Console.WriteLine($"You have completed {_duration} seconds of {_name} Activity");
        ShowSpinner(5);
        Console.Clear();

    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string> { "|", "/", "-", "\\", "|", "/", "-", "\\" };

        int i = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }

    }
    public void ShowCountDown()
    {
        int i = 4;

        while (i >= 1)
        {

            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i--;
        }

    }


}