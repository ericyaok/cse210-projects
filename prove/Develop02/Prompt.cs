using System;

public class Prompt
{
    public string _prompt;
    public List<string> _optionsList = new List<string> { "Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?" };

    public void DisplayPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, _optionsList.Count);
        _prompt = _optionsList[randomIndex];
        Console.WriteLine(_prompt);

    }

}