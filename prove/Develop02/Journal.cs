using System;

public class Journal
{
    public _journalEntry;


    public List<Entry> _entries = new List<Entry>();


    public void Display ()

    {
        Console.WriteLine($"who: {_userPrompt}");
        Console.WriteLine("Entries");

        foreach (Entry entries in _journalEntr)

    }


    
}