using System;

public class Reflecting : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?  ",
        "Have you ever done anything like this before?  ",
        "How did you get started?  ",
        "How did you feel when it was complete?  ",
        "What made this time different than other times when you were not as successful?  ",
        "What is your favorite thing about this experience?  ",
        "What could you learn from this experience that applies to other situations?  ",
        "What did you learn about yourself through this experience?  ",
        "How can you keep this experience in mind in the future?  ",
    };

    public Reflecting(string name, string description) : base(name, description)
    {

    }


    private string GetRandomPrompt()
    {
        Random random = new Random();
        string randomPrompt = _prompts[random.Next(_prompts.Count)];

        return $"---{randomPrompt}---";
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        string randomQuestion = _questions[random.Next(_questions.Count)];

        return randomQuestion;
    }

    public void Run()
    {
        base.DisplayStartingMessage();


        Console.WriteLine("Consider the following prompt:");
        DisplayRandomPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue:  ");


        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        if (keyInfo.Key == ConsoleKey.Enter)
        {
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Now ponder on each of the following questions as they related to the experience");
            Console.Write("You may begin in:  ");
            base.ShowCountDown();
            Console.WriteLine(" ");
            Console.Clear();

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(base.getDuration());

            while (DateTime.Now < endTime)
            {
                DisplayRandomQuestion();

            }
        }

        Console.WriteLine(" ");
        Console.WriteLine(" ");
        base.DisplayEndingMessage();
    }

    private void DisplayRandomPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    private void DisplayRandomQuestion()
    {
        Console.Write($"> {GetRandomQuestion()}");
        base.ShowSpinner(5);
        Console.WriteLine(" ");
    }

}