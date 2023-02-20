using System;

public class BreathActivity : Activity
{
    private string _activityDiscription = "";
    private string _breathinAndout = "";
    public BreathActivity(string startingMessage, string endMessage, string _activityDiscription, string breathinAndout)
    : base(startingMessage , endMessage)
    {
        _activityDiscription = activityDiscription;
    }
    public string GetActivityDiscription()
    {
        return _activityDiscription;
    }
}
