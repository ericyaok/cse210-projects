using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = [];

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int number;

        do
        {
            Console.Write("Enter number:");
            string getNumber = Console.ReadLine();
            number = int.Parse(getNumber);
            numbers.Add(number);

        } while(number != 0);

        int sum = 0;
        foreach (int item in numbers)
        {
            sum += item;
        }

        double average = sum / numbers.Count;

        int maximum = numbers[0];
        foreach (int item in numbers)
        {
            if (item > maximum)
            {
                maximum = item;
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {maximum}");

    

        
        

       
        


    }
}