using System;
public abstract class Goals
{
    private string _markComplete;
    //private int _recordScore;

    public Goals(string markComplete)
    {
        _markComplete = markComplete;
    }
    public string GetComplete()
    {
        return _markComplete;
    }
    public abstract string GetRecord();
}