using System;

public class Resume
{
    public string _name;
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Job:");
        foreach (Job job in _jobs)
        {
            job.DisplayJobDetails();
        }

    }

}