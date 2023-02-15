using System;

public class MathAssignment : Assignment
{
    private string _textBookSection = "";
    private string _problems = "";

    public string GetTextBookSection()
    {
        return _textBookSection;
    }
    public void SetTextBookSection(string textBookSection)
    {
        _textBookSection = textBookSection;
    }
    public string GetProblems()
    {
        return _problems;
    }
    public void SetProblems(string problems)
    {
        _problems = problems;
    }
    public String GetHomeWorkList()
    {
        return $"{_studentName} {_topic}{_textBookSection} Problems {_problems}";
        
        
    }
}