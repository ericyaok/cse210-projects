using System;

public class Options
{
    public List<string> _optionsList = new List<string> {"Write","Display","Load","Save","Quit"};

    public void DisplayOptionsList()
    {

        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices.");

        for (int i = 0; i < _optionsList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_optionsList[i]}");
        }

    }

}