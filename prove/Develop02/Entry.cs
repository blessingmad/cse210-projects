using System;

public class _journalEntry
{
    public string _entryDate; 


    public string _userPrompt;


    public int _endProgram;


    public void Display()

    {
        Console.WriteLine($"{_entryDate} ({_userPrompt}) {_endProgram}");
        Console.WriteLine();
    }

}


