using System;
using System.Globalization;





class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        Console.WriteLine(DisplayResult(name, square));

    }

    static void DisplayWelcome()
{
    Console.WriteLine("Welcome To The Program!");
}

static string PromptUserName()
{
    Console.Write("Enter your name: ");
    string name = Console.ReadLine();
    return name;
}

static int PromptUserNumber()
{
    Console.Write("Enter your favorite number: ");
    string getNumber = Console.ReadLine();
    int number = int.Parse(getNumber);
    return number;
}


static int SquareNumber(int number)
{
    return number * number;
}


static string DisplayResult(string name, int number)
{
    return $"Brother {name}, the square of your number is {number}";
}


}