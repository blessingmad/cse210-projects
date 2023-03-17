using System;
public class readSriptures : Goals
{
    private string _duration ;
    private string _addPoints ;
    public readSriptures(string markComplete, string duration, string addPoints) : base (markComplete)
    {
        _duration = duration;
        _addPoints = addPoints;
    }
    public override string GetRecord()
    {
        return   _duration;
    }
}