using System;
public class passSacrament : Goals
{
    private string _twiceAmonth ;
    private string _getPoints ;
    public passSacrament(string markComplete, string twiceAmonth, string getPoints) : base (markComplete)
    {
        _twiceAmonth = twiceAmonth;
        _getPoints = getPoints;
    }
    public override string GetRecord()
    {
        return   _twiceAmonth;
    }
}