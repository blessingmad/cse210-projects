using System;

public class BreathActivity : Activity
{
    
    private string _breathinAndout = "";
    public BreathActivity(string startingMessage, string endMessage, string showAnimation, string breathinAndout)
    : base(startingMessage , showAnimation, endMessage)
    {
        
        _breathinAndout = breathinAndout;

    }
    public string GetActivityDiscription()
    {
        return  $"{_breathinAndout}";
    }
}
