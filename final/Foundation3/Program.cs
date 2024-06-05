using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        Address eventAddress = new Address("7 Alley Street", "Lisbon","Virginia", "USA");
        Lecture newLecture = new Lecture("The Economy","Political Talk On Diversifying The Local Industry","23rd May, 2024","10:0am",eventAddress,"Mr Eric Kodzi",150);
        Reception newReception = new Reception("Tools Down", "Celebrating Industsry Players on Workers Day","23rd May, 2024","10:0am",eventAddress,"erickodzi@gmail.com");
        Outdoor newOutdoor = new Outdoor("Tools Down", "Celebrating Industsry Players on Workers Day","23rd May, 2024","10:0am",eventAddress,"Sunny with temperature above 40 Celcius");

        Console.WriteLine("..........Lecture..............");
        Console.WriteLine(newLecture.StandardDetails());
        Console.WriteLine(newLecture.ShortDescription());
        newLecture.DisplayFullDetails();

        Console.WriteLine("..........Reception..............");
        Console.WriteLine(newReception.StandardDetails());
        Console.WriteLine(newReception.ShortDescription());
        newReception.DisplayFullDetails();

        Console.WriteLine("..........Outdoor..............");
        Console.WriteLine(newOutdoor.StandardDetails());
        Console.WriteLine(newOutdoor.ShortDescription());
        newOutdoor.DisplayFullDetails();

    }
}