using System;

public class Entry
{

    public string _prompt;
    public string _response;
    public string _date;

    public string DisplayEntry()
    {
        string entry = (@$"Date: {_date} - Prompt: {_prompt} 
        {_response}
        
        ");

        return entry;
    }

}