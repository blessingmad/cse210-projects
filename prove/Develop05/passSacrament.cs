using System;
public class passSacrament : Goals
{
    private string _twiceAmonth ;
    private string _getNumber ;
    public passSacrament(string markComplete, string twiceAmonth, string getNumber) : base (markComplete)
    {
        _twiceAmonth = twiceAmonth;
        _getNumber = getNumber;
    }
    public override string GetRecord()
    {
        return   _twiceAmonth;
    }
}