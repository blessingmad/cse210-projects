using System;
public abstract class Studies
{
    private string _standardStartingMessage;
    private string _scripture;
    public Studies(string standardStartingMessage, string scripture)
    {
        _standardStartingMessage = standardStartingMessage;
        _scripture = scripture;
    }
    public string GetStartingMessage()
    {
        return _standardStartingMessage;
    }
    public string GetScripture()
    {
        return _scripture;
    }
    public abstract string GetSummary();
    
}