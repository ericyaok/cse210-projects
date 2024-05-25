using System;

class Program
{
    static void Main(string[] args)
    {

        GoalManager newGoalManager = new GoalManager();
        int option;

        do
        {
            newGoalManager.Start();
            string optionString = Console.ReadLine();
            option = (int.Parse(optionString));


            if (option == 1)
            {
                newGoalManager.CreateGoal();
            }

            if (option == 2)
            {
                newGoalManager.ListGoalDetails();
            }

            if (option == 3)
            {
                newGoalManager.SaveGoals();
            }

            if (option == 4)
            {
                newGoalManager.LoadGoals();
            }

            if (option == 5)
            {
                newGoalManager.RecordGoals();
            }

        } while (option != 6);

    }
}