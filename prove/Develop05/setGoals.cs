using System;
public class setGoals : Goals
{
    private string _getGoal;
    private string _check ;
    public setGoals(string markComplete, string getGoal, string check) : base (markComplete)
    {
        _getGoal = getGoal;
        _check = check;
    }
    public override string GetRecord()
    {
        return   _getGoal;
    }
}