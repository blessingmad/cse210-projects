using System;
public class readSriptures : Goals
{
    private double _duration ;
    private double _addPoints ;
    public readSriptures(string markComplete, double duration, double addPoints) : base (markComplete)
    {
        _duration = duration;
        _addPoints = addPoints;
    }
    public override double GetRecord()
    {
        return   _duration;
    }
}