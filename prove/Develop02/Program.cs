using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int option;
        Options optionsList = new Options();

        Journal MainJournal = new Journal();

        do
        {
            optionsList.DisplayOptionsList();
            Console.Write("what would you like to do? ");
            string optionString = Console.ReadLine();
            option = int.Parse(optionString);

            if (option == 1)
            {
                Prompt newPrompt = new Prompt();
                newPrompt.DisplayPrompt();

                Console.Write("> ");
                string response = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._prompt = newPrompt._prompt;
                newEntry._response = response;

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                newEntry._date = dateText;


                MainJournal.AddEntry(newEntry);
            }

            else if (option == 2)
            {

                MainJournal.DisplayAllEntries();
            }

            else if (option == 3)
            {
                Console.WriteLine("What is the file name? ");
                string fileName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(fileName);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }

            }

            else if (option == 4)
            {
                Console.WriteLine("What is the file name? ");
                string fileName = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {

                    foreach (Entry entry in MainJournal._allEntries)
                    {
                        string output = entry.DisplayEntry();
                        outputFile.WriteLine(output);
                    }
                }
            }

        } while (option != 5);

    }
}