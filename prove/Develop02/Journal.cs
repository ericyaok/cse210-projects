using System;

public class Journal
{
    public List<Entry> _allEntries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _allEntries.Add(entry);

    }

    public void DisplayAllEntries()
    {
        foreach (Entry entry in _allEntries)
        {
            string output = entry.DisplayEntry();
            Console.WriteLine(output);
        }
    }

}