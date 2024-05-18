using System;

public class Menu
{
    private List<string> _menu = new List<string> 
    { 
        "Start breathing activity", 
        "Start reflecting activity", 
        "Start listing activity", 
        "Quit" 
    };
    private int _option;

    public Menu()
    {

    }

    private void setOption(int option)
    {
        _option = option;

    }

    public int getOption()
    {
        return _option;
    }

    public void DisplayMenu()
    {
        Console.WriteLine("Menu Options:");

        for (int i = 0; i < _menu.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_menu[i]}");
        }

        Console.Write("Select a choice from the menu: ");
        string optionString = Console.ReadLine();
        setOption(int.Parse(optionString));
        Console.Clear();

    }

}