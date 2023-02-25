using System;

public class Activity
{
    private string _startingMessage = "";
    private string _endMessage = "";
    private string _showAnimation = "";

    public Activity (string startingMessage, string endMessage, string showAnimation)

    {
        _startingMessage = startingMessage;
        _endMessage = endMessage;
        _showAnimation = showAnimation; 
    }
    public string GetStartingMessage()
    {
        return _startingMessage;
    }
    public string GetEndMessage()
    
    {
        return _endMessage;
    }
    
    
    public string GetDetails()
    {
        return $"{_startingMessage } {_endMessage} {_showAnimation}";
    }
}