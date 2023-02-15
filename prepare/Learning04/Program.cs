using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime theCurrentTime = DateTime.Today;
        string dateText = theCurrentTime.ToShortDateString();

        Console.WriteLine($"{dateText}");
        
        Assignment assignment1 = new Assignment();
        assignment1.SetStudentName("Blessing Mlambo");
        assignment1.SetTopic("Multpication");

        Console.WriteLine(assignment1.GetSummary());

        MathAssignment assignment2 = new MathAssignment();
        assignment2.SetTextBookSection("Section 7:12");
        assignment2.SetProblems("9 - 18");

        Console.WriteLine(assignment2.GetHomeWorkList());

        WritingAssignment assignment3 = new WritingAssignment();
        assignment3.SetTopic("European History");
        assignment3.SetTitle("The Cause of World War II");

        Console.WriteLine(assignment3.GetWritingInformation());
    }
}