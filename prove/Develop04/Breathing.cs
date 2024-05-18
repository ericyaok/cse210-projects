using System;

public class Breathing : Activity
{
    public Breathing(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        base.DisplayStartingMessage();
        

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(base.getDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("Breath in .......");
            base.ShowCountDown();
            Console.WriteLine("");
            Console.Write("Now, breath out .........");
            base.ShowCountDown();
            Console.WriteLine(" ");
            Console.WriteLine(" ");

        }

        base.DisplayEndingMessage();
    }

}