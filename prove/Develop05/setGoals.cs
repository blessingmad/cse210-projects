using System;
public class setGoals : Goals
{
    private double _recordGoal;
    private double _putPoints;
    public setGoals(string markComplete, double recordGoal, double _putPoints ) : base(markComplete);
    {
        _recordGoal = recordGoal;
        _putPoints = putPoints;
    }

    public override double GetRecord()
    {
        return ${_recordGoal} ;
    }
}