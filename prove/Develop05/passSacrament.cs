using System;
public class passSacrament : Goals
{
    private double _twiceAmonth ;
    private double _getPoints ;
    public passSacrament(string markComplete, double twiceAmonth, double getPoints) : base (markComplete)
    {
        _twiceAmonth = twiceAmonth;
        _getPoints = getPoints;
    }
    public override double GetRecord()
    {
        return   _twiceAmonth;
    }
}