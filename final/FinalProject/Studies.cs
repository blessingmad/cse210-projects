using System;
public abstract class Studies
{
    private string _record;
    private string _scripture;
    public Studies(string record, string scripture)
    {
        _record = record;
        _scripture = scripture;
    }
    public string GetRecord()   
    {
        return _record;
    }
    public string GetScripture()
    {
        return _scripture;
    }
    public abstract string GetSummary();
    
}