using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade in percentage");
        string getScore = Console.ReadLine();
        int score = int.Parse(getScore);
        string letter = "";

        if (score >= 90)
        {
            letter = "A";
        }
        else if (score >= 80)
        {
            letter = "B";
        }
        else if (score >= 70)
        {
            letter = "C";
        }
        else if (score >= 60)
        {
            letter = "D";
        }
        else if (score < 60)
        {
            letter = "F";
        }
 

        Console.WriteLine($"Your grade is {letter}");

        if (score >= 70)
        {
            Console.WriteLine("Hurray! You have passed this course");
        }
        else 
        {
            Console.WriteLine("Sorry, you will need to resit this course");
        }
    }
}