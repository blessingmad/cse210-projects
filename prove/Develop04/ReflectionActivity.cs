using System;
public class ReflectionActivity : Activity
{
    private string _randomPrompt = "";
    private string _who ="";
    private string _sure = "";
    public ReflectionActivity(string startingMessage, string endMessage, string showAnimation, string sure, string who,string randomPrompt)
    : base (startingMessage, showAnimation, endMessage)
    {
        _randomPrompt = randomPrompt;
        _who = who;
        _sure = sure;
    }
    public string GetReflection()
    {
        return $"{_randomPrompt} {_who} {_sure}";
    }
}