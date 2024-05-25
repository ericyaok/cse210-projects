using System;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void Start()
    {
        string playerInfo = DisplayerPlayerInfo();
        Console.WriteLine(playerInfo);
        Console.WriteLine("");

        List<string> _menu = new List<string>
        {
        "Create New Goal",
        "List Goals",
        "Save Goals",
        "Load Goals",
        "Record Goals",
        "Quit"
       };


        Console.WriteLine("Menu Options:");
        for (int i = 0; i < _menu.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_menu[i]}");
        }
        Console.Write("Select a choice from the menu: ");
    }


    public string DisplayerPlayerInfo()
    {
        return $"You have {_score} points.";
    }

    public void CreateGoal()
    {
        ListGoalNames();

        string getOption = Console.ReadLine();
        int goalOption = (int.Parse(getOption));

        string name;
        string description;
        int points;
        int target;
        int bonus;

        Console.Write("What is the name of your goal? ");
        name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        description = Console.ReadLine();

        Console.Write("What is the amount of point associated with this goal? ");
        string getPoints = Console.ReadLine();
        points = (int.Parse(getPoints));

        if (goalOption == 1)
        {
            SimpleGoal newGoal = new SimpleGoal(name, description, points);
            _goals.Add(newGoal);
        }

        if (goalOption == 2)
        {
            EternalGoal newGoal = new EternalGoal(name, description, points);
            _goals.Add(newGoal);
        }

        if (goalOption == 3)
        {
            Console.Write("What is the target? ");
            string getTarget = Console.ReadLine();
            target = (int.Parse(getTarget));

            Console.Write("What is the bonus? ");
            string getBonus = Console.ReadLine();
            bonus = (int.Parse(getBonus));

            ChecklistGoal newGoal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(newGoal);
        }

    }

    public void ListGoalNames()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. CheckListGoal");
        Console.Write("Which type of Goal would you like to create? ");

    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename of the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);

            foreach (var goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename of the goal file? ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines.Skip(1))
        {
            string[] parts = line.Split(",");
            string goalType = parts[0];
            string getPoint = parts[3];


            int point = (int.Parse(getPoint));


            if (goalType == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(parts[1], parts[2], point));
            }

            if (goalType == "EternalGoal")
            {
                _goals.Add(new EternalGoal(parts[1], parts[2], point));
            }

            if (goalType == "ChecklistGoal")
            {
                string getTarget = parts[4];
                string getBonus = parts[5];
                int target = (int.Parse(getTarget));
                int bonus = (int.Parse(getBonus));

                _goals.Add(new ChecklistGoal(parts[1], parts[2], point, target, bonus));
            }

        }

    }

    public void RecordGoals()
    {
        Console.WriteLine("The goals are: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].getName()}");
        }

        Console.Write("Which goal did you accomplish? ");
        Console.WriteLine(" ");
        string getRecord = Console.ReadLine();
        int recordOption =(int.Parse(getRecord));

        Goal goalToRecord = _goals[recordOption - 1];
        int points = goalToRecord.RecordEvent();
        _score = _score + points;

        Console.WriteLine($"Congratulations! You  have earned {points} points");
        Console.WriteLine($"You now have {_score} points");
        Console.WriteLine(" ");
    }

}











