using System;

class Program
{
    static void Main(string[] args)
    {
        WritingAssignment newAssignment = new WritingAssignment("Mary Waters", "Africa History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(newAssignment.GetWritingInformation());
    }
}