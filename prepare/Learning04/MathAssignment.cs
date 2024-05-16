using System;

public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problem;

    public MathAssignment(string name, string topic, string section, string problem) : base(name, topic)
    {
        _textBookSection = section;
        _problem = problem;

    }

    public string  GetHomeworkList()
    {
        return $"Section:{_textBookSection} - Problem:{_problem}";
    }

 

}