using System;

public class BreathActivity : Activity
{
    
    private string _breathIn = "";
    private string _breathOut = "";
    public BreathActivity(string startingMessage, string endMessage, string showAnimation, string breathIn, string _breathOut)
    : base(startingMessage , showAnimation, endMessage)
    {
        
        _breathIn = breathIn;
       //_breathOut = breathOut;

    }
    public string GetActivityDiscription()
    {
        return  $"{_breathIn}  ";
    }
}
