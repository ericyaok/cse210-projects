using System;

class Program
{
    static void Main(string[] args)
    {
        int number = 0;
        int guess = 1;

    
        while (number != guess)
        {
            Random randomGenerator = new();
            number = randomGenerator.Next(1, 100);

            Console.WriteLine("What is your guess number?");
            string getGuess = Console.ReadLine();
            guess = int.Parse(getGuess);

            if (number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (number < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("Yay!! You guessed it");
            }

        }
    }
}