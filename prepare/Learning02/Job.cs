using System;

public class Job
{   public string _jobTitle ;
    public string _jobCompany ;
    public int _startYear ;
    public int _endYear;

    public string _name;
    public string _jobs;
    public void Display()
        {
            Console.WriteLine($"{_jobTitle} ({_jobCompany}){_startYear}  - {_endYear}");
            Console.WriteLine();
        }

    
}


