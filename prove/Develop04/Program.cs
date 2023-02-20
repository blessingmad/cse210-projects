using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("...................................");
        Console.WriteLine("Author: Blessing Madhuma");
        Console.WriteLine("..................................");
        DateTime theCurrentDateTime = DateTime.Today;
        string dateText = theCurrentDateTime.ToLongDateString();
        
        Console.WriteLine($"{dateText}");
        Console.WriteLine(".................................");

        Activity a1 = new Activity("");
        Console.WriteLine(a1.GetDetails());
        
    }
}