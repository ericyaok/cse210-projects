using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "BloomHire";
        job1._startYear = 2022;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._jobTitle = "Cloud Engineer";
        job2._company = "ScaleCapacity";
        job2._startYear = 2021;
        job2._endYear = 2022;


        Resume myResume = new Resume();
        myResume._name = "Eric Kodzi";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();
    }
}