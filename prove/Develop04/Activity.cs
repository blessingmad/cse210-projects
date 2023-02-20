using System;

public class Activity
{
    private string _startingMessage = "";
    private string _endMessage = "";
    

    public Activity (string startingMessage, string endMessage)

    {
        _startingMessage = startingMessage;
        _endMessage = endMessage; 
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
        return _startingMessage + "-" + _endMessage ;
    }
}