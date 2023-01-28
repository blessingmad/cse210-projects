using System;

public class Entry
{
    public string _entryDate; 


    public string _userPrompt;

    public string _userInput;


    public int _endProgram;

    public string _displayResults;


    public void Display()

    {
        Console.WriteLine($"{_entryDate} ({_userPrompt}) {_userInput} {_displayResults}{_endProgram}");
        Console.WriteLine();
    }

}


