using System;

class Program
{
    static void Main(string[] args)
    {

        string option;
        ConsoleKeyInfo keyInfo;
        Reference reference = new Reference("John", 10, 30);
        Scripture scripture = new Scripture("I and my father are one.", reference);
        Console.WriteLine(scripture.DisplayScripture());


        do
        {

            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            option = Console.ReadLine();
            keyInfo = Console.ReadKey(true);

            Console.Clear();

            if (keyInfo.Key == ConsoleKey.Enter)
            {
                scripture.HideWordsRandomly();
                Console.WriteLine(scripture.DisplayScripture());
            }

            if (option == "quit" || scripture.IsAllHidden())
            {
                break;
            }
        } while (keyInfo.Key == ConsoleKey.Enter);

    }

}