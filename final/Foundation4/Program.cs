using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");
        List<Activity> activities = new List<Activity>();

        Running newRunning = new Running("22nd Nov 2024", 54, 44.3);
        Cycling newCycling = new Cycling("22nd Nov 2024", 54, 33);
        Swimming newSwimming = new Swimming("22nd Nov 2024", 54, 20);

        activities.Add(newRunning);
        activities.Add(newCycling);
        activities.Add(newSwimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}