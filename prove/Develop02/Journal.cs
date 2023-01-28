using System;

public class Journal
{
    public string _userInput;


    public List<Entry> _entries = new List<Entry>();


    public void Display ()

    {
        Console.WriteLine($"Display: {_userInput}");
        Console.WriteLine("Entries");
        Console.WriteLine();

        foreach (Entry entries in _entries);
            entries.Display();

            


    }


    
}