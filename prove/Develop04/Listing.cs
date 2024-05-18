using System;

public class Listing : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public Listing(string name, string description) : base(name, description)
    {

    }


    private void setCount()
    {
        _count += 1;
    }

    public void Run()
    {
        base.DisplayStartingMessage();

        Console.WriteLine("List as many reponses you can to the following prompt:");
        DisplayRandomPrompt();
        Console.Write("You may begin in:  ");
        base.ShowCountDown();
        Console.WriteLine(" ");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(base.getDuration());


        while (DateTime.Now < endTime)
        {
            GetResponseList();

        }

        Console.WriteLine($"You listed {_count} items");
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        base.DisplayEndingMessage();
    }


    private void DisplayRandomPrompt()
    {
        Random random = new Random();
        string randomPrompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine($"---{randomPrompt}---");

    }

    private void GetResponseList()
    {
        Console.Write("> ");
        string response = Console.ReadLine();
        setCount();
    }

}